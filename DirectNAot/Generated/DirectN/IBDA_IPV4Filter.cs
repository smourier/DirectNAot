namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_ipv4filter
[GeneratedComInterface, Guid("71985f44-1ca1-11d3-9cc8-00c04f7971e0")]
public partial interface IBDA_IPV4Filter
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv4filter-getmulticastlistsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastListSize(ref uint pulcbAddresses);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv4filter-putmulticastlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutMulticastList(uint ulcbAddresses, nint /* byte array */ pAddressList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv4filter-getmulticastlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastList(ref uint pulcbAddresses, nint /* byte array */ pAddressList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv4filter-putmulticastmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutMulticastMode(uint ulModeMask);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipv4filter-getmulticastmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastMode(out uint pulModeMask);
}
