#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATARANGE_BDA_TRANSPORT
{
    public KSDATAFORMAT DataRange;
    public BDA_TRANSPORT_INFO BdaTransportInfo;
}
