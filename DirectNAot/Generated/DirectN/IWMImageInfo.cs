#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmimageinfo
[GeneratedComInterface, Guid("9f0aa3b6-7267-4d89-88f2-ba915aa5c4c6")]
public partial interface IWMImageInfo
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmimageinfo-getimagecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImageCount(out uint pcImages);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmimageinfo-getimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImage(uint wIndex, ref ushort pcchMIMEType, [MarshalUsing(CountElementName = nameof(pcchMIMEType))] out PWSTR pwszMIMEType, ref ushort pcchDescription, [MarshalUsing(CountElementName = nameof(pcchDescription))] out PWSTR pwszDescription, out ushort pImageType, ref uint pcbImageData, nint /* byte array */ pbImageData);
}
