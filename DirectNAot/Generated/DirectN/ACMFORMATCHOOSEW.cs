#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFORMATCHOOSEW
{
    public uint cbStruct;
    public uint fdwStyle;
    public HWND hwndOwner;
    public nint pwfx;
    public uint cbwfx;
    public PWSTR pszTitle;
    public InlineArraySystemChar_48 szFormatTag;
    public InlineArraySystemChar_128 szFormat;
    public PWSTR pszName;
    public uint cchName;
    public uint fdwEnum;
    public nint pwfxEnum;
    public HINSTANCE hInstance;
    public PWSTR pszTemplateName;
    public LPARAM lCustData;
    public nint pfnHook;
}
