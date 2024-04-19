namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_OVLY_LOAD_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpfilename;
    public FoundationRECT rc;
}
