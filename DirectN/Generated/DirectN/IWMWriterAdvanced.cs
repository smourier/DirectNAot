#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriteradvanced
[GeneratedComInterface, Guid("96406be3-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMWriterAdvanced
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-getsinkcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSinkCount(out uint pcSinks);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-getsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSink(uint dwSinkNum, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMWriterSink>))] out IWMWriterSink ppSink);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-addsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSink(IWMWriterSink pSink);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-removesink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveSink(IWMWriterSink pSink);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-writestreamsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteStreamSample(ushort wStreamNum, ulong cnsSampleTime, uint msSampleSendTime, ulong cnsSampleDuration, uint dwFlags, INSSBuffer pSample);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-setlivesource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLiveSource([MarshalAs(UnmanagedType.U4)] bool fIsLiveSource);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-isrealtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRealTime([MarshalAs(UnmanagedType.U4)] out bool pfRealTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-getwritertime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWriterTime(out ulong pcnsCurrentTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-getstatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatistics(ushort wStreamNum, out WM_WRITER_STATISTICS pStats);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-setsynctolerance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSyncTolerance(uint msWindow);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriteradvanced-getsynctolerance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSyncTolerance(out uint pmsWindow);
}
