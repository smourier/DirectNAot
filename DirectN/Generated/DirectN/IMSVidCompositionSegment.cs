#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1c15d483-911d-11d2-b632-00c04f79498e")]
public partial interface IMSVidCompositionSegment : IMSVidGraphSegment
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Compose(IMSVidGraphSegment upstream, IMSVidGraphSegment downstream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Up([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidGraphSegment>))] out IMSVidGraphSegment upstream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Down([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidGraphSegment>))] out IMSVidGraphSegment downstream);
}
