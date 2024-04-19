namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfvideomediatype
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b99f381f-a8f9-47a2-a5af-ca3a225a3890")]
public partial interface IMFVideoMediaType : IMFMediaType
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfvideomediatype-getvideoformat
    [PreserveSig]
    MFVIDEOFORMAT GetVideoFormat();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfvideomediatype-getvideorepresentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoRepresentation(Guid guidRepresentation, out nint ppvRepresentation, int lStride);
}
