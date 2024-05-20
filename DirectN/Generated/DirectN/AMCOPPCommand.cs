#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-amcoppcommand
[StructLayout(LayoutKind.Sequential)]
public partial struct AMCOPPCommand
{
    public Guid macKDI;
    public Guid guidCommandID;
    public uint dwSequence;
    public uint cbSizeData;
    public InlineArrayByte_4056 CommandData;
}
