#nullable enable
namespace DirectN;

public partial struct NTSTATUS : IEquatable<NTSTATUS>, IValueGet<int>
{
    public static readonly NTSTATUS Null = new();
    
    public int Value;
    
    public NTSTATUS(int value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is NTSTATUS value && Equals(value);
    public readonly bool Equals(NTSTATUS other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(NTSTATUS left, NTSTATUS right) => left.Equals(right);
    public static bool operator !=(NTSTATUS left, NTSTATUS right) => !left.Equals(right);
    public static implicit operator int(NTSTATUS value) => value.Value;
    public static implicit operator NTSTATUS(int value) => new(value);
    
    readonly int IValueGet<int>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
