#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("54d9007e-a8e2-4885-b7bf-f998deee4f2a")]
public partial interface ICLRGCManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Collect(int Generation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStats(ref COR_GC_STATS pStats);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGCStartupLimits(uint SegmentSize, uint MaxGen0Size);
}
