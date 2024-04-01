using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace SimpleStockpilePresets;

[HarmonyPatch(typeof(Zone_Stockpile), nameof(Zone_Stockpile.GetGizmos))]
public class Harmony_Zone_Stockpile_GetGizmos
{
    public static void Postfix(Zone_Stockpile __instance, ref IEnumerable<Gizmo> __result)
    {
        var newList = __result.ToList();
        newList.Add(new Command_StorageSettingsPresets(__instance));
        __result = newList;
    }
}