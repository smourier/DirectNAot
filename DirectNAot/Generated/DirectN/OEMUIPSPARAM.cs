namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OEMUIPSPARAM
{
    public uint cbSize;
    public nint poemuiobj;
    public HANDLE hPrinter;
    public PWSTR pPrinterName;
    public HANDLE hModule;
    public HANDLE hOEMHeap;
    public nint pPublicDM;
    public nint pOEMDM;
    public nint pOEMUserData;
    public uint dwFlags;
    public nint pOemEntry;
}
