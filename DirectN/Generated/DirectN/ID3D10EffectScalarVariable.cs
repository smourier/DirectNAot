﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectscalarvariable
public partial struct ID3D10EffectScalarVariable
{
    public static readonly ID3D10EffectScalarVariable Null = new();
    
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
    
    // ID3D10EffectScalarVariable methods
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setfloat
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetFloat(float Value) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,float, HRESULT>)(((void**)*((void**)VTablePtr))[25]))((ID3D10EffectScalarVariable*)VTablePtr, Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getfloat
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetFloat(ref float pValue) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,float*, HRESULT>)(((void**)*((void**)VTablePtr))[26]))((ID3D10EffectScalarVariable*)VTablePtr, (float*)Unsafe.AsPointer(ref pValue));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setfloatarray
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetFloatArray([In][MarshalUsing(CountElementName = nameof(Count))] float[] pData, uint Offset, uint Count) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,float[],uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[27]))((ID3D10EffectScalarVariable*)VTablePtr, pData, Offset, Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getfloatarray
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetFloatArray([In][Out][MarshalUsing(CountElementName = nameof(Count))] float[] pData, uint Offset, uint Count) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,float[],uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[28]))((ID3D10EffectScalarVariable*)VTablePtr, pData, Offset, Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setint
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetInt(int Value) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,int, HRESULT>)(((void**)*((void**)VTablePtr))[29]))((ID3D10EffectScalarVariable*)VTablePtr, Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getint
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetInt(ref int pValue) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,int*, HRESULT>)(((void**)*((void**)VTablePtr))[30]))((ID3D10EffectScalarVariable*)VTablePtr, (int*)Unsafe.AsPointer(ref pValue));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setintarray
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetIntArray([In][MarshalUsing(CountElementName = nameof(Count))] int[] pData, uint Offset, uint Count) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,int[],uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[31]))((ID3D10EffectScalarVariable*)VTablePtr, pData, Offset, Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getintarray
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetIntArray([In][Out][MarshalUsing(CountElementName = nameof(Count))] int[] pData, uint Offset, uint Count) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,int[],uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[32]))((ID3D10EffectScalarVariable*)VTablePtr, pData, Offset, Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setbool
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetBool(BOOL Value) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,BOOL, HRESULT>)(((void**)*((void**)VTablePtr))[33]))((ID3D10EffectScalarVariable*)VTablePtr, Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getbool
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetBool(ref BOOL pValue) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,BOOL*, HRESULT>)(((void**)*((void**)VTablePtr))[34]))((ID3D10EffectScalarVariable*)VTablePtr, (BOOL*)Unsafe.AsPointer(ref pValue));
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setboolarray
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT SetBoolArray([In][MarshalUsing(CountElementName = nameof(Count))] BOOL[] pData, uint Offset, uint Count) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,BOOL[],uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[35]))((ID3D10EffectScalarVariable*)VTablePtr, pData, Offset, Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getboolarray
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT GetBoolArray([In][Out][MarshalUsing(CountElementName = nameof(Count))] BOOL[] pData, uint Offset, uint Count) =>
        ((delegate* unmanaged<ID3D10EffectScalarVariable*,BOOL[],uint,uint, HRESULT>)(((void**)*((void**)VTablePtr))[36]))((ID3D10EffectScalarVariable*)VTablePtr, pData, Offset, Count);
}
