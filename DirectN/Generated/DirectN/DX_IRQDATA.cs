#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-dx_irqdata
public partial struct DX_IRQDATA : IEquatable<DX_IRQDATA>
{
    public static readonly DX_IRQDATA Null = new();
    
    public uint dwIrqFlags;
    
    public DX_IRQDATA(uint value) => this.dwIrqFlags = value;
    public override string ToString() => $"0x{dwIrqFlags:x}";
    
    public override readonly bool Equals(object? obj) => obj is DX_IRQDATA value && Equals(value);
    public readonly bool Equals(DX_IRQDATA other) => other.dwIrqFlags == dwIrqFlags;
    public override readonly int GetHashCode() => dwIrqFlags.GetHashCode();
    public static bool operator ==(DX_IRQDATA left, DX_IRQDATA right) => left.Equals(right);
    public static bool operator !=(DX_IRQDATA left, DX_IRQDATA right) => !left.Equals(right);
    public static implicit operator uint(DX_IRQDATA value) => value.dwIrqFlags;
    public static implicit operator DX_IRQDATA(uint value) => new(value);
}
