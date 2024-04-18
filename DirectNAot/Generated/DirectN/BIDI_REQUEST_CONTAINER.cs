namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BIDI_REQUEST_CONTAINER
{
    public uint Version;
    public uint Flags;
    public uint Count;
    public InlineArrayBIDI_REQUEST_DATA1 aData; // variable-length array placeholder
}
