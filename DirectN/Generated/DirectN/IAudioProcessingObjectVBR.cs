#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7ba1db8f-78ad-49cd-9591-f79d80a17c81")]
public partial interface IAudioProcessingObjectVBR
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CalcMaxInputFrames(uint u32MaxOutputFrameCount, out uint pu32InputFrameCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CalcMaxOutputFrames(uint u32MaxInputFrameCount, out uint pu32OutputFrameCount);
}
