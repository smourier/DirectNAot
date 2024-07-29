#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_winsock
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_WINSOCK : IEquatable<MPEG_WINSOCK>
{
    public static readonly MPEG_WINSOCK Null = new();
    
    public uint AVMGraphId;
    
    public MPEG_WINSOCK(uint value) => this.AVMGraphId = value;
    public override string ToString() => $"0x{AVMGraphId:x}";
    
    public override readonly bool Equals(object? obj) => obj is MPEG_WINSOCK value && Equals(value);
    public readonly bool Equals(MPEG_WINSOCK other) => other.AVMGraphId == AVMGraphId;
    public override readonly int GetHashCode() => AVMGraphId.GetHashCode();
    public static bool operator ==(MPEG_WINSOCK left, MPEG_WINSOCK right) => left.Equals(right);
    public static bool operator !=(MPEG_WINSOCK left, MPEG_WINSOCK right) => !left.Equals(right);
    public static implicit operator uint(MPEG_WINSOCK value) => value.AVMGraphId;
    public static implicit operator MPEG_WINSOCK(uint value) => new(value);
}
