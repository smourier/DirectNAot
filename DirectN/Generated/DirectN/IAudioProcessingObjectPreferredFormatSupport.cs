#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("51cbd3c4-f1f3-4d2f-a0e1-7e9c4dd0feb3")]
public partial interface IAudioProcessingObjectPreferredFormatSupport
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreferredInputFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioMediaType>))] IAudioMediaType outputFormat, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioMediaType>))] out IAudioMediaType preferredFormat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreferredOutputFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioMediaType>))] IAudioMediaType inputFormat, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioMediaType>))] out IAudioMediaType preferredFormat);
}
