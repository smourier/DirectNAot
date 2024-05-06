﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddcaps_dx3
[StructLayout(LayoutKind.Sequential)]
public partial struct DDCAPS_DX3
{
    public uint dwSize;
    public uint dwCaps;
    public uint dwCaps2;
    public uint dwCKeyCaps;
    public uint dwFXCaps;
    public uint dwFXAlphaCaps;
    public uint dwPalCaps;
    public uint dwSVCaps;
    public uint dwAlphaBltConstBitDepths;
    public uint dwAlphaBltPixelBitDepths;
    public uint dwAlphaBltSurfaceBitDepths;
    public uint dwAlphaOverlayConstBitDepths;
    public uint dwAlphaOverlayPixelBitDepths;
    public uint dwAlphaOverlaySurfaceBitDepths;
    public uint dwZBufferBitDepths;
    public uint dwVidMemTotal;
    public uint dwVidMemFree;
    public uint dwMaxVisibleOverlays;
    public uint dwCurrVisibleOverlays;
    public uint dwNumFourCCCodes;
    public uint dwAlignBoundarySrc;
    public uint dwAlignSizeSrc;
    public uint dwAlignBoundaryDest;
    public uint dwAlignSizeDest;
    public uint dwAlignStrideAlign;
    public InlineArrayUInt32_8 dwRops;
    public DDSCAPS ddsCaps;
    public uint dwMinOverlayStretch;
    public uint dwMaxOverlayStretch;
    public uint dwMinLiveVideoStretch;
    public uint dwMaxLiveVideoStretch;
    public uint dwMinHwCodecStretch;
    public uint dwMaxHwCodecStretch;
    public uint dwReserved1;
    public uint dwReserved2;
    public uint dwReserved3;
    public uint dwSVBCaps;
    public uint dwSVBCKeyCaps;
    public uint dwSVBFXCaps;
    public InlineArrayUInt32_8 dwSVBRops;
    public uint dwVSBCaps;
    public uint dwVSBCKeyCaps;
    public uint dwVSBFXCaps;
    public InlineArrayUInt32_8 dwVSBRops;
    public uint dwSSBCaps;
    public uint dwSSBCKeyCaps;
    public uint dwSSBFXCaps;
    public InlineArrayUInt32_8 dwSSBRops;
    public uint dwReserved4;
    public uint dwReserved5;
    public uint dwReserved6;
}
