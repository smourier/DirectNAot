#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_INFO_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpstrReturn;
    public uint dwRetSize;
}
