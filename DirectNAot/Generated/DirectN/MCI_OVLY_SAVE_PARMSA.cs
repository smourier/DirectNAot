namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_OVLY_SAVE_PARMSA
{
    public nuint dwCallback;
    public PSTR lpfilename;
    public FoundationRECT rc;
}
