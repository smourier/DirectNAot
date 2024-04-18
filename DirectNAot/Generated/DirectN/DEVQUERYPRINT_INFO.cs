namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DEVQUERYPRINT_INFO
{
    public ushort cbSize;
    public ushort Level;
    public HANDLE hPrinter;
    public nint pDevMode;
    public PWSTR pszErrorStr;
    public uint cchErrorStr;
    public uint cchNeeded;
}
