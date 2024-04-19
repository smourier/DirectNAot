﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwiccomponentfactory
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("412d0c3a-9650-44fa-af5b-dd2a06c8e8fb")]
public partial interface IWICComponentFactory : IWICImagingFactory
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwiccomponentfactory-createmetadatareader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMetadataReader(in Guid guidMetadataFormat, in Guid pguidVendor, uint dwOptions, IStream pIStream, out IWICMetadataReader ppIReader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwiccomponentfactory-createmetadatareaderfromcontainer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMetadataReaderFromContainer(in Guid guidContainerFormat, in Guid pguidVendor, uint dwOptions, IStream pIStream, out IWICMetadataReader ppIReader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwiccomponentfactory-createmetadatawriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMetadataWriter(in Guid guidMetadataFormat, in Guid pguidVendor, uint dwMetadataOptions, out IWICMetadataWriter ppIWriter);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwiccomponentfactory-createmetadatawriterfromreader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMetadataWriterFromReader(IWICMetadataReader pIReader, in Guid pguidVendor, out IWICMetadataWriter ppIWriter);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwiccomponentfactory-createqueryreaderfromblockreader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQueryReaderFromBlockReader(IWICMetadataBlockReader pIBlockReader, out IWICMetadataQueryReader ppIQueryReader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwiccomponentfactory-createquerywriterfromblockwriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateQueryWriterFromBlockWriter(IWICMetadataBlockWriter pIBlockWriter, out IWICMetadataQueryWriter ppIQueryWriter);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwiccomponentfactory-createencoderpropertybag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEncoderPropertyBag(in PROPBAG2 ppropOptions, uint cCount, out IPropertyBag2 ppIPropertyBag);
}
