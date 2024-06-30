#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_so_declaration_entry
public partial struct D3D12_SO_DECLARATION_ENTRY
{
    public uint Stream;
    public PSTR SemanticName;
    public uint SemanticIndex;
    public byte StartComponent;
    public byte ComponentCount;
    public byte OutputSlot;
}
