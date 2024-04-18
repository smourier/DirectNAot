namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_local_root_signature
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_LOCAL_ROOT_SIGNATURE
{
    public nint pLocalRootSignature;
}
