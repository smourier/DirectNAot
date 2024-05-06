#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/ns-audioenginebaseapo-apo_reg_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct APO_REG_PROPERTIES
{
    public Guid clsid;
    public APO_FLAG Flags;
    public InlineArraySystemChar_256 szFriendlyName;
    public InlineArraySystemChar_256 szCopyrightInfo;
    public uint u32MajorVersion;
    public uint u32MinorVersion;
    public uint u32MinInputConnections;
    public uint u32MaxInputConnections;
    public uint u32MinOutputConnections;
    public uint u32MaxOutputConnections;
    public uint u32MaxInstances;
    public uint u32NumAPOInterfaces;
    public InlineArrayGuid_1 iidAPOInterfaceList; // variable-length array placeholder
}
