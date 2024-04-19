namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfclockstatesink
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f6696e82-74f7-4f3d-a178-8a5e09c3659f")]
public partial interface IMFClockStateSink
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclockstatesink-onclockstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnClockStart(long hnsSystemTime, long llClockStartOffset);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclockstatesink-onclockstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnClockStop(long hnsSystemTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclockstatesink-onclockpause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnClockPause(long hnsSystemTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclockstatesink-onclockrestart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnClockRestart(long hnsSystemTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclockstatesink-onclocksetrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnClockSetRate(long hnsSystemTime, float flRate);
}
