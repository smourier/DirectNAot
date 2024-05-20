#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nn-audioenginebaseapo-iaudioprocessingobjectrt
[GeneratedComInterface, Guid("9e1d6a6d-ddbc-4e95-a4c7-ad64ba37846c")]
public partial interface IAudioProcessingObjectRT
{
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobjectrt-apoprocess
    [PreserveSig]
    void APOProcess(uint u32NumInputConnections, in APO_CONNECTION_PROPERTY ppInputConnections, uint u32NumOutputConnections, ref APO_CONNECTION_PROPERTY ppOutputConnections);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobjectrt-calcinputframes
    [PreserveSig]
    uint CalcInputFrames(uint u32OutputFrameCount);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobjectrt-calcoutputframes
    [PreserveSig]
    uint CalcOutputFrames(uint u32InputFrameCount);
}
