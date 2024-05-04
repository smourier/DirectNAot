#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSP_TIMEFORMAT
{
    public KSIDENTIFIER Property;
    public Guid SourceFormat;
    public Guid TargetFormat;
    public long Time;
}
