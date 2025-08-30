#nullable enable
namespace DirectN;

// https://learn.microsoft.com/office/client-developer/outlook/mapi/hresult
public partial struct HRESULT : IEquatable<HRESULT>, IValueGet<int>
{
    public static readonly HRESULT Null = new();
    
    public int Value;
    
    public HRESULT(int value) => this.Value = value;
    
    public override readonly bool Equals(object? obj) => obj is HRESULT value && Equals(value);
    public readonly bool Equals(HRESULT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HRESULT left, HRESULT right) => left.Equals(right);
    public static bool operator !=(HRESULT left, HRESULT right) => !left.Equals(right);
    public static implicit operator int(HRESULT value) => value.Value;
    public static implicit operator HRESULT(int value) => new(value);
    
    readonly int IValueGet<int>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
