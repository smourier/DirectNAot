namespace DirectN;

public partial struct DEVPROPKEY : IEquatable<DEVPROPKEY>, IEquatable<PROPERTYKEY>
{
    public static readonly DEVPROPKEY Null = new();

    public DEVPROPKEY(Guid fmtid, uint pid)
    {
        this.fmtid = fmtid;
        this.pid = pid;
    }

    public DEVPROPKEY(byte[] bytes)
    {
        ArgumentNullException.ThrowIfNull(bytes);
        if (bytes.Length != 20)
            throw new ArgumentException(null, nameof(bytes));

        fmtid = new Guid([.. bytes.Take(16)]);
        pid = BitConverter.ToUInt32(bytes, 16);
    }

    public readonly bool IsNull => pid == 0 && fmtid == Guid.Empty;

    [SupportedOSPlatform("windows5.1.2600")]
    public static DEVPROPKEY? FromString(string? value, bool throwOnError = false)
    {
        if (value == null)
            return null;

        var hr = Functions.PSPropertyKeyFromString(PWSTR.From(value), out var pk).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return new DEVPROPKEY(pk.fmtid, pk.pid);
    }

    public override readonly bool Equals(object? obj) => (obj is DEVPROPKEY value && Equals(value)) || (obj is PROPERTYKEY pk && Equals(pk));
    public readonly bool Equals(DEVPROPKEY other) => other.pid == pid && other.fmtid == fmtid;
    public readonly bool Equals(PROPERTYKEY other) => other.pid == pid && other.fmtid == fmtid;
    public override readonly int GetHashCode() => fmtid.GetHashCode() ^ pid.GetHashCode();
    public static bool operator ==(DEVPROPKEY left, DEVPROPKEY right) => left.Equals(right);
    public static bool operator !=(DEVPROPKEY left, DEVPROPKEY right) => !left.Equals(right);

    public static implicit operator DEVPROPKEY(PROPERTYKEY pk) => new(pk.fmtid, pk.pid);
    public static explicit operator PROPERTYKEY(DEVPROPKEY pk) => new(pk.fmtid, pk.pid);

    // see https://msdn.microsoft.com/en-us/library/windows/desktop/bb762085.aspx for official format
    public override readonly string ToString() => $"{fmtid:B} {pid}";

    public static implicit operator DEVPROPKEY(byte[] value) => new(value);
}

