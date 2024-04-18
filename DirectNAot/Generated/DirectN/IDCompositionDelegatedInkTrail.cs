namespace DirectN;

[GeneratedComInterface, Guid("c2448e9b-547d-4057-8cf5-8144ede1c2da")]
public partial interface IDCompositionDelegatedInkTrail
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddTrailPoints(in DCompositionInkTrailPoint inkPoints, uint inkPointsCount, out uint generationId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddTrailPointsWithPrediction(in DCompositionInkTrailPoint inkPoints, uint inkPointsCount, in DCompositionInkTrailPoint predictedInkPoints, uint predictedInkPointsCount, out uint generationId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemoveTrailPoints(uint generationId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT StartNewTrail(in D2D1_COLOR_F color);
}
