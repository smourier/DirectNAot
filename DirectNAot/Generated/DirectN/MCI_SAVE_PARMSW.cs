#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_SAVE_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpfilename;
}
