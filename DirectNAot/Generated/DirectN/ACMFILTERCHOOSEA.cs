#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFILTERCHOOSEA
{
    public uint cbStruct;
    public uint fdwStyle;
    public HWND hwndOwner;
    public nint pwfltr;
    public uint cbwfltr;
    public PSTR pszTitle;
    public InlineArrayFoundationCHAR48 szFilterTag;
    public InlineArrayFoundationCHAR128 szFilter;
    public PSTR pszName;
    public uint cchName;
    public uint fdwEnum;
    public nint pwfltrEnum;
    public HINSTANCE hInstance;
    public PSTR pszTemplateName;
    public LPARAM lCustData;
    public nint pfnHook;
}
