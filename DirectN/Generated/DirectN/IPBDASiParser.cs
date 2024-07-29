#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-ipbdasiparser
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("9de49a74-aba2-4a18-93e1-21f17f95c3c3")]
public partial interface IPBDASiParser
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbdasiparser-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbdasiparser-geteit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEIT(uint dwSize, nint /* byte array */ pBuffer, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPBDA_EIT>))] out IPBDA_EIT ppEIT);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbdasiparser-getservices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServices(uint dwSize, nint /* byte array */ pBuffer, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPBDA_Services>))] out IPBDA_Services ppServices);
}
