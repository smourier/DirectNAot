#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpclosedcaption
[GeneratedComInterface, Guid("4f2df574-c588-11d3-9ed0-00c04fb6e937")]
public partial interface IWMPClosedCaption : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption-get_samistyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SAMIStyle(out BSTR pbstrSAMIStyle);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption-put_samistyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SAMIStyle(BSTR bstrSAMIStyle);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption-get_samilang
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SAMILang(out BSTR pbstrSAMILang);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption-put_samilang
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SAMILang(BSTR bstrSAMILang);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption-get_samifilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SAMIFileName(out BSTR pbstrSAMIFileName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption-put_samifilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SAMIFileName(BSTR bstrSAMIFileName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption-get_captioningid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_captioningId(out BSTR pbstrCaptioningID);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpclosedcaption-put_captioningid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_captioningId(BSTR bstrCaptioningID);
}
