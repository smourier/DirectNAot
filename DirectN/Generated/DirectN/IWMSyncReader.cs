#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmsyncreader
[GeneratedComInterface, Guid("9397f121-7705-4dc9-b049-98b698188414")]
public partial interface IWMSyncReader
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(PWSTR pwszFilename);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-setrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRange(ulong cnsStartTime, long cnsDuration);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-setrangebyframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRangeByFrame(ushort wStreamNum, ulong qwFrameNumber, long cFramesToRead);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getnextsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextSample(ushort wStreamNum, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppSample, out ulong pcnsSampleTime, out ulong pcnsDuration, out uint pdwFlags, out uint pdwOutputNum, out ushort pwStreamNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-setstreamsselected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamsSelected(ushort cStreamCount, in ushort pwStreamNumbers, in WMT_STREAM_SELECTION pSelections);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getstreamselected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSelected(ushort wStreamNum, out WMT_STREAM_SELECTION pSelection);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-setreadstreamsamples
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReadStreamSamples(ushort wStreamNum, [MarshalAs(UnmanagedType.U4)] bool fCompressed);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getreadstreamsamples
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReadStreamSamples(ushort wStreamNum, [MarshalAs(UnmanagedType.U4)] out bool pfCompressed);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getoutputsetting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputSetting(uint dwOutputNum, PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref ushort pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-setoutputsetting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputSetting(uint dwOutputNum, PWSTR pszName, WMT_ATTR_DATATYPE Type, nint /* byte array */ pValue, ushort cbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getoutputcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputCount(out uint pcOutputs);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getoutputprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputProps(uint dwOutputNum, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMOutputMediaProps>))] out IWMOutputMediaProps ppOutput);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-setoutputprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputProps(uint dwOutputNum, IWMOutputMediaProps pOutput);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getoutputformatcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputFormatCount(uint dwOutputNum, out uint pcFormats);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getoutputformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputFormat(uint dwOutputNum, uint dwFormatNum, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMOutputMediaProps>))] out IWMOutputMediaProps ppProps);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getoutputnumberforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputNumberForStream(ushort wStreamNum, out uint pdwOutputNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getstreamnumberforoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamNumberForOutput(uint dwOutputNum, out ushort pwStreamNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getmaxoutputsamplesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxOutputSampleSize(uint dwOutput, out uint pcbMax);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-getmaxstreamsamplesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxStreamSampleSize(ushort wStream, out uint pcbMax);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader-openstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenStream(IStream pStream);
}
