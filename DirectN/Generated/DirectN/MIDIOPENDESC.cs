﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmddk/ns-mmddk-midiopendesc
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIOPENDESC
{
    public HMIDI hMidi;
    public nuint dwCallback;
    public nuint dwInstance;
    public nuint dnDevNode;
    public uint cIds;
    public InlineArrayMIDIOPENSTRMID_1 rgIds; // variable-length array placeholder
}
