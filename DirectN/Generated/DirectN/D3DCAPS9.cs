﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9caps/ns-d3d9caps-d3dcaps9
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DCAPS9
{
    public D3DDEVTYPE DeviceType;
    public uint AdapterOrdinal;
    public uint Caps;
    public uint Caps2;
    public uint Caps3;
    public uint PresentationIntervals;
    public uint CursorCaps;
    public uint DevCaps;
    public uint PrimitiveMiscCaps;
    public uint RasterCaps;
    public uint ZCmpCaps;
    public uint SrcBlendCaps;
    public uint DestBlendCaps;
    public uint AlphaCmpCaps;
    public uint ShadeCaps;
    public uint TextureCaps;
    public uint TextureFilterCaps;
    public uint CubeTextureFilterCaps;
    public uint VolumeTextureFilterCaps;
    public uint TextureAddressCaps;
    public uint VolumeTextureAddressCaps;
    public uint LineCaps;
    public uint MaxTextureWidth;
    public uint MaxTextureHeight;
    public uint MaxVolumeExtent;
    public uint MaxTextureRepeat;
    public uint MaxTextureAspectRatio;
    public uint MaxAnisotropy;
    public float MaxVertexW;
    public float GuardBandLeft;
    public float GuardBandTop;
    public float GuardBandRight;
    public float GuardBandBottom;
    public float ExtentsAdjust;
    public uint StencilCaps;
    public uint FVFCaps;
    public uint TextureOpCaps;
    public uint MaxTextureBlendStages;
    public uint MaxSimultaneousTextures;
    public uint VertexProcessingCaps;
    public uint MaxActiveLights;
    public uint MaxUserClipPlanes;
    public uint MaxVertexBlendMatrices;
    public uint MaxVertexBlendMatrixIndex;
    public float MaxPointSize;
    public uint MaxPrimitiveCount;
    public uint MaxVertexIndex;
    public uint MaxStreams;
    public uint MaxStreamStride;
    public uint VertexShaderVersion;
    public uint MaxVertexShaderConst;
    public uint PixelShaderVersion;
    public float PixelShader1xMaxValue;
    public uint DevCaps2;
    public float MaxNpatchTessellationLevel;
    public uint Reserved5;
    public uint MasterAdapterOrdinal;
    public uint AdapterOrdinalInGroup;
    public uint NumberOfAdaptersInGroup;
    public uint DeclTypes;
    public uint NumSimultaneousRTs;
    public uint StretchRectFilterCaps;
    public D3DVSHADERCAPS2_0 VS20Caps;
    public D3DPSHADERCAPS2_0 PS20Caps;
    public uint VertexTextureFilterCaps;
    public uint MaxVShaderInstructionsExecuted;
    public uint MaxPShaderInstructionsExecuted;
    public uint MaxVertexShader30InstructionSlots;
    public uint MaxPixelShader30InstructionSlots;
}
