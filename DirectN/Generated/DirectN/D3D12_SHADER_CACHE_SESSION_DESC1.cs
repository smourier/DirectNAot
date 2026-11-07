#nullable enable
namespace DirectN;

public partial struct D3D12_SHADER_CACHE_SESSION_DESC1
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_SHADER_CACHE_SESSION_MEMORY_DESC Memory;
        
        [FieldOffset(0)]
        public D3D12_SHADER_CACHE_SESSION_DISK_DESC Disk;
        
        [FieldOffset(0)]
        public D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC Registered;
        
        [FieldOffset(0)]
        public D3D12_SHADER_CACHE_SESSION_FILE_DESC File;
    }
    
    public D3D12_SHADER_CACHE_MODE Mode;
    public _Anonymous_e__Union Anonymous;
}
