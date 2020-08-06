using System;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace SimpleStockpilePresets
{
	// Token: 0x02000002 RID: 2
	[StaticConstructorOnStartup]
	internal class Harmony
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		static Harmony()
		{
			var harmonyInstance = new HarmonyLib.Harmony("rimworld.lanilor.simplestockpilepresets");
			harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
