#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsommatrixtransform
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("b77330ff-bb37-4501-a93e-f1b1e50bfc46")]
public partial interface IXpsOMMatrixTransform : IXpsOMShareable
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsommatrixtransform-getmatrix
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatrix(out XPS_MATRIX matrix);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsommatrixtransform-setmatrix
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMatrix(in XPS_MATRIX matrix);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsommatrixtransform-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] out IXpsOMMatrixTransform matrixTransform);
}
