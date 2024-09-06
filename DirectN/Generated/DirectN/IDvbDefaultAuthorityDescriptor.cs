#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvbdefaultauthoritydescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("05ec24d1-3a31-44e7-b408-67c60a352276")]
public partial interface IDvbDefaultAuthorityDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbdefaultauthoritydescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbdefaultauthoritydescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbdefaultauthoritydescriptor-getdefaultauthority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultAuthority(nint /* byte array */ pbLength, out nint /* byte array */ ppbBytes);
}
