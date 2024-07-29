#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicmetadataquerywriter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a721791a-0def-4d06-bd91-2118bf1db10b")]
public partial interface IWICMetadataQueryWriter : IWICMetadataQueryReader
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicmetadataquerywriter-setmetadatabyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMetadataByName(PWSTR wzName, in PROPVARIANT pvarValue);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicmetadataquerywriter-removemetadatabyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveMetadataByName(PWSTR wzName);
}
