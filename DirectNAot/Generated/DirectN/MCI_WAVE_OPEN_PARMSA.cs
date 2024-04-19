namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_WAVE_OPEN_PARMSA
{
    public nuint dwCallback;
    public uint wDeviceID;
    public PSTR lpstrDeviceType;
    public PSTR lpstrElementName;
    public PSTR lpstrAlias;
    public uint dwBufferSeconds;
}
