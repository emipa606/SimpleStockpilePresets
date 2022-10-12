using System.Reflection;
using Verse;

namespace SimpleStockpilePresets;

[StaticConstructorOnStartup]
internal class Harmony
{
    static Harmony()
    {
        var harmonyInstance = new HarmonyLib.Harmony("rimworld.lanilor.simplestockpilepresets");
        harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
    }
}