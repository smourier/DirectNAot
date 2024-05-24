#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_VD_ESCAPE_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrCommand;
}
