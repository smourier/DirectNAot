namespace DirectN;

public partial struct PROPERTYKEY : IEquatable<PROPERTYKEY>, IEquatable<DEVPROPKEY>
{
    public static readonly PROPERTYKEY Null = new();
    public const uint PID_FIRST_USABLE = 2;

    public PROPERTYKEY(Guid fmtid, uint pid)
    {
        this.fmtid = fmtid;
        this.pid = pid;
    }

    public PROPERTYKEY(byte[] bytes)
    {
        ArgumentNullException.ThrowIfNull(bytes);
        if (bytes.Length != 20)
            throw new ArgumentException(null, nameof(bytes));

        fmtid = new Guid([.. bytes.Take(16)]);
        pid = BitConverter.ToUInt32(bytes, 16);
    }

    public readonly bool IsNull => pid == 0 && fmtid == Guid.Empty;

    [SupportedOSPlatform("windows5.1.2600")]
    public static PROPERTYKEY? FromString(string? value, bool throwOnError = false)
    {
        if (value == null)
            return null;

        var hr = Functions.PSPropertyKeyFromString(PWSTR.From(value), out var pk).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return pk;
    }

    public override readonly bool Equals(object? obj) => (obj is DEVPROPKEY value && Equals(value)) || (obj is PROPERTYKEY pk && Equals(pk));
    public readonly bool Equals(PROPERTYKEY other) => other.pid == pid && other.fmtid == fmtid;
    public readonly bool Equals(DEVPROPKEY other) => other.pid == pid && other.fmtid == fmtid;
    public override readonly int GetHashCode() => fmtid.GetHashCode() ^ pid.GetHashCode();
    public static bool operator ==(PROPERTYKEY left, PROPERTYKEY right) => left.Equals(right);
    public static bool operator !=(PROPERTYKEY left, PROPERTYKEY right) => !left.Equals(right);

    public static explicit operator PROPERTYKEY(DEVPROPKEY pk) => new(pk.fmtid, pk.pid);
    public static implicit operator DEVPROPKEY(PROPERTYKEY pk) => new(pk.fmtid, pk.pid);

    // see https://msdn.microsoft.com/en-us/library/windows/desktop/bb762085.aspx for official format
    public override readonly string ToString() => $"{fmtid:B} {pid}";

    public static implicit operator PROPERTYKEY(byte[] value) => new(value);
}
