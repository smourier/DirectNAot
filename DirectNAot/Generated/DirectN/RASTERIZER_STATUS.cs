namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-rasterizer_status
[StructLayout(LayoutKind.Sequential)]
public partial struct RASTERIZER_STATUS
{
    public short nSize;
    public short wFlags;
    public short nLanguageID;
}
