namespace DirectN;

public partial struct LUID : IValueGet<long>
{
    public readonly long Value => (long)(((ulong)HighPart) << 32 | LowPart);
    public override readonly string ToString() => Value.ToString();

    readonly long IValueGet<long>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}

