﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1drawingstateblock
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("28506e39-ebf6-46a1-bb47-fd85565ab957")]
public partial interface ID2D1DrawingStateBlock : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1drawingstateblock-getdescription
    [PreserveSig]
    public void GetDescription(out D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1drawingstateblock-setdescription
    [PreserveSig]
    public void SetDescription(in D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1drawingstateblock-settextrenderingparams
    [PreserveSig]
    public void SetTextRenderingParams(IDWriteRenderingParams textRenderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1drawingstateblock-gettextrenderingparams
    [PreserveSig]
    public void GetTextRenderingParams(out IDWriteRenderingParams textRenderingParams);
}
