#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfmediatype
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("44ae0fa8-ea31-4109-8d2e-4cae4997c555")]
public partial interface IMFMediaType : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediatype-getmajortype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMajorType(out Guid pguidMajorType);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediatype-iscompressedformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsCompressedFormat(out BOOL pfCompressed);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediatype-isequal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual(IMFMediaType pIMediaType, out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediatype-getrepresentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRepresentation(Guid guidRepresentation, out nint ppvRepresentation);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediatype-freerepresentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FreeRepresentation(Guid guidRepresentation, nint pvRepresentation);
}
