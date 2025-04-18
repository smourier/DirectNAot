#nullable enable
namespace DirectN;

public partial struct DXVA2TraceVideoProcessBltData
{
    public EVENT_TRACE_HEADER wmiHeader;
    public ulong pObject;
    public ulong pRenderTarget;
    public ulong TargetFrameTime;
    public RECT TargetRect;
    public BOOL Enter;
}
