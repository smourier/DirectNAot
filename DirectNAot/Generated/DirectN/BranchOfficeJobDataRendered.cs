namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BranchOfficeJobDataRendered
{
    public long Size;
    public uint ICMMethod;
    public short Color;
    public short PrintQuality;
    public short YResolution;
    public short Copies;
    public short TTOption;
}
