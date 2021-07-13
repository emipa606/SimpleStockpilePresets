using RimWorld;
using Verse;

namespace SimpleStockpilePresets
{
    // Token: 0x02000004 RID: 4
    [DefOf]
    public static class AdditionalThingCategoryDefOf
    {
        // Token: 0x04000001 RID: 1
        public static ThingCategoryDef MortarShells;

        public static ThingCategoryDef EggsFertilized;

        // Token: 0x06000005 RID: 5 RVA: 0x00002097 File Offset: 0x00000297
        static AdditionalThingCategoryDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(AdditionalThingCategoryDefOf));
        }
    }
}