namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-ovly-rect-parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_OVLY_RECT_PARMS
{
    public nuint dwCallback;
    public FoundationRECT rc;
}
