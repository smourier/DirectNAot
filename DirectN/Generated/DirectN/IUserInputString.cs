#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iuserinputstring
[GeneratedComInterface, Guid("00f243a1-205b-45ba-ae26-abbc53aa7a6f")]
public partial interface IUserInputString
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-getsubmitbuttontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubmitButtonText(out BSTR pbstrSubmitButtonText);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-getprompt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrompt(out BSTR pbstrPromptTitle);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-getstringid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringId(out BSTR pbstrStringId);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-getstringtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringType(out USER_INPUT_STRING_TYPE pnStringType);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-gettooltiptext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTooltipText(out BSTR pbstrTooltipText);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-getmaxlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxLength(out uint pcchMaxLength);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-getdefault
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefault(out BSTR pbstrDefault);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-getmrucount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMruCount(out uint pnMruCount);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-getmruentryat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMruEntryAt(uint nIndex, out BSTR pbstrMruEntry);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iuserinputstring-getimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImage(uint nSize, nint /* optional HBITMAP* */ phBitmap, nint /* optional HICON* */ phIcon);
}
