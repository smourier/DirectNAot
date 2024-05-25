#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-generic-parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_GENERIC_PARMS : IEquatable<MCI_GENERIC_PARMS>
{
    public static readonly MCI_GENERIC_PARMS Null = new();
    
    public nuint dwCallback;
    
    public override readonly bool Equals(object? obj) => obj is MCI_GENERIC_PARMS value && Equals(value);
    public readonly bool Equals(MCI_GENERIC_PARMS other) => other.dwCallback == dwCallback;
    public override readonly int GetHashCode() => dwCallback.GetHashCode();
    public static bool operator ==(MCI_GENERIC_PARMS left, MCI_GENERIC_PARMS right) => left.Equals(right);
    public static bool operator !=(MCI_GENERIC_PARMS left, MCI_GENERIC_PARMS right) => !left.Equals(right);
}
