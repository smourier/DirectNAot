#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/nn-wincodecsdk-iwicmetadatahandlerinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("aba958bf-c672-44d1-8d61-ce6df2e682c2")]
public partial interface IWICMetadataHandlerInfo : IWICComponentInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatahandlerinfo-getmetadataformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadataFormat(out Guid pguidMetadataFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatahandlerinfo-getcontainerformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainerFormats(uint cContainerFormats, [In][Out][MarshalUsing(CountElementName = nameof(cContainerFormats))] Guid[] pguidContainerFormats, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatahandlerinfo-getdevicemanufacturer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [MarshalUsing(CountElementName = nameof(cchDeviceManufacturer))] ref PWSTR wzDeviceManufacturer, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatahandlerinfo-getdevicemodels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceModels(uint cchDeviceModels, [MarshalUsing(CountElementName = nameof(cchDeviceModels))] ref PWSTR wzDeviceModels, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatahandlerinfo-doesrequirefullstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesRequireFullStream([MarshalAs(UnmanagedType.U4)] out bool pfRequiresFullStream);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatahandlerinfo-doessupportpadding
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportPadding([MarshalAs(UnmanagedType.U4)] out bool pfSupportsPadding);
    
    // https://learn.microsoft.com/windows/win32/api/wincodecsdk/nf-wincodecsdk-iwicmetadatahandlerinfo-doesrequirefixedsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesRequireFixedSize([MarshalAs(UnmanagedType.U4)] out bool pfFixedSize);
}
