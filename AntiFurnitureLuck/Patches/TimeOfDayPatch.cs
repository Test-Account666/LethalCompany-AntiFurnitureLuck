using HarmonyLib;

namespace AntiFurnitureLuck.Patches;

[HarmonyPatch(typeof(TimeOfDay))]
public static class TimeOfDayPatch {
    [HarmonyPatch(nameof(TimeOfDay.CalculateLuckValue))]
    [HarmonyPrefix]
    // ReSharper disable once InconsistentNaming
    public static bool DisableLuckValue(TimeOfDay __instance) {
        __instance.luckValue = 0;
        return false;
    }
}