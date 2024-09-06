#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineclassfactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("4d645ace-26aa-4688-9be1-df3516990b93")]
public partial interface IMFMediaEngineClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactory-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(uint dwFlags, IMFAttributes pAttr, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaEngine>))] out IMFMediaEngine ppPlayer);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactory-createtimerange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTimeRange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaTimeRange>))] out IMFMediaTimeRange ppTimeRange);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineclassfactory-createerror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateError([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaError>))] out IMFMediaError ppError);
}
