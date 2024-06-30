#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-enumtypew
public partial struct ENUMTYPEW
{
    public uint dwSize;
    public uint dwVersion;
    public uint dwFields;
    public PWSTR pDeviceName;
    public uint dwMediaType;
    public uint dwDitheringMode;
    public InlineArrayUInt32_2 dwResolution;
    public uint dwCMMType;
    public uint dwClass;
    public uint dwDataColorSpace;
    public uint dwConnectionSpace;
    public uint dwSignature;
    public uint dwPlatform;
    public uint dwProfileFlags;
    public uint dwManufacturer;
    public uint dwModel;
    public InlineArrayUInt32_2 dwAttributes;
    public uint dwRenderingIntent;
    public uint dwCreator;
    public uint dwDeviceClass;
}
