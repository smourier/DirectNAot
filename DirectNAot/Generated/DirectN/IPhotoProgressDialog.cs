namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoprogressdialog
[GeneratedComInterface, Guid("00f246f9-0750-4f08-9381-2cd8e906a4ae")]
public partial interface IPhotoProgressDialog
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(HWND hwndParent);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-getwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindow(out HWND phwndProgressDialog);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-destroy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Destroy();
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-settitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTitle(PWSTR pszTitle);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-showcheckbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowCheckbox(PROGRESS_DIALOG_CHECKBOX_ID nCheckboxId, [MarshalAs(UnmanagedType.U4)] bool fShow);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-setcheckboxtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCheckboxText(PROGRESS_DIALOG_CHECKBOX_ID nCheckboxId, PWSTR pszCheckboxText);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCheckboxCheck(PROGRESS_DIALOG_CHECKBOX_ID nCheckboxId, [MarshalAs(UnmanagedType.U4)] bool fChecked);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-setcheckboxtooltip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCheckboxTooltip(PROGRESS_DIALOG_CHECKBOX_ID nCheckboxId, PWSTR pszCheckboxTooltipText);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-ischeckboxchecked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsCheckboxChecked(PROGRESS_DIALOG_CHECKBOX_ID nCheckboxId, [MarshalAs(UnmanagedType.U4)] out bool pfChecked);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-setcaption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCaption(PWSTR pszTitle);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-setimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetImage(PROGRESS_DIALOG_IMAGE_TYPE nImageType, HICON hIcon, HBITMAP hBitmap);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-setpercentcomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPercentComplete(int nPercent);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-setprogresstext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgressText(PWSTR pszProgressText);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActionLinkCallback(IPhotoProgressActionCB pPhotoProgressActionCB);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActionLinkText(PWSTR pszCaption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowActionLink([MarshalAs(UnmanagedType.U4)] bool fShow);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-iscancelled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsCancelled([MarshalAs(UnmanagedType.U4)] out bool pfCancelled);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoprogressdialog-getuserinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserInput(in Guid riidType, nint pUnknown, out PROPVARIANT pPropVarResult, nint/* nint */ pPropVarDefault);
}
