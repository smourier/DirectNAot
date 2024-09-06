#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdbcaservicedescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("39cbeb97-ff0b-42a7-9ab9-7b9cfe70a77a")]
public partial interface IIsdbCAServiceDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbcaservicedescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbcaservicedescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbcaservicedescriptor-getcasystemid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCASystemId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbcaservicedescriptor-getcabroadcastergroupid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCABroadcasterGroupId(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbcaservicedescriptor-getmessagecontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMessageControl(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbcaservicedescriptor-getserviceids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceIds(nint /* byte array */ pbNumServiceIds, out ushort pwServiceIds);
}
