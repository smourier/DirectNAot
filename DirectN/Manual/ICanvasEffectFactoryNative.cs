namespace DirectN;

[GeneratedComInterface, Guid("29BA1A1F-1CFE-44C3-984D-426D61B51427")]
public partial interface ICanvasEffectFactoryNative
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateWrapper(nint device, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Effect>))] ID2D1Effect effect, float dpi, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IInspectable>))] out IInspectable wrapper);
}
