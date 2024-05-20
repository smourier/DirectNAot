#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_LOAD_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpfilename;
}
