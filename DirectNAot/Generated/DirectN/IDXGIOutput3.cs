namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgioutput3
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("8a6bb301-7e7e-41f4-a8e0-5b32f7f99b18")]
public partial interface IDXGIOutput3 : IDXGIOutput2
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgioutput3-checkoverlaysupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckOverlaySupport(DXGI_FORMAT EnumFormat, nint pConcernedDevice, out uint pFlags);
}
