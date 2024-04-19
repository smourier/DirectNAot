namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DD32BITDRIVERDATA
{
    public InlineArrayFoundationCHAR260 szName;
    public InlineArrayFoundationCHAR64 szEntryPoint;
    public uint dwContext;
}
