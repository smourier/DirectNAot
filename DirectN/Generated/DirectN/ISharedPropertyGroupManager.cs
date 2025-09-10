#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/comsvcs/nn-comsvcs-isharedpropertygroupmanager
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("2a005c0d-a5de-11cf-9e66-00aa00a3f464")]
public partial interface ISharedPropertyGroupManager : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/comsvcs/nf-comsvcs-isharedpropertygroupmanager-createpropertygroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePropertyGroup(BSTR Name, ref int dwIsoMode, ref int dwRelMode, out VARIANT_BOOL fExists, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISharedPropertyGroup>))] out ISharedPropertyGroup ppGroup);
    
    // https://learn.microsoft.com/windows/win32/api/comsvcs/nf-comsvcs-isharedpropertygroupmanager-get_group
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Group(BSTR Name, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISharedPropertyGroup>))] out ISharedPropertyGroup ppGroup);
    
    // https://learn.microsoft.com/windows/win32/api/comsvcs/nf-comsvcs-isharedpropertygroupmanager-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint retval);
}
