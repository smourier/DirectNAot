#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriterpostview
[GeneratedComInterface, Guid("81e20ce4-75ef-491a-8004-fc53c45bdc3e")]
public partial interface IWMWriterPostView
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostview-setpostviewcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPostViewCallback(IWMWriterPostViewCallback pCallback, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostview-setreceivepostviewsamples
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReceivePostViewSamples(ushort wStreamNum, [MarshalAs(UnmanagedType.U4)] bool fReceivePostViewSamples);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostview-getreceivepostviewsamples
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReceivePostViewSamples(ushort wStreamNum, [MarshalAs(UnmanagedType.U4)] out bool pfReceivePostViewSamples);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostview-getpostviewprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPostViewProps(ushort wStreamNumber, out IWMMediaProps ppOutput);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostview-setpostviewprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPostViewProps(ushort wStreamNumber, IWMMediaProps pOutput);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostview-getpostviewformatcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPostViewFormatCount(ushort wStreamNumber, out uint pcFormats);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostview-getpostviewformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPostViewFormat(ushort wStreamNumber, uint dwFormatNumber, out IWMMediaProps ppProps);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostview-setallocateforpostview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllocateForPostView(ushort wStreamNumber, [MarshalAs(UnmanagedType.U4)] bool fAllocate);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpostview-getallocateforpostview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocateForPostView(ushort wStreamNumber, [MarshalAs(UnmanagedType.U4)] out bool pfAllocate);
}
