#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsbuffer/nn-wmsbuffer-inssbuffer
[GeneratedComInterface, Guid("e1cd3524-03d7-11d2-9eed-006097d2d7cf")]
public partial interface INSSBuffer
{
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-inssbuffer-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(out uint pdwLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-inssbuffer-setlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLength(uint dwLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-inssbuffer-getmaxlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxLength(out uint pdwLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-inssbuffer-getbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(out nint /* byte array */ ppdwBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-inssbuffer-getbufferandlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferAndLength(out nint /* byte array */ ppdwBuffer, out uint pdwLength);
}
