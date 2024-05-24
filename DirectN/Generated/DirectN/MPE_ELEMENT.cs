#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpe_element
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPE_ELEMENT
{
    public ushort pid;
    public byte bComponentTag;
    public nint pNext;
}
