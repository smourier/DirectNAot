#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_INFO_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrReturn;
    public uint dwRetSize;
}
