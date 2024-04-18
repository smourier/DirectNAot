namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PSPINFO
{
    public ushort cbSize;
    public ushort wReserved;
    public HANDLE hComPropSheet;
    public HANDLE hCPSUIPage;
    public nint pfnComPropSheet;
}
