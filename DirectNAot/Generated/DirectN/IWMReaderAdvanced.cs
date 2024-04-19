namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderadvanced
[GeneratedComInterface, Guid("96406bea-2b2b-11d3-b36b-00c04f6108ff")]
public partial interface IWMReaderAdvanced
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-setuserprovidedclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUserProvidedClock([MarshalAs(UnmanagedType.U4)] bool fUserClock);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getuserprovidedclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserProvidedClock([MarshalAs(UnmanagedType.U4)] out bool pfUserClock);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-delivertime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeliverTime(ulong cnsTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-setmanualstreamselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetManualStreamSelection([MarshalAs(UnmanagedType.U4)] bool fSelection);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getmanualstreamselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetManualStreamSelection([MarshalAs(UnmanagedType.U4)] out bool pfSelection);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-setstreamsselected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamsSelected(ushort cStreamCount, in ushort pwStreamNumbers, in WMT_STREAM_SELECTION pSelections);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getstreamselected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSelected(ushort wStreamNum, out WMT_STREAM_SELECTION pSelection);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-setreceiveselectioncallbacks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReceiveSelectionCallbacks([MarshalAs(UnmanagedType.U4)] bool fGetCallbacks);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getreceiveselectioncallbacks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReceiveSelectionCallbacks([MarshalAs(UnmanagedType.U4)] out bool pfGetCallbacks);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-setreceivestreamsamples
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReceiveStreamSamples(ushort wStreamNum, [MarshalAs(UnmanagedType.U4)] bool fReceiveStreamSamples);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getreceivestreamsamples
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReceiveStreamSamples(ushort wStreamNum, [MarshalAs(UnmanagedType.U4)] out bool pfReceiveStreamSamples);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-setallocateforoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllocateForOutput(uint dwOutputNum, [MarshalAs(UnmanagedType.U4)] bool fAllocate);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getallocateforoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocateForOutput(uint dwOutputNum, [MarshalAs(UnmanagedType.U4)] out bool pfAllocate);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-setallocateforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllocateForStream(ushort wStreamNum, [MarshalAs(UnmanagedType.U4)] bool fAllocate);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getallocateforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocateForStream(ushort dwSreamNum, [MarshalAs(UnmanagedType.U4)] out bool pfAllocate);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getstatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatistics(ref WM_READER_STATISTICS pStatistics);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-setclientinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClientInfo(in WM_READER_CLIENTINFO pClientInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getmaxoutputsamplesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxOutputSampleSize(uint dwOutput, out uint pcbMax);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-getmaxstreamsamplesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxStreamSampleSize(ushort wStream, out uint pcbMax);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced-notifylatedelivery
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyLateDelivery(ulong cnsLateness);
}
