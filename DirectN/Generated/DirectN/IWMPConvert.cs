#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpservices/nn-wmpservices-iwmpconvert
[GeneratedComInterface, Guid("d683162f-57d4-4108-8373-4a9676d1c2e9")]
public partial interface IWMPConvert
{
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpconvert-convertfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertFile(BSTR bstrInputFile, BSTR bstrDestinationFolder, out BSTR pbstrOutputFile);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpconvert-geterrorurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetErrorURL(out BSTR pbstrURL);
}
