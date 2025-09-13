#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpmetadatapicture
[GeneratedComInterface, Guid("5c29bbe0-f87d-4c45-aa28-a70f0230ffa9")]
public partial interface IWMPMetadataPicture : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmetadatapicture-get_mimetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_mimeType(out BSTR pbstrMimeType);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmetadatapicture-get_picturetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_pictureType(out BSTR pbstrPictureType);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmetadatapicture-get_description
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_description(out BSTR pbstrDescription);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmetadatapicture-get_url
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_URL(out BSTR pbstrURL);
}
