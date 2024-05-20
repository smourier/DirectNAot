#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propidl/ns-propidl-serializedpropertyvalue
[StructLayout(LayoutKind.Sequential)]
public partial struct SERIALIZEDPROPERTYVALUE
{
    public uint dwType;
    public InlineArrayByte_1 rgb; // variable-length array placeholder
}
