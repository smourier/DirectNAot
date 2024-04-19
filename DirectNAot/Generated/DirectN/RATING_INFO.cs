namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct RATING_INFO
{
    public uint rating_system_count;
    public nint lpratingsystem;
}
