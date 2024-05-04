#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-amcoppstatusinput
[StructLayout(LayoutKind.Sequential)]
public partial struct AMCOPPStatusInput
{
    public Guid rApp;
    public Guid guidStatusRequestID;
    public uint dwSequence;
    public uint cbSizeData;
    public InlineArrayByte4056 StatusData;
}
