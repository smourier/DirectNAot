﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawi/ns-ddrawi-ddhal_waitforverticalblankdata
public partial struct DDHAL_WAITFORVERTICALBLANKDATA
{
    public nint lpDD;
    public uint dwFlags;
    public uint bIsInVB;
    public nuint hEvent;
    public HRESULT ddRVal;
    public nint WaitForVerticalBlank;
}
