﻿#nullable enable
namespace DirectN;

public partial struct KSM_BDA_TUNER_TUNEREQUEST
{
    public KSIDENTIFIER Method;
    public uint ulTuneLength;
    public InlineArrayByte_1 argbTuneData; // variable-length array placeholder
}
