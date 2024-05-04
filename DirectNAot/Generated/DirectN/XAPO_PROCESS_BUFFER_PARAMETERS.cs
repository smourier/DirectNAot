#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapo/ns-xapo-xapo_process_buffer_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct XAPO_PROCESS_BUFFER_PARAMETERS
{
    public nint pBuffer;
    public XAPO_BUFFER_FLAGS BufferFlags;
    public uint ValidFrameCount;
}
