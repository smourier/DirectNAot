﻿#nullable enable
namespace DirectN;

[InlineArray(512)]
public partial struct InlineArrayByte512
{
    public static int Length => 512;
    
    public byte Data;
}
