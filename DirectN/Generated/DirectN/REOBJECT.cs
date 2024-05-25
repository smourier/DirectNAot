#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richole/ns-richole-reobject
[StructLayout(LayoutKind.Sequential)]
public partial struct REOBJECT
{
    public uint cbStruct;
    public int cp;
    public Guid clsid;
    public nint poleobj;
    public nint pstg;
    public nint polesite;
    public SIZE sizel;
    public uint dvaspect;
    public REOBJECT_FLAGS dwFlags;
    public uint dwUser;
}
