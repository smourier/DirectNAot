#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFILTERCHOOSEW
{
    public uint cbStruct;
    public uint fdwStyle;
    public HWND hwndOwner;
    public nint pwfltr;
    public uint cbwfltr;
    public PWSTR pszTitle;
    public InlineArraySystemChar48 szFilterTag;
    public InlineArraySystemChar128 szFilter;
    public PWSTR pszName;
    public uint cchName;
    public uint fdwEnum;
    public nint pwfltrEnum;
    public HINSTANCE hInstance;
    public PWSTR pszTemplateName;
    public LPARAM lCustData;
    public nint pfnHook;
}
