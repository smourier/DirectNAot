namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imediapropertybag
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("6025a880-c0d5-11d0-bd4e-00a0c911ce86")]
public partial interface IMediaPropertyBag : IPropertyBag
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediapropertybag-enumproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumProperty(uint iProperty, ref VARIANT pvarPropertyName, ref VARIANT pvarPropertyValue);
}
