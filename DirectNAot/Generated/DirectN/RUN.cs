namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-run
[StructLayout(LayoutKind.Sequential)]
public partial struct RUN
{
    public int iStart;
    public int iStop;
}
