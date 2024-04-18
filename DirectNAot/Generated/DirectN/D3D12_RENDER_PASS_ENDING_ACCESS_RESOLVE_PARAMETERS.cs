namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_render_pass_ending_access_resolve_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS
{
    public nint pSrcResource;
    public nint pDstResource;
    public uint SubresourceCount;
    public nint pSubresourceParameters;
    public DXGI_FORMAT Format;
    public D3D12_RESOLVE_MODE ResolveMode;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PreserveResolveSource;
}
