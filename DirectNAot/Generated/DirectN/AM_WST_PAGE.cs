#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/iwstdec/ns-iwstdec-am_wst_page
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_WST_PAGE
{
    public uint dwPageNr;
    public uint dwSubPageNr;
    public nint pucPageData;
}
