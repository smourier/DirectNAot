#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-dsmcc_filter_options
[StructLayout(LayoutKind.Sequential)]
public partial struct DSMCC_FILTER_OPTIONS
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fSpecifyProtocol;
    public byte Protocol;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fSpecifyType;
    public byte Type;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fSpecifyMessageId;
    public ushort MessageId;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fSpecifyTransactionId;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fUseTrxIdMessageIdMask;
    public uint TransactionId;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fSpecifyModuleVersion;
    public byte ModuleVersion;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fSpecifyBlockNumber;
    public ushort BlockNumber;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fGetModuleCall;
    public ushort NumberOfBlocksInModule;
}
