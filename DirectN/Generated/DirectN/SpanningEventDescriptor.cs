#nullable enable
namespace DirectN;

public partial struct SpanningEventDescriptor
{
    public ushort wDataLen;
    public ushort wProgNumber;
    public ushort wSID;
    public InlineArrayByte_1 bDescriptor; // variable-length array placeholder
}
