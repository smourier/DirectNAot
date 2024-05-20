#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/ns-sbe-streambuffer_attribute
[StructLayout(LayoutKind.Sequential)]
public partial struct STREAMBUFFER_ATTRIBUTE
{
    public PWSTR pszName;
    public STREAMBUFFER_ATTR_DATATYPE StreamBufferAttributeType;
    public nint pbAttribute;
    public ushort cbLength;
}
