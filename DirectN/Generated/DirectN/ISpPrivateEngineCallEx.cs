#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("defd682a-fe0a-42b9-bfa1-56d3d6cecfaf")]
public partial interface ISpPrivateEngineCallEx
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CallEngineSynchronize(nint pInFrame, uint ulInFrameSize, out nint ppCoMemOutFrame, out uint pulOutFrameSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CallEngineImmediate(nint pInFrame, uint ulInFrameSize, out nint ppCoMemOutFrame, out uint pulOutFrameSize);
}
