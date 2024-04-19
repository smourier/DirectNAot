namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AM_DVD_ChangeRate
{
    public long StartInTime;
    public long StartOutTime;
    public int Rate;
}
