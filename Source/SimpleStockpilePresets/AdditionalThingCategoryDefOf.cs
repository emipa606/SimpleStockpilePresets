using RimWorld;
using Verse;

namespace SimpleStockpilePresets;

[DefOf]
public static class AdditionalThingCategoryDefOf
{
    public static ThingCategoryDef MortarShells;

    public static ThingCategoryDef EggsFertilized;

    static AdditionalThingCategoryDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(AdditionalThingCategoryDefOf));
    }
}