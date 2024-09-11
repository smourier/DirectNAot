#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmp2dlna/nn-mfmp2dlna-imfdlnasinkinit
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("0c012799-1b61-4c10-bda9-04445be5f561")]
public partial interface IMFDLNASinkInit
{
    // https://learn.microsoft.com/windows/win32/api/mfmp2dlna/nf-mfmp2dlna-imfdlnasinkinit-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFByteStream>))] IMFByteStream pByteStream, BOOL fPal);
}
