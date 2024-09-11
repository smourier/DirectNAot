#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfbytestream
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("ad4c1b00-4bf7-422f-9175-756693d9130d")]
public partial interface IMFByteStream
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(out uint pdwCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(out ulong pqwLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-setlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLength(ulong qwLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-getcurrentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPosition(out ulong pqwPosition);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-setcurrentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentPosition(ulong qwPosition);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-isendofstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEndOfStream(out BOOL pfEndOfStream);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-read
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(nint /* byte array */ pb, uint cb, out uint pcbRead);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-beginread
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginRead(nint /* byte array */ pb, uint cb, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-endread
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndRead([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, out uint pcbRead);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-write
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(nint /* byte array */ pb, uint cb, out uint pcbWritten);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-beginwrite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginWrite(nint /* byte array */ pb, uint cb, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncCallback>))] IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-endwrite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndWrite([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAsyncResult>))] IMFAsyncResult pResult, out uint pcbWritten);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-seek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(MFBYTESTREAM_SEEK_ORIGIN SeekOrigin, long llSeekOffset, uint dwSeekFlags, out ulong pqwCurrentPosition);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfbytestream-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
