#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsamistyle
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a7e025dd-5303-4a62-89d6-e747e1efac73")]
public partial interface IMFSAMIStyle
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsamistyle-getstylecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStyleCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsamistyle-getstyles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStyles(out PROPVARIANT pPropVarStyleArray);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsamistyle-setselectedstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSelectedStyle(PWSTR pwszStyle);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsamistyle-getselectedstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectedStyle(out PWSTR ppwszStyle);
}
