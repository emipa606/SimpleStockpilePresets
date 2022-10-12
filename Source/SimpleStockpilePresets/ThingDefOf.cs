using RimWorld;
using Verse;

namespace SimpleStockpilePresets;

[DefOf]
public static class ThingDefOf
{
    public static ThingDef Ambrosia;

    public static ThingDef Beer;

    public static ThingDef Neutroamine;

    public static ThingDef Wort;

    public static ThingDef Plasteel;

    public static ThingDef Silver;

    public static ThingDef Steel;

    public static ThingDef Uranium;


    public static ThingDef MedicineHerbal;

    static ThingDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
    }
}