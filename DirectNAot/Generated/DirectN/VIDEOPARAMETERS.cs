#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tvout/ns-tvout-videoparameters
[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEOPARAMETERS
{
    public Guid Guid;
    public uint dwOffset;
    public uint dwCommand;
    public uint dwFlags;
    public uint dwMode;
    public uint dwTVStandard;
    public uint dwAvailableModes;
    public uint dwAvailableTVStandard;
    public uint dwFlickerFilter;
    public uint dwOverScanX;
    public uint dwOverScanY;
    public uint dwMaxUnscaledX;
    public uint dwMaxUnscaledY;
    public uint dwPositionX;
    public uint dwPositionY;
    public uint dwBrightness;
    public uint dwContrast;
    public uint dwCPType;
    public uint dwCPCommand;
    public uint dwCPStandard;
    public uint dwCPKey;
    public uint bCP_APSTriggerBits;
    public InlineArrayByte_256 bOEMCopyProtection;
}
