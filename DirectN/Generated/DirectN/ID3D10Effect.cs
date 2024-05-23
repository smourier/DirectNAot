#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effect
[GeneratedComInterface, Guid("51b0ca8b-ec0b-4519-870d-8ee1cb5017c7")]
public partial interface ID3D10Effect
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-isvalid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsValid();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-ispool
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsPool();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10Device>))] out ID3D10Device ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D10_EFFECT_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-getconstantbufferbyindex
    [PreserveSig]
    ID3D10EffectConstantBuffer GetConstantBufferByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-getconstantbufferbyname
    [PreserveSig]
    ID3D10EffectConstantBuffer GetConstantBufferByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-getvariablebyindex
    [PreserveSig]
    ID3D10EffectVariable GetVariableByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-getvariablebyname
    [PreserveSig]
    ID3D10EffectVariable GetVariableByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-getvariablebysemantic
    [PreserveSig]
    ID3D10EffectVariable GetVariableBySemantic(PSTR Semantic);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-gettechniquebyindex
    [PreserveSig]
    ID3D10EffectTechnique GetTechniqueByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-gettechniquebyname
    [PreserveSig]
    ID3D10EffectTechnique GetTechniqueByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-optimize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Optimize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effect-isoptimized
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsOptimized();
}
