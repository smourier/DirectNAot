namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1drawingstateblock1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("689f1f85-c72e-4e33-8f19-85754efd5ace")]
public partial interface ID2D1DrawingStateBlock1 : ID2D1DrawingStateBlock
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1drawingstateblock1-getdescription
    [PreserveSig]
    public void GetDescription(out D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1drawingstateblock1-setdescription
    [PreserveSig]
    public void SetDescription(in D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
}
