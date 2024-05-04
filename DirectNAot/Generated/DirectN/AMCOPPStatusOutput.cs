#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-amcoppstatusoutput
[StructLayout(LayoutKind.Sequential)]
public partial struct AMCOPPStatusOutput
{
    public Guid macKDI;
    public uint cbSizeData;
    public InlineArrayByte4076 COPPStatus;
}
