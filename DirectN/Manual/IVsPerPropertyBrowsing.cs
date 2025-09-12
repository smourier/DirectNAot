namespace DirectN;

[GeneratedComInterface, Guid("0FF510A3-5FA5-49F1-8CCC-190D71083F3E")]
public partial interface IVsPerPropertyBrowsing
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HideProperty(int dispid, out BOOL pfHide);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayChildProperties(int dispid, out BOOL pfDisplay);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocalizedPropertyInfo(int dispid, uint localeID, nint pbstrLocalizedName, nint pbstrLocalizeDescription);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasDefaultValue(int dispid, out BOOL fDefault);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPropertyReadOnly(int dispid, out BOOL fReadOnly);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClassName(out BSTR pbstrClassName);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanResetPropertyValue(int dispid, out BOOL pfCanReset);

    [return: MarshalAs(UnmanagedType.Error)]
    [PreserveSig]
    HRESULT ResetPropertyValue(int dispid);
}
