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
            PluginName = "点赞滤波";
            PluginCont = "support@sakurakooi.dev";
            PluginVer = "v114.514";
        }


        private void Class1_Connected(object sender, ConnectedEvtArgs e) {
            Debouncer.reset();
        }

        public override void Start() {
            base.Start();
            Log("[Like debouncer] Hooking ...");
            hook();
            AddDM("[Like debouncer] Taking over the world...",true);
        }

        public override void Stop() {
            base.Stop();
            Log("[Like debouncer] Removing hook...");
            unhook();
        }

        public override void Admin() {
            base.Admin();
            var form = new SettingsForm();
            form.ShowDialog();
        }

        public void hook() {
            Log("[Like debouncer] Locating 'Bililive_dm.MainWindow.ProcDanmaku'...");
            MethodBase writeLineMethod = "Bililive_dm.MainWindow".GetMethod("ProcDanmaku", new[] {typeof(DanmakuModel)}, BindingFlags.NonPublic);
            if (writeLineMethod == null) {
                Log("[Like debouncer] Failed to locate 'Bililive_dm.MainWindow.ProcDanmaku'.");
                return;
            }

            Log("[Like debouncer] Locating 'bililive_dm_like_debounce.Debouncer.ProcDanmakuHook'...");
            MethodBase replacementMethod = "bililive_dm_like_debounce.Debouncer".GetMethod("ProcDanmakuHook", BindingFlags.Static | BindingFlags.Public);
            if (replacementMethod == null) {
                Log("[Like debouncer] Failed to locate 'bililive_dm_like_debounce.Debouncer.ProcDanmakuHook'.");
                return;
            }

            _managedHook = new ManagedHook(writeLineMethod, replacementMethod);
            Log("[Like debouncer] Trying take over the world! ...");
            _managedHook.Apply();
            Log("[Like debouncer] Success! Plugin loaded.");
        }

        public void unhook() {
            if (_managedHook != null) {
                Log("[Like debouncer] Restoring original function...");
                _managedHook.Remove();
                Log("[Like debouncer] Success! Plugin unloaded.");
            }
        }
    }
}