namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DD32BITDRIVERDATA
{
    public InlineArrayCHAR260 szName;
    public InlineArrayCHAR64 szEntryPoint;
    public uint dwContext;
}
