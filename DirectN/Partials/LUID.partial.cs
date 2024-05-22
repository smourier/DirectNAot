namespace DirectN;

public partial struct LUID
{
    public readonly long Value => (long)(((ulong)HighPart) << 32 | LowPart);
    public override readonly string ToString() => Value.ToString();
}

