#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquireplugin
[GeneratedComInterface, Guid("00f2dceb-ecb8-4f77-8e47-e7a987c83dd0")]
public partial interface IPhotoAcquirePlugin
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireplugin-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IPhotoAcquireSource? pPhotoAcquireSource, IPhotoAcquireProgressCB? pPhotoAcquireProgressCB);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireplugin-processitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessItem(uint dwAcquireStage, IPhotoAcquireItem? pPhotoAcquireItem, IStream? pOriginalItemStream, PWSTR pszFinalFilename, IPropertyStore? pPropertyStore);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireplugin-transfercomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferComplete(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireplugin-displayconfiguredialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayConfigureDialog(HWND hWndParent);
}
