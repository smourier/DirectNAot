﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportoutputformatdata
public partial struct DD_GETVPORTOUTPUTFORMATDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpddpfInputFormat;
    public nint lpddpfOutputFormats;
    public uint dwNumFormats;
    public HRESULT ddRVal;
    public nint GetVideoPortInputFormats;
}
