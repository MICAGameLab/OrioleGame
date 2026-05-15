public static class Arachnophobia_GlobalSetting
{
    public static bool IsEnabled => isEnabled;
    private static bool isEnabled = false;

    public static void SetIsEnabled(bool newIsEnabled)
    {
        isEnabled = newIsEnabled;
    }
}
