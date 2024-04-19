namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imf2dbuffer2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("33ae5ea6-4316-436f-8ddd-d73d22f829ec")]
public partial interface IMF2DBuffer2 : IMF2DBuffer
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imf2dbuffer2-lock2dsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock2DSize(MF2DBuffer_LockFlags lockFlags, out nint /* byte array */ ppbScanline0, out int plPitch, out nint /* byte array */ ppbBufferStart, out uint pcbBufferLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imf2dbuffer2-copy2dto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Copy2DTo(IMF2DBuffer2 pDestBuffer);
}
