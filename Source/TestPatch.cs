using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace AddIngredientCategories {
    //[HarmonyPatch]
    public static class TestPatch {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(ThingDefGenerator_Meat), nameof(ThingDefGenerator_Meat.ImpliedMeatDefs))]
        public static void ImpliedMeatDefs() {
        }
    }
}
