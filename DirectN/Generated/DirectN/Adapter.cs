﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/cloneviewhelper/ns-cloneviewhelper-adapter
public partial struct Adapter
{
    public InlineArraySystemChar_128 AdapterName;
    public int numSources;
    public InlineArraySources_1 sources; // variable-length array placeholder
}
