#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("22f55882-280b-11d0-a8a9-00a0c90c2004")]
public partial interface IPropertyBag2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(uint cProperties, [MarshalUsing(CountElementName = nameof(cProperties))] in PROPBAG2[] pPropBag, IErrorLog pErrLog, [In][Out][MarshalUsing(CountElementName = nameof(cProperties))] VARIANT[] pvarValue, [In][Out][MarshalUsing(CountElementName = nameof(cProperties))] HRESULT[] phrError);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(uint cProperties, [MarshalUsing(CountElementName = nameof(cProperties))] in PROPBAG2[] pPropBag, [MarshalUsing(CountElementName = nameof(cProperties))] in VARIANT[] pvarValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CountProperties(out uint pcProperties);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyInfo(uint iProperty, uint cProperties, [In][Out][MarshalUsing(CountElementName = nameof(cProperties))] PROPBAG2[] pPropBag, out uint pcProperties);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadObject(PWSTR pstrName, uint dwHint, nint pUnkObject, IErrorLog pErrLog);
}
