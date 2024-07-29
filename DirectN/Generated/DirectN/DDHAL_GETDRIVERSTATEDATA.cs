#nullable enable
namespace DirectN;

public partial struct DDHAL_GETDRIVERSTATEDATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nuint dwhContext;
    }
    
    public uint dwFlags;
    public _Anonymous_e__Union Anonymous;
    public nint lpdwStates;
    public uint dwLength;
    public HRESULT ddRVal;
}
