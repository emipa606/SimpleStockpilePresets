using System;
using System.Collections.Generic;
using RimWorld;
using UnityEngine;
using Verse;

namespace SimpleStockpilePresets
{
	// Token: 0x02000006 RID: 6
	[StaticConstructorOnStartup]
	public class Command_StorageSettingsPresets : Command
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000020C0 File Offset: 0x000002C0
		public Command_StorageSettingsPresets(Zone_Stockpile stockpile)
		{
			this.icon = ContentFinder<Texture2D>.Get("UI/Commands/StorageSettingsPresets", true);
			this.defaultLabel = Translator.Translate("CommandStorageSettingsPresetsLabel");
			this.defaultDesc = Translator.Translate("CommandStorageSettingsPresetsDesc");
			this.filter = stockpile.settings.filter;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000027CC File Offset: 0x000009CC
		public override void ProcessInput(Event ev)
		{
			base.ProcessInput(ev);
			List<FloatMenuOption> list = new List<FloatMenuOption>();
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_GeneralFreezer"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Foods, true, null, null);
				this.filter.SetAllow(ThingDefOf.Ambrosia, true);
				this.filter.SetAllow(ThingDefOf.Beer, true);
				this.filter.SetAllow(ThingDefOf.Wort, true);
				this.filter.SetAllow(ThingCategoryDefOf.PlantMatter, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.CorpsesHumanlike, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.CorpsesAnimal, true, null, null);
				this.filter.SetAllow(SpecialThingFilterDefOf.AllowRotten, false);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_FreezerNoMeals"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Foods, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.FoodMeals, false, null, null);
				this.filter.SetAllow(ThingDefOf.Ambrosia, true);
				this.filter.SetAllow(ThingDefOf.Beer, true);
				this.filter.SetAllow(ThingDefOf.Wort, true);
				this.filter.SetAllow(ThingCategoryDefOf.PlantMatter, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.CorpsesHumanlike, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.CorpsesAnimal, true, null, null);
				this.filter.SetAllow(SpecialThingFilterDefOf.AllowRotten, false);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_Meals"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.FoodMeals, true, null, null);
				this.filter.SetAllow(SpecialThingFilterDefOf.AllowRotten, false);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_GeneralStorage"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Manufactured, true, null, null);
				this.filter.SetAllow(ThingDefOf.Ambrosia, false);
				this.filter.SetAllow(ThingDefOf.Beer, false);
				this.filter.SetAllow(ThingDefOf.Wort, false);
				this.filter.SetAllow(ThingCategoryDefOf.ResourcesRaw, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.PlantMatter, false, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Items, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Weapons, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Apparel, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Buildings, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.CorpsesMechanoid, true, null, null);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_GeneralMedical"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Medicine, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Drugs, true, null, null);
				this.filter.SetAllow(ThingDefOf.Ambrosia, false);
				this.filter.SetAllow(ThingDefOf.Beer, false);
				this.filter.SetAllow(ThingDefOf.Neutroamine, true);
				this.filter.SetAllow(ThingCategoryDefOf.BodyParts, true, null, null);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_Drugs"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Drugs, true, null, null);
				this.filter.SetAllow(ThingDefOf.Ambrosia, false);
				this.filter.SetAllow(ThingDefOf.Beer, false);
				this.filter.SetAllow(ThingDefOf.Neutroamine, true);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_MaterialsOutside"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.StoneBlocks, true, null, null);
				this.filter.SetAllow(ThingDefOf.Plasteel, true);
				this.filter.SetAllow(ThingDefOf.Silver, true);
				this.filter.SetAllow(ThingDefOf.Steel, true);
				this.filter.SetAllow(ThingDefOf.Uranium, true);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_Materials"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.ResourcesRaw, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.PlantMatter, false, null, null);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_VariousOthers"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Manufactured, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Medicine, false, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Drugs, false, null, null);
				this.filter.SetAllow(ThingDefOf.Neutroamine, false);
				this.filter.SetAllow(ThingDefOf.Wort, false);
				this.filter.SetAllow(ThingCategoryDefOf.Items, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.BodyParts, false, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Weapons, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Apparel, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Buildings, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.CorpsesMechanoid, true, null, null);
				this.filter.SetAllow(SpecialThingFilterDefOf.AllowDeadmansApparel, false);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_Shells"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(AdditionalThingCategoryDefOf.MortarShells, true, null, null);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_Weapons"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Weapons, true, null, null);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_CleanApparel"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Apparel, true, null, null);
				this.filter.SetAllow(SpecialThingFilterDefOf.AllowDeadmansApparel, false);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_TaintedApparel"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Apparel, true, null, null);
				this.filter.SetAllow(SpecialThingFilterDefOf.AllowNonDeadmansApparel, false);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_Chunks"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Chunks, true, null, null);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			list.Add(new FloatMenuOption(Translator.Translate("CSSP_Rotting"), delegate()
			{
				this.filter.SetDisallowAll(null, null);
				this.filter.SetAllow(ThingCategoryDefOf.Apparel, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.CorpsesHumanlike, true, null, null);
				this.filter.SetAllow(ThingCategoryDefOf.CorpsesAnimal, true, null, null);
				this.filter.SetAllow(SpecialThingFilterDefOf.AllowFresh, false);
				this.filter.SetAllow(SpecialThingFilterDefOf.AllowNonDeadmansApparel, false);
			}, MenuOptionPriority.Default, null, null, 0f, null, null));
			Find.WindowStack.Add(new FloatMenu(list));
		}

		// Token: 0x0400000A RID: 10
		public ThingFilter filter;
	}
}
