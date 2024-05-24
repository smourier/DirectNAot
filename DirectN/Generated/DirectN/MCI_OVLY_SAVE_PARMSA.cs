#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_OVLY_SAVE_PARMSA
{
    public nuint dwCallback;
    public PSTR lpfilename;
    public RECT rc;
}
