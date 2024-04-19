namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmstreamlist
[GeneratedComInterface, Guid("96406bdd-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMStreamList
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamlist-getstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreams(out ushort pwStreamNumArray, ref ushort pcStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamlist-addstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStream(ushort wStreamNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamlist-removestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStream(ushort wStreamNum);
}
