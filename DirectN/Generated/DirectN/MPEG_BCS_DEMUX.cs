#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_bcs_demux
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_BCS_DEMUX : IEquatable<MPEG_BCS_DEMUX>
{
    public static readonly MPEG_BCS_DEMUX Null = new();
    
    public uint AVMGraphId;
    
    public MPEG_BCS_DEMUX(uint value) => this.AVMGraphId = value;
    public override string ToString() => $"0x{AVMGraphId:x}";
    
    public override readonly bool Equals(object? obj) => obj is MPEG_BCS_DEMUX value && Equals(value);
    public readonly bool Equals(MPEG_BCS_DEMUX other) => other.AVMGraphId == AVMGraphId;
    public override readonly int GetHashCode() => AVMGraphId.GetHashCode();
    public static bool operator ==(MPEG_BCS_DEMUX left, MPEG_BCS_DEMUX right) => left.Equals(right);
    public static bool operator !=(MPEG_BCS_DEMUX left, MPEG_BCS_DEMUX right) => !left.Equals(right);
    public static implicit operator uint(MPEG_BCS_DEMUX value) => value.AVMGraphId;
    public static implicit operator MPEG_BCS_DEMUX(uint value) => new(value);
}
