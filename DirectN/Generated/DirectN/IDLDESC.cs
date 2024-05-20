#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct IDLDESC
{
    public nuint dwReserved;
    public IDLFLAGS wIDLFlags;
}
