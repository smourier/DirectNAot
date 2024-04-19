namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imfvideopositionmapper
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1f6a9f17-e70b-4e24-8ae4-0b2c3ba7a4ae")]
public partial interface IMFVideoPositionMapper
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideopositionmapper-mapoutputcoordinatetoinputstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapOutputCoordinateToInputStream(float xOut, float yOut, uint dwOutputStreamIndex, uint dwInputStreamIndex, out float pxIn, out float pyIn);
}
