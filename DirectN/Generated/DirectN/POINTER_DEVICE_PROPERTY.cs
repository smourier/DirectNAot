#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-pointer_device_property
public partial struct POINTER_DEVICE_PROPERTY
{
    public int logicalMin;
    public int logicalMax;
    public int physicalMin;
    public int physicalMax;
    public uint unit;
    public uint unitExponent;
    public ushort usagePageId;
    public ushort usageId;
}
