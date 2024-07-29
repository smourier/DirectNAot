#nullable enable
namespace DirectN;

public partial struct DXVAHDETW_DESTROYVIDEOPROCESSOR : IEquatable<DXVAHDETW_DESTROYVIDEOPROCESSOR>
{
    public static readonly DXVAHDETW_DESTROYVIDEOPROCESSOR Null = new();
    
    public ulong pObject;
    
    public DXVAHDETW_DESTROYVIDEOPROCESSOR(ulong value) => this.pObject = value;
    public override string ToString() => $"0x{pObject:x}";
    
    public override readonly bool Equals(object? obj) => obj is DXVAHDETW_DESTROYVIDEOPROCESSOR value && Equals(value);
    public readonly bool Equals(DXVAHDETW_DESTROYVIDEOPROCESSOR other) => other.pObject == pObject;
    public override readonly int GetHashCode() => pObject.GetHashCode();
    public static bool operator ==(DXVAHDETW_DESTROYVIDEOPROCESSOR left, DXVAHDETW_DESTROYVIDEOPROCESSOR right) => left.Equals(right);
    public static bool operator !=(DXVAHDETW_DESTROYVIDEOPROCESSOR left, DXVAHDETW_DESTROYVIDEOPROCESSOR right) => !left.Equals(right);
    public static implicit operator ulong(DXVAHDETW_DESTROYVIDEOPROCESSOR value) => value.pObject;
    public static implicit operator DXVAHDETW_DESTROYVIDEOPROCESSOR(ulong value) => new(value);
}
