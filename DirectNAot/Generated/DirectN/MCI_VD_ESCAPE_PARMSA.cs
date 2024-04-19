namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_VD_ESCAPE_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrCommand;
}
