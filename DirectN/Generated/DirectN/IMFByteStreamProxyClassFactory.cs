#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfbytestreamproxyclassfactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a6b43f84-5c0a-42e8-a44d-b1857a76992f")]
public partial interface IMFByteStreamProxyClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestreamproxyclassfactory-createbytestreamproxy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateByteStreamProxy(IMFByteStream pByteStream, IMFAttributes pAttributes, in Guid riid, out nint /* void */ ppvObject);
}
