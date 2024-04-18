namespace DirectN;

public partial struct DEVPROPKEY
{
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

        fmtid = new Guid(bytes.Take(16).ToArray());
        pid = BitConverter.ToUInt32(bytes, 16);
    }

    public static implicit operator DEVPROPKEY(byte[] value) => new(value);
}

