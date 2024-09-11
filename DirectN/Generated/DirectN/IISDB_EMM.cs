#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdb_emm
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("0edb556d-43ad-4938-9668-321b2ffecfd3")]
public partial interface IISDB_EMM
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_emm-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList>))] ISectionList pSectionList, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMpeg2Data>))] IMpeg2Data pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_emm-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_emm-gettableidextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableIdExtension(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_emm-getdatabytes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataBytes(ref ushort pwBufferLength, nint /* byte array */ pbBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_emm-getsharedemmmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSharedEmmMessage(ref ushort pwLength, out nint /* byte array */ ppbMessage);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_emm-getindividualemmmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndividualEmmMessage(nint pUnknown, ref ushort pwLength, out nint /* byte array */ ppbMessage);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdb_emm-getversionhash
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionHash(out uint pdwVersionHash);
}
