#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Explicit)]
public partial struct MF_MDL_SHARED_PAYLOAD_KEY
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _combined_e__Struct
    {
        public uint pHandle;
        public uint fHandle;
        public ulong uPayload;
    }
    
    [FieldOffset(0)]
    public _combined_e__Struct combined;
    
    [FieldOffset(0)]
    public Guid GMDLHandle;
}
