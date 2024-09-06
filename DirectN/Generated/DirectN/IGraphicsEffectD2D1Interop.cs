#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.graphics.effects.interop/nn-windows-graphics-effects-interop-igraphicseffectd2d1interop
[GeneratedComInterface, Guid("2fc57384-a068-44d7-a331-30982fcf7177")]
public partial interface IGraphicsEffectD2D1Interop
{
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.effects.interop/nf-windows-graphics-effects-interop-igraphicseffectd2d1interop-geteffectid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffectId(out Guid id);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.effects.interop/nf-windows-graphics-effects-interop-igraphicseffectd2d1interop-getnamedpropertymapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNamedPropertyMapping(PWSTR name, out uint index, out GRAPHICS_EFFECT_PROPERTY_MAPPING mapping);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.effects.interop/nf-windows-graphics-effects-interop-igraphicseffectd2d1interop-getpropertycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.effects.interop/nf-windows-graphics-effects-interop-igraphicseffectd2d1interop-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(uint index, out nint value);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.effects.interop/nf-windows-graphics-effects-interop-igraphicseffectd2d1interop-getsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSource(uint index, out nint source);
    
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.effects.interop/nf-windows-graphics-effects-interop-igraphicseffectd2d1interop-getsourcecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceCount(out uint count);
}
