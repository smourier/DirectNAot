#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8e7c791e-4467-11d3-9723-00c04f72db08")]
public partial interface _ISpPrivateEngineCall
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CallEngine(nint pCallFrame, uint ulCallFrameSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CallEngineEx(nint pInFrame, uint ulInFrameSize, out nint ppCoMemOutFrame, out uint pulOutFrameSize);
}
