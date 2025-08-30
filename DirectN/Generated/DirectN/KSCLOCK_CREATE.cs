#nullable enable
namespace DirectN;

public partial struct KSCLOCK_CREATE : IEquatable<KSCLOCK_CREATE>, IValueGet<uint>
{
    public static readonly KSCLOCK_CREATE Null = new();
    
    public uint CreateFlags;
    
    public KSCLOCK_CREATE(uint value) => this.CreateFlags = value;
    public override string ToString() => $"0x{CreateFlags:x}";
    
    public override readonly bool Equals(object? obj) => obj is KSCLOCK_CREATE value && Equals(value);
    public readonly bool Equals(KSCLOCK_CREATE other) => other.CreateFlags == CreateFlags;
    public override readonly int GetHashCode() => CreateFlags.GetHashCode();
    public static bool operator ==(KSCLOCK_CREATE left, KSCLOCK_CREATE right) => left.Equals(right);
    public static bool operator !=(KSCLOCK_CREATE left, KSCLOCK_CREATE right) => !left.Equals(right);
    public static implicit operator uint(KSCLOCK_CREATE value) => value.CreateFlags;
    public static implicit operator KSCLOCK_CREATE(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => CreateFlags;
    readonly object? IValueGet.GetValue() => CreateFlags;
}
