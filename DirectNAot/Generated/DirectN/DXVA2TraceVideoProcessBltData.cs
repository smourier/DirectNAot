namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2TraceVideoProcessBltData
{
    public EVENT_TRACE_HEADER wmiHeader;
    public ulong pObject;
    public ulong pRenderTarget;
    public ulong TargetFrameTime;
    public FoundationRECT TargetRect;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Enter;
}
