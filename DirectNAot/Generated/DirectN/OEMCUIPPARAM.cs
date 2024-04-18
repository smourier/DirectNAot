namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OEMCUIPPARAM
{
    public uint cbSize;
    public nint poemuiobj;
    public HANDLE hPrinter;
    public PWSTR pPrinterName;
    public HANDLE hModule;
    public HANDLE hOEMHeap;
    public nint pPublicDM;
    public nint pOEMDM;
    public uint dwFlags;
    public nint pDrvOptItems;
    public uint cDrvOptItems;
    public nint pOEMOptItems;
    public uint cOEMOptItems;
    public nint pOEMUserData;
    public nint OEMCUIPCallback;
}
