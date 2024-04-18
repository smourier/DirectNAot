namespace DirectN;

[GeneratedComInterface, Guid("7349d725-e2c1-4dca-afb5-c13e91bc9306")]
public partial interface IPrintOemUIMXDC
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AdjustImageableArea(HANDLE hPrinter, uint cbDevMode, in DEVMODEA pDevMode, uint cbOEMDM, nint pOEMDM, ref RECTL prclImageableArea);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AdjustImageCompression(HANDLE hPrinter, uint cbDevMode, in DEVMODEA pDevMode, uint cbOEMDM, nint pOEMDM, ref int pCompressionMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AdjustDPI(HANDLE hPrinter, uint cbDevMode, in DEVMODEA pDevMode, uint cbOEMDM, nint pOEMDM, ref int pDPI);
}
