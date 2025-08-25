#nullable enable
namespace DirectN;

public partial struct BINDINFO
{
    public uint cbSize;
    public PWSTR szExtraInfo;
    public STGMEDIUM stgmedData;
    public uint grfBindInfoF;
    public uint dwBindVerb;
    public PWSTR szCustomVerb;
    public uint cbstgmedData;
    public uint dwOptions;
    public uint dwOptionsFlags;
    public uint dwCodePage;
    public SECURITY_ATTRIBUTES securityAttributes;
    public Guid iid;
    public nint pUnk;
    public uint dwReserved;
}
