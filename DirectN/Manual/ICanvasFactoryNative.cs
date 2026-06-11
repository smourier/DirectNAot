namespace DirectN;

[GeneratedComInterface, Guid("695C440D-04B3-4EDD-BFD9-63E51E9F7202")]
public partial interface ICanvasFactoryNative : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOrCreate(nint device, nint resource, float dpi, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IInspectable>))] out IInspectable wrapper);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterWrapper(nint resource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IInspectable>))] IInspectable wrapper);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterWrapper(nint resource);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterEffectFactory(in Guid effectId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICanvasEffectFactoryNative>))] ICanvasEffectFactoryNative factory);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterEffectFactory(in Guid effectId);
}
