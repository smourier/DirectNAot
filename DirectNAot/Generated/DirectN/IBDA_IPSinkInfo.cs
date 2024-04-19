namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_ipsinkinfo
[GeneratedComInterface, Guid("a750108f-492e-4d51-95f7-649b23ff7ad7")]
public partial interface IBDA_IPSinkInfo
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipsinkinfo-get_multicastlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MulticastList(ref uint pulcbAddresses, out nint /* byte array */ ppbAddressList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipsinkinfo-get_adapteripaddress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AdapterIPAddress(out BSTR pbstrBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipsinkinfo-get_adapterdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AdapterDescription(out BSTR pbstrBuffer);
}
