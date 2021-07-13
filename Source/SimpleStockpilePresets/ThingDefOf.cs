using RimWorld;
using Verse;

namespace SimpleStockpilePresets
{
    // Token: 0x02000005 RID: 5
    [DefOf]
    public static class ThingDefOf
    {
        // Token: 0x04000002 RID: 2
        public static ThingDef Ambrosia;

        // Token: 0x04000003 RID: 3
        public static ThingDef Beer;

        // Token: 0x04000004 RID: 4
        public static ThingDef Neutroamine;

        // Token: 0x04000005 RID: 5
        public static ThingDef Wort;

        // Token: 0x04000006 RID: 6
        public static ThingDef Plasteel;

        // Token: 0x04000007 RID: 7
        public static ThingDef Silver;

        // Token: 0x04000008 RID: 8
        public static ThingDef Steel;

        // Token: 0x04000009 RID: 9
        public static ThingDef Uranium;


        public static ThingDef MedicineHerbal;

        // Token: 0x06000006 RID: 6 RVA: 0x000020AA File Offset: 0x000002AA
        static ThingDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
        }
    }
}