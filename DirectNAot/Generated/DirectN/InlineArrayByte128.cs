﻿#nullable enable
namespace DirectN;

[InlineArray(128)]
public partial struct InlineArrayByte128
{
    public static int Length => 128;
    
    public byte Data;
}
