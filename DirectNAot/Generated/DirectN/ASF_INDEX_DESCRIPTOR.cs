#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/ns-wmcontainer-asf_index_descriptor
[StructLayout(LayoutKind.Sequential)]
public partial struct ASF_INDEX_DESCRIPTOR
{
    public ASF_INDEX_IDENTIFIER Identifier;
    public ushort cPerEntryBytes;
    public InlineArraySystemChar32 szDescription;
    public uint dwInterval;
}
