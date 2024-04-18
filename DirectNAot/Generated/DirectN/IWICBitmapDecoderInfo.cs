namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapdecoderinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("d8cd007f-d08f-4191-9bfc-236ea7f0e4b5")]
public partial interface IWICBitmapDecoderInfo : IWICBitmapCodecInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoderinfo-getpatterns
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPatterns(uint cbSizePatterns, nint/* nint */ pPatterns, nint/* nint */ pcPatterns, out uint pcbPatternsActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoderinfo-matchespattern
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MatchesPattern(IStream pIStream, [MarshalAs(UnmanagedType.U4)] out bool pfMatches);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoderinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateInstance(out IWICBitmapDecoder ppIBitmapDecoder);
}
