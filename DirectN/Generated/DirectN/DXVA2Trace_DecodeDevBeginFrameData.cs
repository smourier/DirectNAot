#nullable enable
namespace DirectN;

public partial struct DXVA2Trace_DecodeDevBeginFrameData
{
    public EVENT_TRACE_HEADER wmiHeader;
    public ulong pObject;
    public ulong pRenderTarget;
    public BOOL Enter;
}
