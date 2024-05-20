#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_OVLY_SAVE_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpfilename;
    public RECT rc;
}
