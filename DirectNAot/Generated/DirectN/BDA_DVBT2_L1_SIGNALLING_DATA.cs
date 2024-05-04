#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_DVBT2_L1_SIGNALLING_DATA
{
    public byte L1Pre_TYPE;
    public byte L1Pre_BWT_S1_S2;
    public byte L1Pre_REPETITION_GUARD_PAPR;
    public byte L1Pre_MOD_COD_FEC;
    public InlineArrayByte5 L1Pre_POSTSIZE_INFO_PILOT;
    public byte L1Pre_TX_ID_AVAIL;
    public InlineArrayByte2 L1Pre_CELL_ID;
    public InlineArrayByte2 L1Pre_NETWORK_ID;
    public InlineArrayByte2 L1Pre_T2SYSTEM_ID;
    public byte L1Pre_NUM_T2_FRAMES;
    public InlineArrayByte2 L1Pre_NUM_DATA_REGENFLAG_L1POSTEXT;
    public InlineArrayByte2 L1Pre_NUMRF_CURRENTRF_RESERVED;
    public InlineArrayByte4 L1Pre_CRC32;
    public InlineArrayByte1 L1PostData; // variable-length array placeholder
}
