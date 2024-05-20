#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSATTRIBUTE_AUDIOSIGNALPROCESSING_MODE
{
    public KSATTRIBUTE AttributeHeader;
    public Guid SignalProcessingMode;
}
