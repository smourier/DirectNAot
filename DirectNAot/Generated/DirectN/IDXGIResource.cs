namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgiresource
[GeneratedComInterface, Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b")]
public partial interface IDXGIResource : IDXGIDeviceSubObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSharedHandle(out HANDLE pSharedHandle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUsage(out DXGI_USAGE pUsage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEvictionPriority(uint EvictionPriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEvictionPriority(out uint pEvictionPriority);
}
