namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1strokestyle
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd9069d-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1StrokeStyle : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1strokestyle-getstartcap
    [PreserveSig]
    public D2D1_CAP_STYLE GetStartCap();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1strokestyle-getendcap
    [PreserveSig]
    public D2D1_CAP_STYLE GetEndCap();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1strokestyle-getdashcap
    [PreserveSig]
    public D2D1_CAP_STYLE GetDashCap();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1strokestyle-getmiterlimit
    [PreserveSig]
    public float GetMiterLimit();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1strokestyle-getlinejoin
    [PreserveSig]
    public D2D1_LINE_JOIN GetLineJoin();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1strokestyle-getdashoffset
    [PreserveSig]
    public float GetDashOffset();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1strokestyle-getdashstyle
    [PreserveSig]
    public D2D1_DASH_STYLE GetDashStyle();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1strokestyle-getdashescount
    [PreserveSig]
    public uint GetDashesCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1strokestyle-getdashes
    [PreserveSig]
    public void GetDashes(out float dashes, uint dashesCount);
}
