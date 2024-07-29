#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/nn-mfsharingengine-imfimagesharingengine
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("cfa0ae8e-7e1c-44d2-ae68-fc4c148a6354")]
public partial interface IMFImageSharingEngine
{
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-imfimagesharingengine-setsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSource(nint pStream);
    
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-imfimagesharingengine-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(out DEVICE_INFO pDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-imfimagesharingengine-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
}
