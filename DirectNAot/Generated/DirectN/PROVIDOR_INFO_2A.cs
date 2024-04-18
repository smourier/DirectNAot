namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/providor-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct PROVIDOR_INFO_2A
{
    public PSTR pOrder;
}
