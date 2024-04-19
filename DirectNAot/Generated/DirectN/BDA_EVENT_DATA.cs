namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_EVENT_DATA
{
    public int lResult;
    public uint ulEventID;
    public Guid uuidEventType;
    public uint ulEventDataLength;
    public InlineArrayByte1 argbEventData; // variable-length array placeholder
}
