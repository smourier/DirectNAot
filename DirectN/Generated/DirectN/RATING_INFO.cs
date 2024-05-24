#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct RATING_INFO
{
    public uint rating_system_count;
    public nint lpratingsystem;
}
