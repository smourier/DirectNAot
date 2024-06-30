#nullable enable
namespace DirectN;

public partial struct DDHAL_GETDRIVERSTATEDATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public static readonly _Anonymous_e__Union Null = new();
        
        [FieldOffset(0)]
        public nuint dwhContext;
        
        public override readonly bool Equals(object? obj) => obj is _Anonymous_e__Union value && Equals(value);
        public readonly bool Equals(_Anonymous_e__Union other) => other.dwhContext == dwhContext;
        public override readonly int GetHashCode() => dwhContext.GetHashCode();
        public static bool operator ==(_Anonymous_e__Union left, _Anonymous_e__Union right) => left.Equals(right);
        public static bool operator !=(_Anonymous_e__Union left, _Anonymous_e__Union right) => !left.Equals(right);
    }
    
    public uint dwFlags;
    public _Anonymous_e__Union Anonymous;
    public nint lpdwStates;
    public uint dwLength;
    public HRESULT ddRVal;
}
