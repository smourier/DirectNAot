#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_so_declaration_entry
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_SO_DECLARATION_ENTRY
{
    public uint Stream;
    public PSTR SemanticName;
    public uint SemanticIndex;
    public byte StartComponent;
    public byte ComponentCount;
    public byte OutputSlot;
}
