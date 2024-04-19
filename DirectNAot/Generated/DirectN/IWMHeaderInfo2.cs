namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmheaderinfo2
[GeneratedComInterface, Guid("15cf9781-454e-482e-b393-85fae487a810")]
public partial interface IWMHeaderInfo2 : IWMHeaderInfo
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo2-getcodecinfocount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecInfoCount(out uint pcCodecInfos);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo2-getcodecinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCodecInfo(uint wIndex, ref ushort pcchName, out PWSTR pwszName, ref ushort pcchDescription, out PWSTR pwszDescription, out WMT_CODEC_INFO_TYPE pCodecType, ref ushort pcbCodecInfo, nint /* byte array */ pbCodecInfo);
}
