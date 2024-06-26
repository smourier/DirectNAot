﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddenableirqinfo
public partial struct DDENABLEIRQINFO
{
    public uint dwIRQSources;
    public uint dwLine;
    public nint IRQCallback;
    public nint lpIRQData;
}
