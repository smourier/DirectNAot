#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquireoptionsdialog
[GeneratedComInterface, Guid("00f2b3ee-bf64-47ee-89f4-4dedd79643f2")]
public partial interface IPhotoAcquireOptionsDialog
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireoptionsdialog-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(PWSTR pszRegistryRoot);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireoptionsdialog-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(HWND hWndParent, out HWND phWndDialog);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireoptionsdialog-destroy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Destroy();
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireoptionsdialog-domodal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoModal(HWND hWndParent, nint /* optional nint* */ ppnReturnCode);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquireoptionsdialog-savedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveData();
}
