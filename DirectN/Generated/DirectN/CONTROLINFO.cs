#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ns-ocidl-controlinfo
public partial struct CONTROLINFO
{
    public uint cb;
    public HACCEL hAccel;
    public ushort cAccel;
    public uint dwFlags;
}
