namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpquery
[GeneratedComInterface, Guid("a00918f3-a6b0-4bfb-9189-fd834c7bc5a5")]
public partial interface IWMPQuery : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpquery-addcondition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT addCondition(BSTR bstrAttribute, BSTR bstrOperator, BSTR bstrValue);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpquery-beginnextgroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT beginNextGroup();
}
