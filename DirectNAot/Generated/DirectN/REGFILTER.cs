#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct REGFILTER
{
    public Guid Clsid;
    public PWSTR Name;
}
