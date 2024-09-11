#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmprofile
[GeneratedComInterface, Guid("96406bdb-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMProfile
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-getversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersion(out WMT_VERSION pdwVersion);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName([MarshalUsing(CountElementName = nameof(pcchName))] out PWSTR pwszName, ref uint pcchName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-setname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetName(PWSTR pwszName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription([MarshalUsing(CountElementName = nameof(pcchDescription))] out PWSTR pwszDescription, ref uint pcchDescription);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-setdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDescription(PWSTR pwszDescription);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pcStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream(uint dwStreamIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMStreamConfig>))] out IWMStreamConfig ppConfig);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-getstreambynumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamByNumber(ushort wStreamNum, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMStreamConfig>))] out IWMStreamConfig ppConfig);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-removestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMStreamConfig>))] IWMStreamConfig pConfig);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-removestreambynumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStreamByNumber(ushort wStreamNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-addstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMStreamConfig>))] IWMStreamConfig pConfig);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-reconfigstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReconfigStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMStreamConfig>))] IWMStreamConfig pConfig);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-createnewstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateNewStream(in Guid guidStreamType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMStreamConfig>))] out IWMStreamConfig ppConfig);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-getmutualexclusioncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMutualExclusionCount(out uint pcME);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-getmutualexclusion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMutualExclusion(uint dwMEIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMMutualExclusion>))] out IWMMutualExclusion ppME);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-removemutualexclusion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveMutualExclusion([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMMutualExclusion>))] IWMMutualExclusion pME);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-addmutualexclusion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMutualExclusion([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMMutualExclusion>))] IWMMutualExclusion pME);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmprofile-createnewmutualexclusion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateNewMutualExclusion([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMMutualExclusion>))] out IWMMutualExclusion ppME);
}
