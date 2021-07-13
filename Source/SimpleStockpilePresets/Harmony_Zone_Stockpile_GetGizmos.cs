using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace SimpleStockpilePresets
{
    // Token: 0x02000003 RID: 3
    [HarmonyPatch("GetGizmos")]
    [HarmonyPatch(typeof(Zone_Stockpile))]
    public class Harmony_Zone_Stockpile_GetGizmos
    {
        // Token: 0x06000003 RID: 3 RVA: 0x0000207D File Offset: 0x0000027D
        public static void Postfix(Zone_Stockpile __instance, ref IEnumerable<Gizmo> __result)
        {
            var newList = __result.ToList();
            newList.Add(new Command_StorageSettingsPresets(__instance));
            __result = newList;
        }
    }
}