using System.Collections.Generic;
using System.Linq;
using RimWorld;
using UnityEngine;
using Verse;

namespace SimpleStockpilePresets;

[StaticConstructorOnStartup]
public class Command_StorageSettingsPresets : Command
{
    public readonly ThingFilter filter;

    public Command_StorageSettingsPresets(Zone_Stockpile stockpile)
    {
        icon = ContentFinder<Texture2D>.Get("UI/Commands/StorageSettingsPresets");
        defaultLabel = "CommandStorageSettingsPresetsLabel".Translate();
        defaultDesc = "CommandStorageSettingsPresetsDesc".Translate();
        filter = stockpile.settings.filter;
    }

    public override void ProcessInput(Event ev)
    {
        base.ProcessInput(ev);
        var list = new List<FloatMenuOption>();
        _ = (from dd in DefDatabase<ThingCategoryDef>.AllDefsListForReading
            where dd.defName == "EggsFertilized"
            select dd).ToList().First();
        _ = (from dd in DefDatabase<ThingDef>.AllDefsListForReading
            where dd.defName == "MedicineHerbal"
            select dd).ToList().First();
        list.Add(new FloatMenuOption("CSSP_GeneralFreezer".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Foods, true);
            filter.SetAllow(ThingDefOf.Ambrosia, true);
            filter.SetAllow(ThingDefOf.Beer, true);
            filter.SetAllow(ThingDefOf.Wort, true);
            filter.SetAllow(ThingDefOf.MedicineHerbal, true);
            filter.SetAllow(ThingCategoryDefOf.PlantMatter, true);
            filter.SetAllow(ThingCategoryDefOf.CorpsesHumanlike, true);
            filter.SetAllow(ThingCategoryDefOf.CorpsesAnimal, true);
            filter.SetAllow(AdditionalThingCategoryDefOf.EggsFertilized, false);
            filter.SetAllow(SpecialThingFilterDefOf.AllowRotten, false);
        }));
        list.Add(new FloatMenuOption("CSSP_FreezerNoMeals".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Foods, true);
            filter.SetAllow(ThingCategoryDef.Named("FoodMeals"), false);
            filter.SetAllow(ThingDefOf.Ambrosia, true);
            filter.SetAllow(ThingDefOf.Beer, true);
            filter.SetAllow(ThingDefOf.Wort, true);
            filter.SetAllow(ThingDefOf.MedicineHerbal, true);
            filter.SetAllow(ThingCategoryDefOf.PlantMatter, true);
            filter.SetAllow(ThingCategoryDefOf.CorpsesHumanlike, true);
            filter.SetAllow(ThingCategoryDefOf.CorpsesAnimal, true);
            filter.SetAllow(AdditionalThingCategoryDefOf.EggsFertilized, false);
            filter.SetAllow(SpecialThingFilterDefOf.AllowRotten, false);
        }));
        list.Add(new FloatMenuOption("CSSP_Meals".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDef.Named("FoodMeals"), true);
            filter.SetAllow(SpecialThingFilterDefOf.AllowRotten, false);
        }));
        list.Add(new FloatMenuOption("CSSP_GeneralStorage".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Manufactured, true);
            filter.SetAllow(ThingDefOf.Ambrosia, false);
            filter.SetAllow(ThingDefOf.Beer, false);
            filter.SetAllow(ThingDefOf.Wort, false);
            filter.SetAllow(ThingCategoryDefOf.ResourcesRaw, true);
            filter.SetAllow(ThingCategoryDefOf.PlantMatter, false);
            filter.SetAllow(AdditionalThingCategoryDefOf.EggsFertilized, true);
            filter.SetAllow(ThingCategoryDefOf.Items, true);
            filter.SetAllow(ThingCategoryDefOf.Weapons, true);
            filter.SetAllow(ThingCategoryDefOf.Apparel, true);
            filter.SetAllow(ThingCategoryDefOf.Buildings, true);
            filter.SetAllow(ThingCategoryDefOf.CorpsesMechanoid, true);
        }));
        list.Add(new FloatMenuOption("CSSP_GeneralMedical".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Medicine, true);
            filter.SetAllow(ThingCategoryDefOf.Drugs, true);
            filter.SetAllow(ThingDefOf.Ambrosia, false);
            filter.SetAllow(ThingDefOf.Beer, false);
            filter.SetAllow(ThingDefOf.Neutroamine, true);
            filter.SetAllow(ThingCategoryDefOf.BodyParts, true);
        }));
        list.Add(new FloatMenuOption("CSSP_Drugs".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Drugs, true);
            filter.SetAllow(ThingDefOf.Ambrosia, false);
            filter.SetAllow(ThingDefOf.Beer, false);
            filter.SetAllow(ThingDefOf.Neutroamine, true);
        }));
        list.Add(new FloatMenuOption("CSSP_MaterialsOutside".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.StoneBlocks, true);
            filter.SetAllow(ThingDefOf.Plasteel, true);
            filter.SetAllow(ThingDefOf.Silver, true);
            filter.SetAllow(ThingDefOf.Steel, true);
            filter.SetAllow(ThingDefOf.Uranium, true);
        }));
        list.Add(new FloatMenuOption("CSSP_Materials".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.ResourcesRaw, true);
            filter.SetAllow(ThingCategoryDefOf.PlantMatter, false);
        }));
        list.Add(new FloatMenuOption("CSSP_VariousOthers".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Manufactured, true);
            filter.SetAllow(ThingCategoryDefOf.Medicine, false);
            filter.SetAllow(ThingCategoryDefOf.Drugs, false);
            filter.SetAllow(ThingDefOf.Neutroamine, false);
            filter.SetAllow(ThingDefOf.Wort, false);
            filter.SetAllow(ThingCategoryDefOf.Items, true);
            filter.SetAllow(ThingCategoryDefOf.BodyParts, false);
            filter.SetAllow(ThingCategoryDefOf.Weapons, true);
            filter.SetAllow(ThingCategoryDefOf.Apparel, true);
            filter.SetAllow(ThingCategoryDefOf.Buildings, true);
            filter.SetAllow(ThingCategoryDefOf.CorpsesMechanoid, true);
            filter.SetAllow(SpecialThingFilterDefOf.AllowDeadmansApparel, false);
        }));
        list.Add(new FloatMenuOption("CSSP_Shells".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(AdditionalThingCategoryDefOf.MortarShells, true);
        }));
        list.Add(new FloatMenuOption("CSSP_Weapons".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Weapons, true);
        }));
        list.Add(new FloatMenuOption("CSSP_CleanApparel".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Apparel, true);
            filter.SetAllow(SpecialThingFilterDefOf.AllowDeadmansApparel, false);
        }));
        list.Add(new FloatMenuOption("CSSP_TaintedApparel".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Apparel, true);
            filter.SetAllow(SpecialThingFilterDefOf.AllowNonDeadmansApparel, false);
        }));
        list.Add(new FloatMenuOption("CSSP_Chunks".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Chunks, true);
        }));
        list.Add(new FloatMenuOption("CSSP_Rotting".Translate(), delegate
        {
            filter.SetDisallowAll();
            filter.SetAllow(ThingCategoryDefOf.Apparel, true);
            filter.SetAllow(ThingCategoryDefOf.CorpsesHumanlike, true);
            filter.SetAllow(ThingCategoryDefOf.CorpsesAnimal, true);
            filter.SetAllow(SpecialThingFilterDefOf.AllowFresh, false);
            filter.SetAllow(SpecialThingFilterDefOf.AllowNonDeadmansApparel, false);
        }));
        Find.WindowStack.Add(new FloatMenu(list));
    }
}