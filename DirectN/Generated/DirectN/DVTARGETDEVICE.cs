#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/ns-objidl-dvtargetdevice
public partial struct DVTARGETDEVICE
{
    public uint tdSize;
    public ushort tdDriverNameOffset;
    public ushort tdDeviceNameOffset;
    public ushort tdPortNameOffset;
    public ushort tdExtDevmodeOffset;
    public InlineArrayByte_1 tdData; // variable-length array placeholder
}
