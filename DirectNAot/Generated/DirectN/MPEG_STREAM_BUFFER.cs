namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_stream_buffer
[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG_STREAM_BUFFER
{
    public HRESULT hr;
    public uint dwDataBufferSize;
    public uint dwSizeOfDataRead;
    public nint pDataBuffer;
}
