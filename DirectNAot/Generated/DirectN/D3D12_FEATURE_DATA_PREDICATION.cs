namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_PREDICATION
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Supported;
}
