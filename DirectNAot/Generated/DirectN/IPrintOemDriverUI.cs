namespace DirectN;

[GeneratedComInterface, Guid("92b05d50-78bc-11d1-9480-00a0c90640b8")]
public partial interface IPrintOemDriverUI
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrvGetDriverSetting(nint pci, PSTR Feature, nint pOutput, uint cbSize, ref uint pcbNeeded, ref uint pdwOptionsReturned);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrvUpgradeRegistrySetting(HANDLE hPrinter, PSTR pFeature, PSTR pOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrvUpdateUISetting(nint pci, nint pOptItem, uint dwPreviousSelection, uint dwMode);
}
