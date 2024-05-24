#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_LOAD_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpfilename;
}
