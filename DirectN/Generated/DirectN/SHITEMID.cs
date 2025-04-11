#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-shitemid
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHITEMID
{
    public ushort cb;
    public InlineArrayByte_1 abID; // variable-length array placeholder
}
