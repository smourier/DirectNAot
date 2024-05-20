#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_glyph_run_description
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_GLYPH_RUN_DESCRIPTION
{
    public PWSTR localeName;
    public PWSTR @string;
    public uint stringLength;
    public nint clusterMap;
    public uint textPosition;
}
