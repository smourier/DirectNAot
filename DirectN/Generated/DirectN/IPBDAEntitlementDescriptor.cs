#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-ipbdaentitlementdescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("22632497-0de3-4587-aadc-d8d99017e760")]
public partial interface IPBDAEntitlementDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbdaentitlementdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbdaentitlementdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbdaentitlementdescriptor-gettoken
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetToken(out nint /* byte array */ ppbTokenBuffer, out uint pdwTokenLength);
}
