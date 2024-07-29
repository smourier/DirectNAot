#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicformatconverterinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9f34fb65-13f4-4f15-bc57-3726b5e53d9f")]
public partial interface IWICFormatConverterInfo : IWICComponentInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicformatconverterinfo-getpixelformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelFormats(uint cFormats, [In][Out][MarshalUsing(CountElementName = nameof(cFormats))] Guid[] pPixelFormatGUIDs, out uint pcActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicformatconverterinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICFormatConverter>))] out IWICFormatConverter ppIConverter);
}
