#nullable enable
namespace DirectN;

public partial struct BDA_CAS_CLOSEMMIDATA : IEquatable<BDA_CAS_CLOSEMMIDATA>
{
    public static readonly BDA_CAS_CLOSEMMIDATA Null = new();
    
    public uint ulDialogNumber;
    
    public BDA_CAS_CLOSEMMIDATA(uint value) => this.ulDialogNumber = value;
    public override string ToString() => $"0x{ulDialogNumber:x}";
    
    public override readonly bool Equals(object? obj) => obj is BDA_CAS_CLOSEMMIDATA value && Equals(value);
    public readonly bool Equals(BDA_CAS_CLOSEMMIDATA other) => other.ulDialogNumber == ulDialogNumber;
    public override readonly int GetHashCode() => ulDialogNumber.GetHashCode();
    public static bool operator ==(BDA_CAS_CLOSEMMIDATA left, BDA_CAS_CLOSEMMIDATA right) => left.Equals(right);
    public static bool operator !=(BDA_CAS_CLOSEMMIDATA left, BDA_CAS_CLOSEMMIDATA right) => !left.Equals(right);
    public static implicit operator uint(BDA_CAS_CLOSEMMIDATA value) => value.ulDialogNumber;
    public static implicit operator BDA_CAS_CLOSEMMIDATA(uint value) => new(value);
}
