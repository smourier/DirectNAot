namespace DirectN;

[GeneratedComInterface, Guid("301c060e-20d9-4587-9b03-f82ed9a9943c")]
public partial interface IMSVidGraphSegmentUserInput
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Click();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DblClick();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeyDown(in short KeyCode, short ShiftState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeyPress(in short KeyAscii);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeyUp(in short KeyCode, short ShiftState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MouseDown(short ButtonState, short ShiftState, int x, int y);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MouseMove(short ButtonState, short ShiftState, int x, int y);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MouseUp(short ButtonState, short ShiftState, int x, int y);
}
