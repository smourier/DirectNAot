#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3draster-status
public partial struct D3DRASTER_STATUS
{
    public BOOL InVBlank;
    public uint ScanLine;
}
