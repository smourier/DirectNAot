#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmheaderinfo
[GeneratedComInterface, Guid("96406bda-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMHeaderInfo
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-getattributecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeCount(ushort wStreamNum, out ushort pcAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-getattributebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeByIndex(ushort wIndex, ref ushort pwStreamNum, [MarshalUsing(CountElementName = nameof(pcchNameLen))] out PWSTR pwszName, ref ushort pcchNameLen, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref ushort pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-getattributebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttributeByName(ref ushort pwStreamNum, PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref ushort pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-setattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttribute(ushort wStreamNum, PWSTR pszName, WMT_ATTR_DATATYPE Type, nint /* byte array */ pValue, ushort cbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-getmarkercount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMarkerCount(out ushort pcMarkers);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-getmarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMarker(ushort wIndex, [MarshalUsing(CountElementName = nameof(pcchMarkerNameLen))] out PWSTR pwszMarkerName, ref ushort pcchMarkerNameLen, out ulong pcnsMarkerTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-addmarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMarker(PWSTR pwszMarkerName, ulong cnsMarkerTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-removemarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveMarker(ushort wIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-getscriptcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScriptCount(out ushort pcScripts);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-getscript
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScript(ushort wIndex, [MarshalUsing(CountElementName = nameof(pcchTypeLen))] out PWSTR pwszType, ref ushort pcchTypeLen, [MarshalUsing(CountElementName = nameof(pcchCommandLen))] out PWSTR pwszCommand, ref ushort pcchCommandLen, out ulong pcnsScriptTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-addscript
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddScript(PWSTR pwszType, PWSTR pwszCommand, ulong cnsScriptTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmheaderinfo-removescript
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveScript(ushort wIndex);
}
