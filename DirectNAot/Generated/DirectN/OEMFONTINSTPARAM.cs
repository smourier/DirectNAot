namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OEMFONTINSTPARAM
{
    public uint cbSize;
    public HANDLE hPrinter;
    public HANDLE hModule;
    public HANDLE hHeap;
    public uint dwFlags;
    public PWSTR pFontInstallerName;
}
