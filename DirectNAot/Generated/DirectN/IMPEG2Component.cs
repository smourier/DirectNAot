namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-impeg2component
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1493e353-1eb6-473c-802d-8e6b8ec9d2a9")]
public partial interface IMPEG2Component : IComponent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2component-get_pid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PID(out int PID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2component-put_pid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PID(int PID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2component-get_pcrpid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PCRPID(out int PCRPID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2component-put_pcrpid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PCRPID(int PCRPID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2component-get_programnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ProgramNumber(out int ProgramNumber);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-impeg2component-put_programnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ProgramNumber(int ProgramNumber);
}
