#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DD32BITDRIVERDATA
{
    public InlineArrayFoundationCHAR_260 szName;
    public InlineArrayFoundationCHAR_64 szEntryPoint;
    public uint dwContext;
}
