namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_ROOT_SIGNATURE_DESC2
{
    public uint NumParameters;
    public nint pParameters;
    public uint NumStaticSamplers;
    public nint pStaticSamplers;
    public D3D12_ROOT_SIGNATURE_FLAGS Flags;
}
