namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_MONITOR_DESCRIPTOR
{
    public uint DescriptorSize;
    public InlineArrayByte1 Descriptor; // variable-length array placeholder
}
