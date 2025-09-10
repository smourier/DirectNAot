namespace DirectN;

[GeneratedComInterface, Guid("33C0C1DA-33CF-11d3-BFF2-00C04F990235")]
public partial interface IPerPropertyBrowsing2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyAttributes(int dispid, nint pceltAttrs, nint ppbstrTypeNames, nint ppvarAttrValues);
}
