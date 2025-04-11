#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-cida
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CIDA
{
    public uint cidl;
    public InlineArrayUInt32_1 aoffset; // variable-length array placeholder
}
