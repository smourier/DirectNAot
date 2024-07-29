#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfsourcebuffer
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("e2cd3a4b-af25-4d3d-9110-da0e6f8ee877")]
public partial interface IMFSourceBuffer
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-getupdating
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL GetUpdating();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-getbuffered
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffered([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaTimeRange>))] out IMFMediaTimeRange ppBuffered);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-gettimestampoffset
    [PreserveSig]
    double GetTimeStampOffset();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-settimestampoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimeStampOffset(double offset);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-getappendwindowstart
    [PreserveSig]
    double GetAppendWindowStart();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-setappendwindowstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppendWindowStart(double time);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-getappendwindowend
    [PreserveSig]
    double GetAppendWindowEnd();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-setappendwindowend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppendWindowEnd(double time);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Append(nint /* byte array */ pData, uint len);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-appendbytestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendByteStream(IMFByteStream pStream, nint /* optional ulong* */ pMaxLen);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-abort
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Abort();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffer-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(double start, double end);
}
