#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_so_declaration_entry
public partial struct D3D10_SO_DECLARATION_ENTRY
{
    public PSTR SemanticName;
    public uint SemanticIndex;
    public byte StartComponent;
    public byte ComponentCount;
    public byte OutputSlot;
}
