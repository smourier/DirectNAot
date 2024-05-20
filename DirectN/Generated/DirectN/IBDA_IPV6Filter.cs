#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_ipv6filter
[GeneratedComInterface, Guid("e1785a74-2a23-4fb3-9245-a8f88017ef33")]
public partial interface IBDA_IPV6Filter
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv6filter-getmulticastlistsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastListSize(ref uint pulcbAddresses);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv6filter-putmulticastlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutMulticastList(uint ulcbAddresses, nint /* byte array */ pAddressList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv6filter-getmulticastlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastList(ref uint pulcbAddresses, nint /* byte array */ pAddressList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv6filter-putmulticastmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutMulticastMode(uint ulModeMask);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv6filter-getmulticastmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastMode(out uint pulModeMask);
}
