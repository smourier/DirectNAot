namespace DirectN;

public partial struct DWRITE_CLUSTER_METRICS
{
    public readonly bool canWrapLineAfter => (_bitfield & 0x1) != 0;
    public readonly bool isWhitespace => (_bitfield & 0x2) != 0;
    public readonly bool isNewline => (_bitfield & 0x4) != 0;
    public readonly bool isSoftHyphen => (_bitfield & 0x8) != 0;
    public readonly bool isRightToLeft => (_bitfield & 0x10) != 0;
}
