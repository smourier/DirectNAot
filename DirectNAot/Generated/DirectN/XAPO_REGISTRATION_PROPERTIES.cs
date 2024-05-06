#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapo/ns-xapo-xapo_registration_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct XAPO_REGISTRATION_PROPERTIES
{
    public Guid clsid;
    public InlineArraySystemChar_256 FriendlyName;
    public InlineArraySystemChar_256 CopyrightInfo;
    public uint MajorVersion;
    public uint MinorVersion;
    public uint Flags;
    public uint MinInputBufferCount;
    public uint MaxInputBufferCount;
    public uint MinOutputBufferCount;
    public uint MaxOutputBufferCount;
}
