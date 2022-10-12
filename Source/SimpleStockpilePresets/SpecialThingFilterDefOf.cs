using RimWorld;
using Verse;

namespace SimpleStockpilePresets;

[DefOf]
public static class SpecialThingFilterDefOf
{
    public static SpecialThingFilterDef AllowRotten;

    public static SpecialThingFilterDef AllowFresh;

    public static SpecialThingFilterDef AllowSmeltable;

    public static SpecialThingFilterDef AllowNonSmeltableWeapons;

    public static SpecialThingFilterDef AllowNonDeadmansApparel;

    public static SpecialThingFilterDef AllowDeadmansApparel;

    public static SpecialThingFilterDef AllowCorpsesColonist;

    public static SpecialThingFilterDef AllowCorpsesStranger;

    static SpecialThingFilterDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(SpecialThingFilterDefOf));
    }
}