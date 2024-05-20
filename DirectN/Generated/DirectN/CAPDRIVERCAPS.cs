#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-capdrivercaps
[StructLayout(LayoutKind.Sequential)]
public partial struct CAPDRIVERCAPS
{
    public uint wDeviceIndex;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fHasOverlay;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fHasDlgVideoSource;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fHasDlgVideoFormat;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fHasDlgVideoDisplay;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fCaptureInitialized;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fDriverSuppliesPalettes;
    public HANDLE hVideoIn;
    public HANDLE hVideoOut;
    public HANDLE hVideoExtIn;
    public HANDLE hVideoExtOut;
}
