namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquiredeviceselectiondialog
[GeneratedComInterface, Guid("00f28837-55dd-4f37-aaf5-6855a9640467")]
public partial interface IPhotoAcquireDeviceSelectionDialog
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiredeviceselectiondialog-settitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTitle(PWSTR pszTitle);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiredeviceselectiondialog-setsubmitbuttontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSubmitButtonText(PWSTR pszSubmitButtonText);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquiredeviceselectiondialog-domodal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoModal(HWND hWndParent, uint dwDeviceFlags, nint /* optional BSTR */ pbstrDeviceId, nint /* optional DEVICE_SELECTION_DEVICE_TYPE */ pnDeviceType);
}
