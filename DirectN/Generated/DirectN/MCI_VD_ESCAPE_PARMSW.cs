#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_VD_ESCAPE_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpstrCommand;
}
