namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsbuffer/nn-wmsbuffer-inssbuffer2
[GeneratedComInterface, Guid("4f528693-1035-43fe-b428-757561ad3a68")]
public partial interface INSSBuffer2 : INSSBuffer
{
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nn-wmsbuffer-inssbuffer2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSampleProperties(uint cbProperties, nint /* byte array */ pbProperties);
    
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nn-wmsbuffer-inssbuffer2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSampleProperties(uint cbProperties, nint /* byte array */ pbProperties);
}
