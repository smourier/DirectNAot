namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_UPGRADE_INFO_2
{
    public nint pPrinterName;
    public nint pOldDriverDirectory;
    public uint cVersion;
    public nint pName;
    public nint pEnvironment;
    public nint pDriverPath;
    public nint pDataFile;
    public nint pConfigFile;
    public nint pHelpFile;
    public nint pDependentFiles;
    public nint pMonitorName;
    public nint pDefaultDataType;
    public nint pszzPreviousNames;
}
