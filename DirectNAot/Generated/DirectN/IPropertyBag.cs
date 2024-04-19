namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-ipropertybag
[GeneratedComInterface, Guid("55272a00-42cb-11ce-8135-00aa004bb851")]
public partial interface IPropertyBag
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ipropertybag-read
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(PWSTR pszPropName, ref VARIANT pVar, IErrorLog pErrorLog);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-ipropertybag-write
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(PWSTR pszPropName, in VARIANT pVar);
}
