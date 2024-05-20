#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_VD_ESCAPE_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpstrCommand;
}
