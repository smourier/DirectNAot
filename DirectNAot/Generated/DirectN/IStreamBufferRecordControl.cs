#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambufferrecordcontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ba9b6c99-f3c7-4ff2-92db-cfdd4851bf31")]
public partial interface IStreamBufferRecordControl
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferrecordcontrol-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(ref long prtStart);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferrecordcontrol-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop(long rtStop);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferrecordcontrol-getrecordingstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordingStatus(out HRESULT phResult, [MarshalAs(UnmanagedType.U4)] out bool pbStarted, [MarshalAs(UnmanagedType.U4)] out bool pbStopped);
}
