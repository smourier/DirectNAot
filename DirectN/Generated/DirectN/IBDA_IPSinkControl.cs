#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_ipsinkcontrol
[GeneratedComInterface, Guid("3f4dc8e2-4050-11d3-8f4b-00c04f7971e2")]
public partial interface IBDA_IPSinkControl
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipsinkcontrol-getmulticastlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMulticastList(ref uint pulcbSize, out nint /* byte array */ pbBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_ipsinkcontrol-getadapteripaddress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdapterIPAddress(ref uint pulcbSize, out nint /* byte array */ pbBuffer);
}
