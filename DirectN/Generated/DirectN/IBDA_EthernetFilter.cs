#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_ethernetfilter
[GeneratedComInterface, Guid("71985f43-1ca1-11d3-9cc8-00c04f7971e0")]
public partial interface IBDA_EthernetFilter
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ethernetfilter-getmulticastlistsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastListSize(ref uint pulcbAddresses);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ethernetfilter-putmulticastlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutMulticastList(uint ulcbAddresses, nint /* byte array */ pAddressList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ethernetfilter-getmulticastlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastList(ref uint pulcbAddresses, nint /* byte array */ pAddressList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ethernetfilter-putmulticastmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutMulticastMode(uint ulModeMask);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ethernetfilter-getmulticastmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastMode(out uint pulModeMask);
}
