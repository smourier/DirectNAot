namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_WAVE_OPEN_PARMSW
{
    public nuint dwCallback;
    public uint wDeviceID;
    public PWSTR lpstrDeviceType;
    public PWSTR lpstrElementName;
    public PWSTR lpstrAlias;
    public uint dwBufferSeconds;
}
