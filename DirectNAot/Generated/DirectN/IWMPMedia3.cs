namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpmedia3
[GeneratedComInterface, Guid("f118efc7-f03a-4fb4-99c9-1c02a5c1065b")]
public partial interface IWMPMedia3 : IWMPMedia2
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia3-getattributecountbytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAttributeCountByType(BSTR bstrType, BSTR bstrLanguage, ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia3-getiteminfobytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getItemInfoByType(BSTR bstrType, BSTR bstrLanguage, int lIndex, ref VARIANT pvarValue);
}
