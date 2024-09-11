#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapdecoderinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("d8cd007f-d08f-4191-9bfc-236ea7f0e4b5")]
public partial interface IWICBitmapDecoderInfo : IWICBitmapCodecInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoderinfo-getpatterns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPatterns(uint cbSizePatterns, nint /* optional WICBitmapPattern* */ pPatterns, nint /* optional uint* */ pcPatterns, out uint pcbPatternsActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoderinfo-matchespattern
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MatchesPattern([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pIStream, out BOOL pfMatches);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoderinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapDecoder>))] out IWICBitmapDecoder ppIBitmapDecoder);
}
