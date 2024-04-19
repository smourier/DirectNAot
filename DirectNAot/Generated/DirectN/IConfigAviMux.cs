namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iconfigavimux
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("5acd6aa0-f482-11ce-8b67-00aa00a3f1a6")]
public partial interface IConfigAviMux
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iconfigavimux-setmasterstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMasterStream(int iStream);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iconfigavimux-getmasterstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMasterStream(out int pStream);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iconfigavimux-setoutputcompatibilityindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputCompatibilityIndex([MarshalAs(UnmanagedType.U4)] bool fOldIndex);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iconfigavimux-getoutputcompatibilityindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputCompatibilityIndex([MarshalAs(UnmanagedType.U4)] out bool pfOldIndex);
}
