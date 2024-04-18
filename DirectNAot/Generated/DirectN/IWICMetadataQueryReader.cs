namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicmetadataqueryreader
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("30989668-e1c9-4597-b395-458eedb808df")]
public partial interface IWICMetadataQueryReader
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicmetadataqueryreader-getcontainerformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetContainerFormat(out Guid pguidContainerFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicmetadataqueryreader-getlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLocation(uint cchMaxLength, ref PWSTR wzNamespace, out uint pcchActualLength);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicmetadataqueryreader-getmetadatabyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMetadataByName(PWSTR wzName, ref PROPVARIANT pvarValue);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicmetadataqueryreader-getenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetEnumerator(out IEnumString ppIEnumString);
}
