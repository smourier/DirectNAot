namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DOCEVENT_ESCAPE
{
    public int iEscape;
    public int cjInput;
    public nint pvInData;
}
