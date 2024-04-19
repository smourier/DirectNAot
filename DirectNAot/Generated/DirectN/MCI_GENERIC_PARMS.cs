namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-generic-parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_GENERIC_PARMS
{
    public nuint dwCallback;
}
