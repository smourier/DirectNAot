#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_OVLY_SAVE_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpfilename;
    public RECT rc;
}
