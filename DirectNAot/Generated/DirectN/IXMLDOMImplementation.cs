namespace DirectN;

[GeneratedComInterface, Guid("2933bf8f-7b36-11d2-b20e-00c04f983e60")]
public partial interface IXMLDOMImplementation : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT hasFeature(BSTR feature, BSTR version, out VARIANT_BOOL hasFeature);
}
