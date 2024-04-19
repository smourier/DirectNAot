namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSTOPOLOGY_ENDPOINTIDPAIR
{
    public KSTOPOLOGY_ENDPOINTID RenderEndpoint;
    public KSTOPOLOGY_ENDPOINTID CaptureEndpoint;
}
