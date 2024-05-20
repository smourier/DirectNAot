#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXGK_WIN32K_PARAM_DATA
{
    public nint PathsArray;
    public nint ModesArray;
    public uint NumPathArrayElements;
    public uint NumModeArrayElements;
    public uint SDCFlags;
}
