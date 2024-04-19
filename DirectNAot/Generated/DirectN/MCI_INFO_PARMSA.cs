namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_INFO_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrReturn;
    public uint dwRetSize;
}
