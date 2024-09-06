#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidwebdvd2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("7027212f-ee9a-4a7c-8b67-f023714cdaff")]
public partial interface IMSVidWebDVD2 : IMSVidWebDVD
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidwebdvd2-get_bookmark
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Bookmark(out nint /* byte array */ ppData, out uint pDataLength);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidwebdvd2-put_bookmark
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Bookmark(nint /* byte array */ pData, uint dwDataLength);
}
