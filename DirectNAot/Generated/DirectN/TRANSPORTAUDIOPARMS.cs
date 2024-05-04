#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct TRANSPORTAUDIOPARMS
{
    public int EnableOutput;
    public int EnableRecord;
    public int EnableSelsync;
    public int Input;
    public int MonitorSource;
}
