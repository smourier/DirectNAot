namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/ns-objidl-bind_opts
[StructLayout(LayoutKind.Sequential)]
public partial struct BIND_OPTS
{
    public uint cbStruct;
    public uint grfFlags;
    public uint grfMode;
    public uint dwTickCountDeadline;
}
