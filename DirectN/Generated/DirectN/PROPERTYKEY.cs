#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypes/ns-wtypes-propertykey
[StructLayout(LayoutKind.Sequential)]
public partial struct PROPERTYKEY
{
    public Guid fmtid;
    public uint pid;
}
