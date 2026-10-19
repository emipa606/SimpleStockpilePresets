using System.Reflection;
using Verse;

namespace SimpleStockpilePresets;

[StaticConstructorOnStartup]
internal static class Harmony
{
    static Harmony()
    {
        new HarmonyLib.Harmony("rimworld.lanilor.simplestockpilepresets").PatchAll(Assembly.GetExecutingAssembly());
    }
}