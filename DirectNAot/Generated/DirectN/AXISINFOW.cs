namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-axisinfow
[StructLayout(LayoutKind.Sequential)]
public partial struct AXISINFOW
{
    public int axMinValue;
    public int axMaxValue;
    public InlineArrayChar16 axAxisName;
}
