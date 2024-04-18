namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-axisinfoa
[StructLayout(LayoutKind.Sequential)]
public partial struct AXISINFOA
{
    public int axMinValue;
    public int axMaxValue;
    public InlineArrayByte16 axAxisName;
}
