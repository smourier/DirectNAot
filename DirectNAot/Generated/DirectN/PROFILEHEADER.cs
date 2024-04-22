namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-profileheader
[StructLayout(LayoutKind.Sequential)]
public partial struct PROFILEHEADER
{
    public uint phSize;
    public uint phCMMType;
    public uint phVersion;
    public uint phClass;
    public uint phDataColorSpace;
    public uint phConnectionSpace;
    public InlineArrayUInt323 phDateTime;
    public uint phSignature;
    public uint phPlatform;
    public uint phProfileFlags;
    public uint phManufacturer;
    public uint phModel;
    public InlineArrayUInt322 phAttributes;
    public uint phRenderingIntent;
    public CIEXYZ phIlluminant;
    public uint phCreator;
    public InlineArrayByte44 phReserved;
}
