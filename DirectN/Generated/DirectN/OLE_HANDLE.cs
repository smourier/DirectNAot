#nullable enable
namespace DirectN;

public partial struct OLE_HANDLE : IEquatable<OLE_HANDLE>, IValueGet<uint>
{
    public static readonly OLE_HANDLE Null = new();
    
    public uint Value;
    
    public OLE_HANDLE(uint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is OLE_HANDLE value && Equals(value);
    public readonly bool Equals(OLE_HANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(OLE_HANDLE left, OLE_HANDLE right) => left.Equals(right);
    public static bool operator !=(OLE_HANDLE left, OLE_HANDLE right) => !left.Equals(right);
    public static implicit operator uint(OLE_HANDLE value) => value.Value;
    public static implicit operator OLE_HANDLE(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
