#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_ARCHITECTURE_INFO
{
    [MarshalAs(UnmanagedType.U4)]
    public bool TileBasedDeferredRenderer;
}
