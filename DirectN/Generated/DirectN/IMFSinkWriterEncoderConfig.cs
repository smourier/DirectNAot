#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfsinkwriterencoderconfig
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("17c3779e-3cde-4ede-8c60-3899f5f53ad6")]
public partial interface IMFSinkWriterEncoderConfig
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriterencoderconfig-settargetmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTargetMediaType(uint dwStreamIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] IMFMediaType pTargetMediaType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes?>))] IMFAttributes? pEncodingParameters);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsinkwriterencoderconfig-placeencodingparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlaceEncodingParameters(uint dwStreamIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] IMFAttributes pEncodingParameters);
}
