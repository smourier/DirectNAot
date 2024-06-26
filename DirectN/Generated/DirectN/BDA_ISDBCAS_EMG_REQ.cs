﻿#nullable enable
namespace DirectN;

public partial struct BDA_ISDBCAS_EMG_REQ
{
    public byte bCLA;
    public byte bINS;
    public byte bP1;
    public byte bP2;
    public byte bLC;
    public InlineArrayByte_6 bCardId;
    public byte bProtocol;
    public byte bCABroadcasterGroupId;
    public byte bMessageControl;
    public InlineArrayByte_1 bMessageCode; // variable-length array placeholder
}
