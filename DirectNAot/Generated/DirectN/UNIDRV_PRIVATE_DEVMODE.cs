namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct UNIDRV_PRIVATE_DEVMODE
{
    public InlineArrayUInt164 wReserved;
    public ushort wSize;
}
