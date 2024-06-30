﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectshadervariable
public partial struct ID3D10EffectShaderVariable
{
    public static readonly ID3D10EffectShaderVariable Null = new();
    
    public nint VTablePtr;
    
    // ID3D10EffectVariable methods
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-isvalid
    public readonly unsafe BOOL IsValid() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, BOOL>)(((void**)*((void**)VTablePtr))[0]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-gettype
    public readonly unsafe new nint GetType() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[1]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetDesc(ref D3D10_EFFECT_VARIABLE_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10EffectVariable*,D3D10_EFFECT_VARIABLE_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[2]))((ID3D10EffectVariable*)VTablePtr, (D3D10_EFFECT_VARIABLE_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getannotationbyindex
    public readonly unsafe nint GetAnnotationByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D10EffectVariable*,uint, nint>)(((void**)*((void**)VTablePtr))[3]))((ID3D10EffectVariable*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getannotationbyname
    public readonly unsafe nint GetAnnotationByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D10EffectVariable*,PSTR, nint>)(((void**)*((void**)VTablePtr))[4]))((ID3D10EffectVariable*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getmemberbyindex
    public readonly unsafe nint GetMemberByIndex(uint Index) =>
        ((delegate* unmanaged<ID3D10EffectVariable*,uint, nint>)(((void**)*((void**)VTablePtr))[5]))((ID3D10EffectVariable*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getmemberbyname
    public readonly unsafe nint GetMemberByName(PSTR Name) =>
        ((delegate* unmanaged<ID3D10EffectVariable*,PSTR, nint>)(((void**)*((void**)VTablePtr))[6]))((ID3D10EffectVariable*)VTablePtr, Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getmemberbysemantic
    public readonly unsafe nint GetMemberBySemantic(PSTR Semantic) =>
        ((delegate* unmanaged<ID3D10EffectVariable*,PSTR, nint>)(((void**)*((void**)VTablePtr))[7]))((ID3D10EffectVariable*)VTablePtr, Semantic);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getelement
    public readonly unsafe nint GetElement(uint Index) =>
        ((delegate* unmanaged<ID3D10EffectVariable*,uint, nint>)(((void**)*((void**)VTablePtr))[8]))((ID3D10EffectVariable*)VTablePtr, Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getparentconstantbuffer
    public readonly unsafe nint GetParentConstantBuffer() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[9]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asscalar
    public readonly unsafe nint AsScalar() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[10]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asvector
    public readonly unsafe nint AsVector() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[11]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asmatrix
    public readonly unsafe nint AsMatrix() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[12]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asstring
    public readonly unsafe nint AsString() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[13]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asshaderresource
    public readonly unsafe nint AsShaderResource() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[14]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asrendertargetview
    public readonly unsafe nint AsRenderTargetView() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[15]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asdepthstencilview
    public readonly unsafe nint AsDepthStencilView() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[16]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asconstantbuffer
    public readonly unsafe nint AsConstantBuffer() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[17]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asshader
    public readonly unsafe nint AsShader() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[18]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asblend
    public readonly unsafe nint AsBlend() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[19]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asdepthstencil
    public readonly unsafe nint AsDepthStencil() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[20]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asrasterizer
    public readonly unsafe nint AsRasterizer() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[21]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-assampler
    public readonly unsafe nint AsSampler() =>
        ((delegate* unmanaged<ID3D10EffectVariable*, nint>)(((void**)*((void**)VTablePtr))[22]))((ID3D10EffectVariable*)VTablePtr);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-setrawvalue
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetRawValue(nint pData, uint Offset, uint ByteCount) =>
        ((delegate* unmanaged<ID3D10EffectVariable*,nint,uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[23]))((ID3D10EffectVariable*)VTablePtr, pData, Offset, ByteCount);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getrawvalue
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetRawValue(nint pData, uint Offset, uint ByteCount) =>
        ((delegate* unmanaged<ID3D10EffectVariable*,nint,uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[24]))((ID3D10EffectVariable*)VTablePtr, pData, Offset, ByteCount);
    
    // ID3D10EffectShaderVariable methods
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getshaderdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetShaderDesc(uint ShaderIndex, ref D3D10_EFFECT_SHADER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10EffectShaderVariable*,uint,D3D10_EFFECT_SHADER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[25]))((ID3D10EffectShaderVariable*)VTablePtr, ShaderIndex, (D3D10_EFFECT_SHADER_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getvertexshader
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetVertexShader(uint ShaderIndex, ref nint ppVS) =>
        ((delegate* unmanaged<ID3D10EffectShaderVariable*,uint,nint*, HRESULT>)(((void**)*((void**)VTablePtr))[26]))((ID3D10EffectShaderVariable*)VTablePtr, ShaderIndex, (nint*)Unsafe.AsPointer(ref ppVS));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getgeometryshader
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetGeometryShader(uint ShaderIndex, ref nint ppGS) =>
        ((delegate* unmanaged<ID3D10EffectShaderVariable*,uint,nint*, HRESULT>)(((void**)*((void**)VTablePtr))[27]))((ID3D10EffectShaderVariable*)VTablePtr, ShaderIndex, (nint*)Unsafe.AsPointer(ref ppGS));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getpixelshader
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetPixelShader(uint ShaderIndex, ref nint ppPS) =>
        ((delegate* unmanaged<ID3D10EffectShaderVariable*,uint,nint*, HRESULT>)(((void**)*((void**)VTablePtr))[28]))((ID3D10EffectShaderVariable*)VTablePtr, ShaderIndex, (nint*)Unsafe.AsPointer(ref ppPS));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getinputsignatureelementdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetInputSignatureElementDesc(uint ShaderIndex, uint Element, ref D3D10_SIGNATURE_PARAMETER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10EffectShaderVariable*,uint,uint,D3D10_SIGNATURE_PARAMETER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[29]))((ID3D10EffectShaderVariable*)VTablePtr, ShaderIndex, Element, (D3D10_SIGNATURE_PARAMETER_DESC*)Unsafe.AsPointer(ref pDesc));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshadervariable-getoutputsignatureelementdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetOutputSignatureElementDesc(uint ShaderIndex, uint Element, ref D3D10_SIGNATURE_PARAMETER_DESC pDesc) =>
        ((delegate* unmanaged<ID3D10EffectShaderVariable*,uint,uint,D3D10_SIGNATURE_PARAMETER_DESC*, HRESULT>)(((void**)*((void**)VTablePtr))[30]))((ID3D10EffectShaderVariable*)VTablePtr, ShaderIndex, Element, (D3D10_SIGNATURE_PARAMETER_DESC*)Unsafe.AsPointer(ref pDesc));
}
