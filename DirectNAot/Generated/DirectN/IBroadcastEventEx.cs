namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ibroadcasteventex
[GeneratedComInterface, Guid("3d9e3887-1929-423f-8021-43682de95448")]
public partial interface IBroadcastEventEx : IBroadcastEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ibroadcasteventex-fireex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FireEx(Guid EventID, uint Param1, uint Param2, uint Param3, uint Param4);
}
