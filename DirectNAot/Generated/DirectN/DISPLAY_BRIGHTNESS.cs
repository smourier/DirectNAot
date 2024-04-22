namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAY_BRIGHTNESS
{
    public byte ucDisplayPolicy;
    public byte ucACBrightness;
    public byte ucDCBrightness;
}
