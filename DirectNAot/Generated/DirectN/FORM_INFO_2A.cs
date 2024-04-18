namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/form-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct FORM_INFO_2A
{
    public uint Flags;
    public PSTR pName;
    public nint Size;
    public RECTL ImageableArea;
    public PSTR pKeyword;
    public uint StringType;
    public PSTR pMuiDll;
    public uint dwResourceId;
    public PSTR pDisplayName;
    public ushort wLangId;
}
