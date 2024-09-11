#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iregistertuner
[GeneratedComInterface, Guid("359b3901-572c-4854-bb49-cdef66606a25")]
public partial interface IRegisterTuner
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iregistertuner-register
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Register([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuner>))] ITuner pTuner, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] IGraphBuilder pGraph);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iregistertuner-unregister
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unregister();
}
