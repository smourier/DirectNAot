#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-capdrivercaps
public partial struct CAPDRIVERCAPS
{
    public uint wDeviceIndex;
    public BOOL fHasOverlay;
    public BOOL fHasDlgVideoSource;
    public BOOL fHasDlgVideoFormat;
    public BOOL fHasDlgVideoDisplay;
    public BOOL fCaptureInitialized;
    public BOOL fDriverSuppliesPalettes;
    public HANDLE hVideoIn;
    public HANDLE hVideoOut;
    public HANDLE hVideoExtIn;
    public HANDLE hVideoExtOut;
}
