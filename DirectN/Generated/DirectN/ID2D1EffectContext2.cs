#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("577ad2a0-9fc7-4dda-8b18-dab810140052")]
public partial interface ID2D1EffectContext2 : ID2D1EffectContext1
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorContextFromDxgiColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1ColorContext1>))] out ID2D1ColorContext1 colorContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorContextFromSimpleColorProfile(in D2D1_SIMPLE_COLOR_PROFILE simpleProfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1ColorContext1>))] out ID2D1ColorContext1 colorContext);
}
