﻿namespace DirectN;

[InlineArray(11)]
public partial struct InlineArrayChar11
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}