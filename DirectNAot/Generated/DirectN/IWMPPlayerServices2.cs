namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplayerservices2
[GeneratedComInterface, Guid("1bb1592f-f040-418a-9f71-17c7512b4d70")]
public partial interface IWMPPlayerServices2 : IWMPPlayerServices
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayerservices2-setbackgroundprocessingpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setBackgroundProcessingPriority(BSTR bstrPriority);
}
