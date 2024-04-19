namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ns-ocidl-cauuid
[StructLayout(LayoutKind.Sequential)]
public partial struct CAUUID
{
    public uint cElems;
    public nint pElems;
}
