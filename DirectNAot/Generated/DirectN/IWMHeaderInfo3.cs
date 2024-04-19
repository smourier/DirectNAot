namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmheaderinfo3
[GeneratedComInterface, Guid("15cc68e3-27cc-4ecd-b222-3f5d02d80bd5")]
public partial interface IWMHeaderInfo3 : IWMHeaderInfo2
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo3-getattributecountex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeCountEx(ushort wStreamNum, out ushort pcAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo3-getattributeindices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeIndices(ushort wStreamNum, PWSTR pwszName, in ushort pwLangIndex, out ushort pwIndices, ref ushort pwCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo3-getattributebyindexex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeByIndexEx(ushort wStreamNum, ushort wIndex, out PWSTR pwszName, ref ushort pwNameLen, out WMT_ATTR_DATATYPE pType, out ushort pwLangIndex, nint /* byte array */ pValue, ref uint pdwDataLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo3-modifyattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ModifyAttribute(ushort wStreamNum, ushort wIndex, WMT_ATTR_DATATYPE Type, ushort wLangIndex, nint /* byte array */ pValue, uint dwLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo3-addattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddAttribute(ushort wStreamNum, PWSTR pszName, out ushort pwIndex, WMT_ATTR_DATATYPE Type, ushort wLangIndex, nint /* byte array */ pValue, uint dwLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo3-deleteattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteAttribute(ushort wStreamNum, ushort wIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo3-addcodecinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddCodecInfo(PWSTR pwszName, PWSTR pwszDescription, WMT_CODEC_INFO_TYPE codecType, ushort cbCodecInfo, nint /* byte array */ pbCodecInfo);
}
