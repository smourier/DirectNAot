#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfsample
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("c40a00f2-b93a-4d80-ae8c-5a1c634f58e4")]
public partial interface IMFSample : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-getsampleflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSampleFlags(out uint pdwSampleFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-setsampleflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSampleFlags(uint dwSampleFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-getsampletime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSampleTime(out long phnsSampleTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-setsampletime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSampleTime(long hnsSampleTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-getsampleduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSampleDuration(out long phnsSampleDuration);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-setsampleduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSampleDuration(long hnsSampleDuration);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-getbuffercount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferCount(out uint pdwBufferCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-getbufferbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferByIndex(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-converttocontiguousbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertToContiguousBuffer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] out IMFMediaBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-addbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddBuffer(IMFMediaBuffer pBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-removebufferbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveBufferByIndex(uint dwIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-removeallbuffers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllBuffers();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-gettotallength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTotalLength(out uint pcbTotalLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfsample-copytobuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyToBuffer(IMFMediaBuffer pBuffer);
}
