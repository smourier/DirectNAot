#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_SAVE_PARMSA
{
    public nuint dwCallback;
    public PSTR lpfilename;
}
