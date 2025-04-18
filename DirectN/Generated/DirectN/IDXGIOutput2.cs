#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgioutput2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("595e39d1-2724-4663-99b1-da969de28364")]
public partial interface IDXGIOutput2 : IDXGIOutput1
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgioutput2-supportsoverlays
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL SupportsOverlays();
}
