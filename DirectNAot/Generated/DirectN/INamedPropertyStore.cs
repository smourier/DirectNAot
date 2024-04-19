namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-inamedpropertystore
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("71604b0f-97b0-4764-8577-2f13e98a1422")]
public partial interface INamedPropertyStore
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-inamedpropertystore-getnamedvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNamedValue(PWSTR pszName, out PROPVARIANT ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-inamedpropertystore-setnamedvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNamedValue(PWSTR pszName, in PROPVARIANT propvar);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-inamedpropertystore-getnamecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNameCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-inamedpropertystore-getnameat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNameAt(uint iProp, out BSTR pbstrName);
}
