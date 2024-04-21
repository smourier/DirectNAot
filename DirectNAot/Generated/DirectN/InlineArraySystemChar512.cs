﻿namespace DirectN;

[InlineArray(512)]
public partial struct InlineArraySystemChar512
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}