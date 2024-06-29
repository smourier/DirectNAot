#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectconstantbuffer
public partial struct ID3D10EffectConstantBuffer
{
    public nint VTablePtr;
    
    // ID3D10EffectVariable methods
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-isvalid
    public unsafe BOOL IsValid()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, BOOL>)(((void**)VTablePtr)[0]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-gettype
    public unsafe new nint GetType()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[1]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetDesc(ref D3D10_EFFECT_VARIABLE_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*,D3D10_EFFECT_VARIABLE_DESC*, HRESULT>)(((void**)VTablePtr)[2]))((ID3D10EffectVariable*)VTablePtr, (D3D10_EFFECT_VARIABLE_DESC*)Unsafe.AsPointer(ref pDesc));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getannotationbyindex
    public unsafe nint GetAnnotationByIndex(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*,uint, nint>)(((void**)VTablePtr)[3]))((ID3D10EffectVariable*)VTablePtr, Index);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getannotationbyname
    public unsafe nint GetAnnotationByName(PSTR Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*,PSTR, nint>)(((void**)VTablePtr)[4]))((ID3D10EffectVariable*)VTablePtr, Name);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getmemberbyindex
    public unsafe nint GetMemberByIndex(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*,uint, nint>)(((void**)VTablePtr)[5]))((ID3D10EffectVariable*)VTablePtr, Index);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getmemberbyname
    public unsafe nint GetMemberByName(PSTR Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*,PSTR, nint>)(((void**)VTablePtr)[6]))((ID3D10EffectVariable*)VTablePtr, Name);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getmemberbysemantic
    public unsafe nint GetMemberBySemantic(PSTR Semantic)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*,PSTR, nint>)(((void**)VTablePtr)[7]))((ID3D10EffectVariable*)VTablePtr, Semantic);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getelement
    public unsafe nint GetElement(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*,uint, nint>)(((void**)VTablePtr)[8]))((ID3D10EffectVariable*)VTablePtr, Index);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getparentconstantbuffer
    public unsafe nint GetParentConstantBuffer()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[9]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asscalar
    public unsafe nint AsScalar()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[10]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asvector
    public unsafe nint AsVector()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[11]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asmatrix
    public unsafe nint AsMatrix()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[12]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asstring
    public unsafe nint AsString()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[13]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asshaderresource
    public unsafe nint AsShaderResource()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[14]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asrendertargetview
    public unsafe nint AsRenderTargetView()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[15]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asdepthstencilview
    public unsafe nint AsDepthStencilView()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[16]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asconstantbuffer
    public unsafe nint AsConstantBuffer()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[17]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asshader
    public unsafe nint AsShader()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[18]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asblend
    public unsafe nint AsBlend()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[19]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asdepthstencil
    public unsafe nint AsDepthStencil()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[20]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-asrasterizer
    public unsafe nint AsRasterizer()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[21]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-assampler
    public unsafe nint AsSampler()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*, nint>)(((void**)VTablePtr)[22]))((ID3D10EffectVariable*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-setrawvalue
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT SetRawValue(nint pData, uint Offset, uint ByteCount)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*,nint,uint,uint, HRESULT>)(((void**)VTablePtr)[23]))((ID3D10EffectVariable*)VTablePtr, pData, Offset, ByteCount);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvariable-getrawvalue
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetRawValue(nint pData, uint Offset, uint ByteCount)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectVariable*,nint,uint,uint, HRESULT>)(((void**)VTablePtr)[24]))((ID3D10EffectVariable*)VTablePtr, pData, Offset, ByteCount);
    }
    
    // ID3D10EffectConstantBuffer methods
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectconstantbuffer-setconstantbuffer
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT SetConstantBuffer(ID3D10Buffer? pConstantBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectConstantBuffer*,ID3D10Buffer?, HRESULT>)(((void**)VTablePtr)[25]))((ID3D10EffectConstantBuffer*)VTablePtr, pConstantBuffer);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectconstantbuffer-getconstantbuffer
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetConstantBuffer(ref nint ppConstantBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectConstantBuffer*,nint*, HRESULT>)(((void**)VTablePtr)[26]))((ID3D10EffectConstantBuffer*)VTablePtr, (nint*)Unsafe.AsPointer(ref ppConstantBuffer));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectconstantbuffer-settexturebuffer
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT SetTextureBuffer(ID3D10ShaderResourceView? pTextureBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectConstantBuffer*,ID3D10ShaderResourceView?, HRESULT>)(((void**)VTablePtr)[27]))((ID3D10EffectConstantBuffer*)VTablePtr, pTextureBuffer);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectconstantbuffer-gettexturebuffer
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetTextureBuffer(ref nint ppTextureBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectConstantBuffer*,nint*, HRESULT>)(((void**)VTablePtr)[28]))((ID3D10EffectConstantBuffer*)VTablePtr, (nint*)Unsafe.AsPointer(ref ppTextureBuffer));
    }
}
