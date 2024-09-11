#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreadercallbackadvanced
[GeneratedComInterface, Guid("96406beb-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMReaderCallbackAdvanced
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadercallbackadvanced-onstreamsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStreamSample(ushort wStreamNum, ulong cnsSampleTime, ulong cnsSampleDuration, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] INSSBuffer pSample, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadercallbackadvanced-ontime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTime(ulong cnsCurrentTime, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadercallbackadvanced-onstreamselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStreamSelection(ushort wStreamCount, in ushort pStreamNumbers, in WMT_STREAM_SELECTION pSelections, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadercallbackadvanced-onoutputpropschanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnOutputPropsChanged(uint dwOutputNum, in WM_MEDIA_TYPE pMediaType, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadercallbackadvanced-allocateforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateForStream(ushort wStreamNum, uint cbBuffer, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppBuffer, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreadercallbackadvanced-allocateforoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateForOutput(uint dwOutputNum, uint cbBuffer, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppBuffer, nint pvContext);
}
