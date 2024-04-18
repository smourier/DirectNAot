namespace DirectN;

[GeneratedComInterface, Guid("c6a7a9d0-774c-11d1-947f-00a0c90640b8")]
public partial interface IPrintOemUI : IPrintOemCommon
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PublishDriverInterface(nint pIUnknown);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CommonUIProp(uint dwMode, in OEMCUIPPARAM pOemCUIPParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DocumentPropertySheets(ref PROPSHEETUI_INFO pPSUIInfo, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DevicePropertySheets(in PROPSHEETUI_INFO pPSUIInfo, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DevQueryPrintEx(in OEMUIOBJ poemuiobj, in DEVQUERYPRINT_INFO pDQPInfo, in DEVMODEA pPublicDM, nint pOEMDM);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DeviceCapabilitiesA(ref OEMUIOBJ poemuiobj, HANDLE hPrinter, PWSTR pDeviceName, ushort wCapability, nint pOutput, in DEVMODEA pPublicDM, nint pOEMDM, uint dwOld, out uint dwResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpgradePrinter(uint dwLevel, nint /* byte array */ pDriverUpgradeInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PrinterEvent(PWSTR pPrinterName, int iDriverEvent, uint dwFlags, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DriverEvent(uint dwDriverEvent, uint dwLevel, nint /* byte array */ pDriverInfo, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT QueryColorProfile(HANDLE hPrinter, in OEMUIOBJ poemuiobj, in DEVMODEA pPublicDM, nint pOEMDM, uint ulQueryMode, nint pvProfileData, ref uint pcbProfileData, out uint pflProfileData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FontInstallerDlgProc(HWND hWnd, uint usMsg, WPARAM wParam, LPARAM lParam);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateExternalFonts(HANDLE hPrinter, HANDLE hHeap, PWSTR pwstrCartridges);
}
