#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-dropfiles
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DROPFILES
{
    public uint pFiles;
    public POINT pt;
    public BOOL fNC;
    public BOOL fWide;
}
