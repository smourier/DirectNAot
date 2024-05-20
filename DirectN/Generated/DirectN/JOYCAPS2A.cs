#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct JOYCAPS2A
{
    public ushort wMid;
    public ushort wPid;
    public InlineArrayFoundationCHAR_32 szPname;
    public uint wXmin;
    public uint wXmax;
    public uint wYmin;
    public uint wYmax;
    public uint wZmin;
    public uint wZmax;
    public uint wNumButtons;
    public uint wPeriodMin;
    public uint wPeriodMax;
    public uint wRmin;
    public uint wRmax;
    public uint wUmin;
    public uint wUmax;
    public uint wVmin;
    public uint wVmax;
    public uint wCaps;
    public uint wMaxAxes;
    public uint wNumAxes;
    public uint wMaxButtons;
    public InlineArrayFoundationCHAR_32 szRegKey;
    public InlineArrayFoundationCHAR_260 szOEMVxD;
    public Guid ManufacturerGuid;
    public Guid ProductGuid;
    public Guid NameGuid;
}
