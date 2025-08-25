#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ipropertynotifysink
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("9bfbbc02-eff1-101a-84ed-00aa00341d07")]
public partial interface IPropertyNotifySink
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertynotifysink-onchanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnChanged(int dispID);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipropertynotifysink-onrequestedit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnRequestEdit(int dispID);
}
