using RimWorld;
using Verse;

namespace SimpleStockpilePresets
{
    // Token: 0x02000007 RID: 7
    [DefOf]
    public static class SpecialThingFilterDefOf
    {
        // Token: 0x0400000B RID: 11
        public static SpecialThingFilterDef AllowRotten;

        // Token: 0x0400000C RID: 12
        public static SpecialThingFilterDef AllowFresh;

        // Token: 0x0400000D RID: 13
        public static SpecialThingFilterDef AllowSmeltable;

        // Token: 0x0400000E RID: 14
        public static SpecialThingFilterDef AllowNonSmeltableWeapons;

        // Token: 0x0400000F RID: 15
        public static SpecialThingFilterDef AllowNonDeadmansApparel;

        // Token: 0x04000010 RID: 16
        public static SpecialThingFilterDef AllowDeadmansApparel;

        // Token: 0x04000011 RID: 17
        public static SpecialThingFilterDef AllowCorpsesColonist;

        // Token: 0x04000012 RID: 18
        public static SpecialThingFilterDef AllowCorpsesStranger;

        // Token: 0x06000018 RID: 24 RVA: 0x00002A8D File Offset: 0x00000C8D
        static SpecialThingFilterDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(SpecialThingFilterDefOf));
        }
    }
}