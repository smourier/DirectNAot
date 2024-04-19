namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-iamstats
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("bc9bcf80-dcd2-11d2-abf6-00a0c905f375")]
public partial interface IAMStats : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-iamstats-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-iamstats-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-iamstats-getvaluebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueByIndex(int lIndex, out BSTR szName, out int lCount, out double dLast, out double dAverage, out double dStdDev, out double dMin, out double dMax);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-iamstats-getvaluebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueByName(BSTR szName, out int lIndex, out int lCount, out double dLast, out double dAverage, out double dStdDev, out double dMin, out double dMax);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-iamstats-getindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndex(BSTR szName, int lCreate, out int plIndex);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-iamstats-addvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddValue(int lIndex, double dValue);
}
