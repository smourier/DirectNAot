#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SpanningEventEmmMessage
{
    public byte bCAbroadcasterGroupId;
    public byte bMessageControl;
    public ushort wServiceId;
    public ushort wTableIdExtension;
    public byte bDeletionStatus;
    public byte bDisplayingDuration1;
    public byte bDisplayingDuration2;
    public byte bDisplayingDuration3;
    public byte bDisplayingCycle;
    public byte bFormatVersion;
    public byte bDisplayPosition;
    public ushort wMessageLength;
    public InlineArraySystemChar1 szMessageArea; // variable-length array placeholder
}
