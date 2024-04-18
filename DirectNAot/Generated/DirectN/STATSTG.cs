namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/ns-objidl-statstg
[StructLayout(LayoutKind.Sequential)]
public partial struct STATSTG
{
    public PWSTR pwcsName;
    public uint type;
    public ulong cbSize;
    public FILETIME mtime;
    public FILETIME ctime;
    public FILETIME atime;
    public STGM grfMode;
    public uint grfLocksSupported;
    public Guid clsid;
    public uint grfStateBits;
    public uint reserved;
}
