#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amva/ns-amva-amvainternalmeminfo
public partial struct AMVAInternalMemInfo : IEquatable<AMVAInternalMemInfo>
{
    public static readonly AMVAInternalMemInfo Null = new();
    
    public uint dwScratchMemAlloc;
    
    public AMVAInternalMemInfo(uint value) => this.dwScratchMemAlloc = value;
    public override string ToString() => $"0x{dwScratchMemAlloc:x}";
    
    public override readonly bool Equals(object? obj) => obj is AMVAInternalMemInfo value && Equals(value);
    public readonly bool Equals(AMVAInternalMemInfo other) => other.dwScratchMemAlloc == dwScratchMemAlloc;
    public override readonly int GetHashCode() => dwScratchMemAlloc.GetHashCode();
    public static bool operator ==(AMVAInternalMemInfo left, AMVAInternalMemInfo right) => left.Equals(right);
    public static bool operator !=(AMVAInternalMemInfo left, AMVAInternalMemInfo right) => !left.Equals(right);
    public static implicit operator uint(AMVAInternalMemInfo value) => value.dwScratchMemAlloc;
    public static implicit operator AMVAInternalMemInfo(uint value) => new(value);
}
