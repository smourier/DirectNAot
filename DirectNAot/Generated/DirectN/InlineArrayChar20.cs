﻿namespace DirectN;

[InlineArray(20)]
public partial struct InlineArrayChar20
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}