namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/ns-objidl-interfaceinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct INTERFACEINFO
{
    public nint pUnk;
    public Guid iid;
    public ushort wMethod;
}
