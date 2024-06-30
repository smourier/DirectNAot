#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dlocked-box
public partial struct D3DLOCKED_BOX
{
    public int RowPitch;
    public int SlicePitch;
    public nint pBits;
}
