#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-filegroupdescriptorw
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILEGROUPDESCRIPTORW
{
    public uint cItems;
    public InlineArrayFILEDESCRIPTORW_1 fgd; // variable-length array placeholder
}
