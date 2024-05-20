#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE
{
    [MarshalAs(UnmanagedType.U4)]
    public bool IOCoherent;
}
