#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrimagepresenter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ce704fe7-e71e-41fb-baa2-c4403e1182f5")]
public partial interface IVMRImagePresenter
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagepresenter-startpresenting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartPresenting(nuint dwUserID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagepresenter-stoppresenting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopPresenting(nuint dwUserID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrimagepresenter-presentimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PresentImage(nuint dwUserID, in VMRPRESENTATIONINFO lpPresInfo);
}
