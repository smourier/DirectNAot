#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrimagepresenter9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("69188c61-12a3-40f0-8ffc-342e7b433fd7")]
public partial interface IVMRImagePresenter9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrimagepresenter9-startpresenting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartPresenting(nuint dwUserID);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrimagepresenter9-stoppresenting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopPresenting(nuint dwUserID);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrimagepresenter9-presentimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PresentImage(nuint dwUserID, in VMR9PresentationInfo lpPresInfo);
}
