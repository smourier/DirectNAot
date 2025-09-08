#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentationtypes/ns-presentationtypes-systeminterrupttime
public partial struct SystemInterruptTime : IEquatable<SystemInterruptTime>, IValueGet<ulong>
{
    public static readonly SystemInterruptTime Null = new();
    
    public ulong value;
    
    public SystemInterruptTime(ulong value) => this.value = value;
    public override readonly string ToString() => $"0x{value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SystemInterruptTime value && Equals(value);
    public readonly bool Equals(SystemInterruptTime other) => other.value == value;
    public override readonly int GetHashCode() => value.GetHashCode();
    public static bool operator ==(SystemInterruptTime left, SystemInterruptTime right) => left.Equals(right);
    public static bool operator !=(SystemInterruptTime left, SystemInterruptTime right) => !left.Equals(right);
    public static implicit operator ulong(SystemInterruptTime value) => value.value;
    public static implicit operator SystemInterruptTime(ulong value) => new(value);
    
    readonly ulong IValueGet<ulong>.GetValue() => value;
    readonly object? IValueGet.GetValue() => value;
}
