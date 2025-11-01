#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("0bfd1ade-0421-4909-acb7-7a7125416881")]
public partial interface IMFFaceDetectionTransformCallback
{
    [PreserveSig]
    void OnFaceDetectionResult(uint countOfBounds, [In][MarshalUsing(CountElementName = nameof(countOfBounds))] DetectedFaceBound[] detectedFaceBounds);
}
