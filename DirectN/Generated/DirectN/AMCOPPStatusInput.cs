#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-amcoppstatusinput
public partial struct AMCOPPStatusInput
{
    public Guid rApp;
    public Guid guidStatusRequestID;
    public uint dwSequence;
    public uint cbSizeData;
    public InlineArrayByte_4056 StatusData;
}
