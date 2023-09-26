using System;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Threading;
using BilibiliDM_PluginFramework;
using DotNetHook.Extensions;
using DotNetHook.Hooks;

namespace bililive_dm_like_debounce {
    // ReSharper disable once UnusedType.Global
    public class PluginClass : DMPlugin {
        public static ManagedHook _managedHook;

        public PluginClass() {
            Connected += Class1_Connected;
            PluginAuth = "SakuraKooi";
            PluginName = "点赞滤波器";
            PluginDesc = "过滤高频点赞";
            PluginCont = "support@sakurakooi.dev";
            PluginVer = "v114.514";
            if (Properties.Settings.Default.enabled)
                Start();
        }


        private void Class1_Connected(object sender, ConnectedEvtArgs e) {
            Debouncer.reset();
        }

        public override void Start() {
            base.Start();

            Debouncer.frequency = Properties.Settings.Default.frequency;
            Debouncer.intervalMode = Properties.Settings.Default.intervalMode;
            hook();
            Properties.Settings.Default.enabled = true;
            Properties.Settings.Default.Save();
        }

        public override void Stop() {
            base.Stop();
            unhook();
            Log("插件卸载成功.");
            Properties.Settings.Default.enabled = false;
            Properties.Settings.Default.Save();
        }

        public override void Admin() {
            base.Admin();
            var form = new SettingsForm();
            form.ShowDialog();
        }

        public void hook() {
            Log("定位函数 'MainWindow::ProcDanmaku' 内存地址...");
            MethodBase writeLineMethod = "Bililive_dm.MainWindow, Bililive_dm".GetMethod("ProcDanmaku", BindingFlags.Instance | BindingFlags.NonPublic);
            if (writeLineMethod == null) {
                Log("Err: Failed to locate 'MainWindow::ProcDanmaku'.");
                return;
            }

            Log("定位函数 'Debouncer::ProcDanmakuHook' 内存地址...");
            MethodBase replacementMethod = "bililive_dm_like_debounce.Debouncer".GetMethod("ProcDanmakuHook", BindingFlags.Static | BindingFlags.Public);
            if (replacementMethod == null) {
                Log("Err: Failed to locate 'Debouncer::ProcDanmakuHook'.");
                return;
            }

            _managedHook = new ManagedHook(writeLineMethod, replacementMethod);
            Log("Trying take over the world...");
            _managedHook.Apply();
            Log("函数劫持完成, 插件加载成功.");
            AddDM("Nya!w", true);
        }

        public void unhook() {
            if (_managedHook != null) {
                Log("正在还原弹幕处理函数ing...");
                _managedHook.Remove();
                Log("函数内存还原完毕.");
            }
        }
    }
}