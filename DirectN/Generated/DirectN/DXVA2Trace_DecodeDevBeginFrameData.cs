#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2Trace_DecodeDevBeginFrameData
{
    public EVENT_TRACE_HEADER wmiHeader;
    public ulong pObject;
    public ulong pRenderTarget;
    public BOOL Enter;
}
