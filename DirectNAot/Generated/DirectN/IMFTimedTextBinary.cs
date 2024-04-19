namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imftimedtextbinary
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("4ae3a412-0545-43c4-bf6f-6b97a5c6c432")]
public partial interface IMFTimedTextBinary
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextbinary-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(out nint /* byte array */ data, out uint length);
}
