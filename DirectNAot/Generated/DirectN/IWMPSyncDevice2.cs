namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpsyncdevice2
[GeneratedComInterface, Guid("88afb4b2-140a-44d2-91e6-4543da467cd1")]
public partial interface IWMPSyncDevice2 : IWMPSyncDevice
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpsyncdevice2-setiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setItemInfo(BSTR bstrItemName, BSTR bstrVal);
}
