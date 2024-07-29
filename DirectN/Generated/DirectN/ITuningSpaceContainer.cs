#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ituningspacecontainer
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("5b692e84-e2f1-11d2-9493-00c04f72d980")]
public partial interface ITuningSpaceContainer : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT NewEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT varIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuningSpace>))] out ITuningSpace TuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-put_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Item(VARIANT varIndex, ITuningSpace TuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-tuningspacesforclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TuningSpacesForCLSID(BSTR SpaceCLSID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuningSpaces>))] out ITuningSpaces NewColl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT _TuningSpacesForCLSID2(in Guid SpaceCLSID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuningSpaces>))] out ITuningSpaces NewColl);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-tuningspacesforname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TuningSpacesForName(BSTR Name, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuningSpaces>))] out ITuningSpaces NewColl);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-findid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindID(ITuningSpace TuningSpace, out int ID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(ITuningSpace TuningSpace, out VARIANT NewIndex);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-get_enumtuningspaces
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnumTuningSpaces([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumTuningSpaces>))] out IEnumTuningSpaces ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT Index);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-get_maxcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaxCount(out int MaxCount);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspacecontainer-put_maxcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaxCount(int MaxCount);
}
