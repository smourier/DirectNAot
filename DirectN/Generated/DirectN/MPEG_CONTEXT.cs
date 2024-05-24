#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_context
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_CONTEXT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _U_e__Union
    {
        [FieldOffset(0)]
        public MPEG_BCS_DEMUX Demux;
        
        [FieldOffset(0)]
        public MPEG_WINSOCK Winsock;
    }
    
    public MPEG_CONTEXT_TYPE Type;
    public _U_e__Union U;
}
