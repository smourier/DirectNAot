﻿#nullable enable
namespace DirectN;

public partial struct BDA_EVENT_DATA
{
    public int lResult;
    public uint ulEventID;
    public Guid uuidEventType;
    public uint ulEventDataLength;
    public InlineArrayByte_1 argbEventData; // variable-length array placeholder
}
