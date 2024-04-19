namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nn-audioengineextensionapo-iaudioprocessingobjectrtqueueservice
[GeneratedComInterface, Guid("acd65e2f-955b-4b57-b9bf-ac297bb752c9")]
public partial interface IAudioProcessingObjectRTQueueService
{
    // https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nf-audioengineextensionapo-iaudioprocessingobjectrtqueueservice-getrealtimeworkqueue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRealTimeWorkQueue(out uint workQueueId);
}
