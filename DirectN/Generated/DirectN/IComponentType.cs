#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-icomponenttype
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("6a340dc0-0311-11d3-9d8e-00c04f72d980")]
public partial interface IComponentType : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-get_category
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Category(out ComponentCategory Category);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-put_category
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Category(ComponentCategory Category);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-get_mediamajortype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MediaMajorType(out BSTR MediaMajorType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-put_mediamajortype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MediaMajorType(BSTR MediaMajorType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-get__mediamajortype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__MediaMajorType(out Guid MediaMajorTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-put__mediamajortype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__MediaMajorType(in Guid MediaMajorTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-get_mediasubtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MediaSubType(out BSTR MediaSubType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-put_mediasubtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MediaSubType(BSTR MediaSubType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-get__mediasubtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__MediaSubType(out Guid MediaSubTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-put__mediasubtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__MediaSubType(in Guid MediaSubTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-get_mediaformattype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MediaFormatType(out BSTR MediaFormatType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-put_mediaformattype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MediaFormatType(BSTR MediaFormatType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-get__mediaformattype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__MediaFormatType(out Guid MediaFormatTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-put__mediaformattype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__MediaFormatType(in Guid MediaFormatTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-get_mediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MediaType(out AM_MEDIA_TYPE MediaType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-put_mediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MediaType(in AM_MEDIA_TYPE MediaType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttype-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponentType>))] out IComponentType NewCT);
}
