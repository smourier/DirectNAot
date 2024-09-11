#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquireplugin
[GeneratedComInterface, Guid("00f2dceb-ecb8-4f77-8e47-e7a987c83dd0")]
public partial interface IPhotoAcquirePlugin
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireplugin-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireSource?>))] IPhotoAcquireSource? pPhotoAcquireSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireProgressCB?>))] IPhotoAcquireProgressCB? pPhotoAcquireProgressCB);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireplugin-processitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessItem(uint dwAcquireStage, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPhotoAcquireItem?>))] IPhotoAcquireItem? pPhotoAcquireItem, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream?>))] IStream? pOriginalItemStream, PWSTR pszFinalFilename, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyStore?>))] IPropertyStore? pPropertyStore);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireplugin-transfercomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferComplete(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireplugin-displayconfiguredialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayConfigureDialog(HWND hWndParent);
}
