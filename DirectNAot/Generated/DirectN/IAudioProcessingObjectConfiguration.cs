namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nn-audioenginebaseapo-iaudioprocessingobjectconfiguration
[GeneratedComInterface, Guid("0e5ed805-aba6-49c3-8f9a-2b8c889c4fa8")]
public partial interface IAudioProcessingObjectConfiguration
{
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobjectconfiguration-lockforprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockForProcess(uint u32NumInputConnections, in APO_CONNECTION_DESCRIPTOR ppInputConnections, uint u32NumOutputConnections, in APO_CONNECTION_DESCRIPTOR ppOutputConnections);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobjectconfiguration-unlockforprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockForProcess();
}
