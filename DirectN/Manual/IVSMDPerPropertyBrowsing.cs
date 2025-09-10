namespace DirectN;

[GeneratedComInterface, Guid("7494683C-37A0-11d2-A273-00C04F8EF4FF")]
public partial interface IVSMDPerPropertyBrowsing
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyAttributes(int dispid, out uint pceltAttrs, out nint ppbstrTypeNames, out nint ppvarAttrValues);
}
