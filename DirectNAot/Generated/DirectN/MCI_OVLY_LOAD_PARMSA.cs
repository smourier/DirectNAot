#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_OVLY_LOAD_PARMSA
{
    public nuint dwCallback;
    public PSTR lpfilename;
    public RECT rc;
}
