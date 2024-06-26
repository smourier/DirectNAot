﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dmemorypressure
public partial struct D3DMEMORYPRESSURE
{
    public ulong BytesEvictedFromProcess;
    public ulong SizeOfInefficientAllocation;
    public uint LevelOfEfficiency;
}
