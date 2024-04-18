namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1effect
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("28211a43-7d89-476f-8181-2d6159b220ad")]
public partial interface ID2D1Effect : ID2D1Properties
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-setinput
    [PreserveSig]
    public void SetInput(uint index, ID2D1Image input, [MarshalAs(UnmanagedType.U4)] bool invalidate);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-setinputcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetInputCount(uint inputCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-getinput
    [PreserveSig]
    public void GetInput(uint index, out ID2D1Image input);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-getinputcount
    [PreserveSig]
    public uint GetInputCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-getoutput
    [PreserveSig]
    public void GetOutput(out ID2D1Image outputImage);
}
