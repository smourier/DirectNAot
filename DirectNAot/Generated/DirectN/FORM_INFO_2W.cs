namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/form-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct FORM_INFO_2W
{
    public uint Flags;
    public PWSTR pName;
    public nint Size;
    public RECTL ImageableArea;
    public PSTR pKeyword;
    public uint StringType;
    public PWSTR pMuiDll;
    public uint dwResourceId;
    public PWSTR pDisplayName;
    public ushort wLangId;
}
