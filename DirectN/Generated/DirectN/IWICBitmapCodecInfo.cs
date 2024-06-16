#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapcodecinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e87a44c4-b76e-4c47-8b09-298eb12a2714")]
public partial interface IWICBitmapCodecInfo : IWICComponentInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-getcontainerformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainerFormat(out Guid pguidContainerFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-getpixelformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelFormats(uint cFormats, [In][Out][MarshalUsing(CountElementName = nameof(cFormats))] Guid[] pguidPixelFormats, out uint pcActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-getcolormanagementversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorManagementVersion(uint cchColorManagementVersion, [MarshalUsing(CountElementName = nameof(cchColorManagementVersion))] PWSTR wzColorManagementVersion, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-getdevicemanufacturer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [MarshalUsing(CountElementName = nameof(cchDeviceManufacturer))] PWSTR wzDeviceManufacturer, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-getdevicemodels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceModels(uint cchDeviceModels, [MarshalUsing(CountElementName = nameof(cchDeviceModels))] PWSTR wzDeviceModels, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-getmimetypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMimeTypes(uint cchMimeTypes, [MarshalUsing(CountElementName = nameof(cchMimeTypes))] PWSTR wzMimeTypes, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-getfileextensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileExtensions(uint cchFileExtensions, [MarshalUsing(CountElementName = nameof(cchFileExtensions))] PWSTR wzFileExtensions, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-doessupportanimation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportAnimation(out BOOL pfSupportAnimation);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-doessupportchromakey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportChromakey(out BOOL pfSupportChromakey);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-doessupportlossless
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportLossless(out BOOL pfSupportLossless);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-doessupportmultiframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportMultiframe(out BOOL pfSupportMultiframe);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecinfo-matchesmimetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MatchesMimeType(PWSTR wzMimeType, out BOOL pfMatches);
}
