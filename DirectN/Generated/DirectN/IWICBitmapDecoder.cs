﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapdecoder
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9edde9e7-8dee-47ea-99df-e6faf2ed44bf")]
public partial interface IWICBitmapDecoder
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-querycapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryCapability([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pIStream, out uint pdwCapability);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pIStream, WICDecodeOptions cacheOptions);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getcontainerformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainerFormat(out Guid pguidContainerFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getdecoderinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecoderInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapDecoderInfo>))] out IWICBitmapDecoderInfo ppIDecoderInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-copypalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyPalette([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICPalette>))] IWICPalette pIPalette);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getmetadataqueryreader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataQueryReader([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICMetadataQueryReader>))] out IWICMetadataQueryReader ppIMetadataQueryReader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getpreview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreview([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] out IWICBitmapSource ppIBitmapSource);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getcolorcontexts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorContexts(uint cCount, [In][Out][MarshalUsing(CountElementName = nameof(cCount))] IWICColorContext[] ppIColorContexts, out uint pcActualCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetThumbnail([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] out IWICBitmapSource ppIThumbnail);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getframecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapdecoder-getframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrame(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapFrameDecode>))] out IWICBitmapFrameDecode ppIBitmapFrame);
}
