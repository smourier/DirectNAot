#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_transportstreaminfo
[GeneratedComInterface, Guid("8e882535-5f86-47ab-86cf-c281a72a0549")]
public partial interface IBDA_TransportStreamInfo
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_transportstreaminfo-get_pattabletickcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PatTableTickCount(out uint pPatTickCount);
}
