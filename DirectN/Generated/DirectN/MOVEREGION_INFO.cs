#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MOVEREGION_INFO
{
    public uint FrameNumber;
    public uint NumMoveRegions;
    public InlineArrayMOVE_RECT_1 MoveRegions; // variable-length array placeholder
}
