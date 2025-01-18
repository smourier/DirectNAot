#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/ns-objidl-bind_opts2~r1
public partial struct BIND_OPTS2
{
    public BIND_OPTS Base;
    public uint dwTrackFlags;
    public uint dwClassContext;
    public uint locale;
    public nint pServerInfo;
}
