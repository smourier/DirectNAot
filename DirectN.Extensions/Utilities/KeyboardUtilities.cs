namespace DirectN.Extensions.Utilities;

public static partial class KeyboardUtilities
{
    public static bool IsShiftDown => Functions.GetKeyState((int)VIRTUAL_KEY.VK_SHIFT) < 0;
    public static bool IsControlDown => Functions.GetKeyState((int)VIRTUAL_KEY.VK_CONTROL) < 0;
    public static bool IsAltDown => Functions.GetKeyState((int)VIRTUAL_KEY.VK_MENU) < 0;

    public static KEYMODIFIERS GetKEYMODIFIERS()
    {
        KEYMODIFIERS km = 0;
        if (IsShiftDown)
        {
            km |= KEYMODIFIERS.KEYMOD_SHIFT;
        }

        if (IsControlDown)
        {
            km |= KEYMODIFIERS.KEYMOD_CONTROL;
        }

        if (IsAltDown)
        {
            km |= KEYMODIFIERS.KEYMOD_ALT;
        }
        return km;
    }

    // similar to PowerShell's Get-WinUserLanguageList
    [SupportedOSPlatform("windows8.0")]
    public static IReadOnlyList<UserLanguage> GetUserLanguages()
    {
        const char delimiter = ';';
        GetUserLanguages(delimiter, out var userLanguages);
        var langs = HSTRING.GetString(userLanguages);
        var list = new List<UserLanguage>();
        foreach (var lang in langs?.Split(delimiter, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries) ?? [])
        {
            if (lang != null)
            {
                var language = new UserLanguage
                {
                    Name = lang
                };

                if (GetUserLanguageInputMethods(PWSTR.From(lang), delimiter, out var inputMethods).IsError)
                {
                    WGIGetUserLanguageInputMethods(PWSTR.From(lang), out inputMethods);
                }

                var methods = HSTRING.GetString(inputMethods);
                var imts = new List<string>();
                foreach (var method in methods?.Split(delimiter, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries) ?? [])
                {
                    if (method != null)
                    {
                        imts.Add(method);
                    }
                }

                language.InputMethodTips = [.. imts];

                if (language.InputMethodTips.Count > 0)
                {
                    var firstImt = language.InputMethodTips[0];

                    // https://learn.microsoft.com/en-us/windows-hardware/manufacture/desktop/windows-language-pack-default-values
                    // format is {0409:0000040C} (not sure where it is documented)
                    var parts = firstImt.Trim('{', '}').Split(':');
                    if (parts.Length == 2)
                    {
                        language.KeyboardLayout = KeyboardLayout.GetKeyboardLayout(parts[1]);
                    }
                }

                list.Add(language);
            }
        }
        return [.. list];
    }

    [LibraryImport("bcp47langs")]
    private static partial int GetUserLanguages(char delimiter, out HSTRING userLanguages);

    [LibraryImport("bcp47langs")]
    private static partial HRESULT GetUserLanguageInputMethods(PWSTR language, char delimiter, out HSTRING inputMethods);

    [LibraryImport("ext-ms-win-globalization-input-l1-1-3.dll")]
    private static partial HRESULT WGIGetUserLanguageInputMethods(PWSTR language, out HSTRING inputMethods);
}
