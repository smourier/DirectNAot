#nullable enable
namespace DirectN;

public partial struct DXVA2Trace_DecodeDevGetBufferData
{
    public EVENT_TRACE_HEADER wmiHeader;
    public ulong pObject;
    public uint BufferType;
    public BOOL Enter;
}
