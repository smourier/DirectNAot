namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_UPGRADE_INFO_1
{
    public nint pPrinterName;
    public nint pOldDriverDirectory;
}
