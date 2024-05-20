#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgikeyedmutex
[GeneratedComInterface, Guid("9d8e1289-d7b3-465f-8126-250e349af85d")]
public partial interface IDXGIKeyedMutex : IDXGIDeviceSubObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgikeyedmutex-acquiresync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireSync(ulong Key, uint dwMilliseconds);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgikeyedmutex-releasesync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseSync(ulong Key);
}
