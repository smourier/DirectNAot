namespace DirectN;

[GeneratedComInterface, Guid("33C0C1D8-33CF-11d3-BFF2-00C04F990235")]
public partial interface IProvidePropertyBuilder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapPropertyToBuilder(int dispid, out CTLBLDTYPE pdwCtlBldType, out BSTR pbstrGuidBldr, out VARIANT_BOOL builderAvailable);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecuteBuilder(int dispid, BSTR bstrGuidBldr, IDispatch pdispApp, HWND hwndBldrOwner, in VARIANT pvarValue, out VARIANT_BOOL pbActionCommitted);
}
