﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapframedecode
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3b16811b-6a43-4ec9-a813-3d930c13b940")]
public partial interface IWICBitmapFrameDecode : IWICBitmapSource
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframedecode-getmetadataqueryreader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataQueryReader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataQueryReader>))] out IWICMetadataQueryReader ppIMetadataQueryReader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframedecode-getcolorcontexts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorContexts(uint cCount, [In][Out][MarshalUsing(CountElementName = nameof(cCount))] IWICColorContext[] ppIColorContexts, out uint pcActualCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframedecode-getthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnail([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] out IWICBitmapSource ppIThumbnail);
}
