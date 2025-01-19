namespace DirectN;

public partial struct PROPERTYKEY : IEquatable<PROPERTYKEY>
{
    public static readonly PROPERTYKEY Null = new();
    public const uint PID_FIRST_USABLE = 2;

    public PROPERTYKEY(Guid fmtid, uint pid)
    {
        this.fmtid = fmtid;
        this.pid = pid;
    }

    public readonly bool IsNull => pid == 0 && fmtid == Guid.Empty;

    [SupportedOSPlatform("windows5.1.2600")]
    public static PROPERTYKEY? FromString(string? value, bool throwOnError = false)
    {
        if (value == null)
            return null;

        var hr = Functions.PSPropertyKeyFromString(PWSTR.From(value), out var pk).ThrowOnError(throwOnError);
        return hr.IsError ? null : pk;
    }

    public override readonly bool Equals(object? obj) => obj is PROPERTYKEY value && Equals(value);
    public readonly bool Equals(PROPERTYKEY other) => other.pid == pid && other.fmtid == fmtid;
    public override readonly int GetHashCode() => fmtid.GetHashCode() ^ pid.GetHashCode();
    public static bool operator ==(PROPERTYKEY left, PROPERTYKEY right) => left.Equals(right);
    public static bool operator !=(PROPERTYKEY left, PROPERTYKEY right) => !left.Equals(right);

    // see https://msdn.microsoft.com/en-us/library/windows/desktop/bb762085.aspx for official format
    public override readonly string ToString() => $"{fmtid:B} {pid}";
}
