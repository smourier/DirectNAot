namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_cached_pipeline_state
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_CACHED_PIPELINE_STATE
{
    public nint pCachedBlob;
    public nuint CachedBlobSizeInBytes;
}
