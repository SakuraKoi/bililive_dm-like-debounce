// Project: bililive_dm-like-debounce
// Debouncer.cs
// 
// Create Date: 2023-09-25 9:12

using System;
using System.Collections.Generic;
using System.Reflection;
using BilibiliDM_PluginFramework;
using DotNetHook.Extensions;
using DotNetHook.Hooks;

namespace bililive_dm_like_debounce {
    public class Debouncer {
        private static Dictionary<long, long> debounce = new Dictionary<long, long>();
        public static int frequency;
        public static bool intervalMode;

        public static void reset() {
            debounce.Clear();
        }


        // ReSharper disable once UnusedMember.Global
        public static void ProcDanmakuHook(object thisObj, DanmakuModel danmakuModel) {
            if (danmakuModel.MsgType == MsgTypeEnum.Interact && danmakuModel.InteractType == InteractTypeEnum.Like) {
                long lastTime;
                if (debounce.TryGetValue(danmakuModel.UserID_long, out lastTime)) {
                    if (!intervalMode)
                        saveDebounceTime(danmakuModel);

                    if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - lastTime < frequency)
                        return;
                }

                saveDebounceTime(danmakuModel);
            }

            PluginClass._managedHook.Call(thisObj, danmakuModel);
        }

        private static void saveDebounceTime(DanmakuModel danmakuModel) {
            debounce[danmakuModel.UserID_long] = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }
    }
}