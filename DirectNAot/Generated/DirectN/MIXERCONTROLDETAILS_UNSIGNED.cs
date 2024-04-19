namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercontroldetails_unsigned
[StructLayout(LayoutKind.Sequential)]
public partial struct MIXERCONTROLDETAILS_UNSIGNED
{
    public uint dwValue;
}
