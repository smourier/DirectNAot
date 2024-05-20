#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRECORESULTINFOEX
{
    public SPRECORESULTINFO Base;
    public ulong ullStreamTimeStart;
    public ulong ullStreamTimeEnd;
}
