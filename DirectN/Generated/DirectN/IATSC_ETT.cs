#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/atscpsipparser/nn-atscpsipparser-iatsc_ett
[GeneratedComInterface, Guid("5a142cc9-b8cf-4a86-a040-e9cadf3ef3e7")]
public partial interface IATSC_ETT
{
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_ett-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList?>))] ISectionList? pSectionList, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMpeg2Data?>))] IMpeg2Data? pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_ett-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_ett-getprotocolversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtocolVersion(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_ett-getetmid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEtmId(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iatsc_ett-getextendedmessagetext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtendedMessageText(out uint pdwLength, out nint /* byte array */ ppText);
}
