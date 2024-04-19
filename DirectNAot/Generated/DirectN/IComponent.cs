namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-icomponent
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1a5576fc-0e19-11d3-9d8e-00c04f72d980")]
public partial interface IComponent : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponent-get_type
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out IComponentType CT);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponent-put_type
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Type(IComponentType CT);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponent-get_desclangid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DescLangID(out int LangID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponent-put_desclangid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DescLangID(int LangID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponent-get_status
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Status(out ComponentStatus Status);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponent-put_status
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Status(ComponentStatus Status);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponent-get_description
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Description(out BSTR Description);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponent-put_description
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Description(BSTR Description);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponent-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IComponent NewComponent);
}
