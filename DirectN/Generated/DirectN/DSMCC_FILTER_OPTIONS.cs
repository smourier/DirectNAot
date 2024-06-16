#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-dsmcc_filter_options
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DSMCC_FILTER_OPTIONS
{
    public BOOL fSpecifyProtocol;
    public byte Protocol;
    public BOOL fSpecifyType;
    public byte Type;
    public BOOL fSpecifyMessageId;
    public ushort MessageId;
    public BOOL fSpecifyTransactionId;
    public BOOL fUseTrxIdMessageIdMask;
    public uint TransactionId;
    public BOOL fSpecifyModuleVersion;
    public byte ModuleVersion;
    public BOOL fSpecifyBlockNumber;
    public ushort BlockNumber;
    public BOOL fGetModuleCall;
    public ushort NumberOfBlocksInModule;
}
