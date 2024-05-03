using MelonLoader;
using HarmonyLib;
using UnityEngine;


namespace UnityLog2Melon
{
    public class Unity2Melon : MelonMod
    {
        public static MelonLogger.Instance logger;
        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            logger = LoggerInstance;
            HarmonyInstance.PatchAll();
        }

        [HarmonyPatch(typeof(Debug))]
        [HarmonyPatch(nameof(Debug.Log))]
        [HarmonyPatch(new System.Type[]
        {
            typeof(object)
        })]
        public static class DebugLogPatch
        {
            public static void Postfix(ref object message)
            {
                logger.Msg(message);
            }
        }
    }
}
