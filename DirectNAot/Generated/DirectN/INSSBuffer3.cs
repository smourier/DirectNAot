namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsbuffer/nn-wmsbuffer-inssbuffer3
[GeneratedComInterface, Guid("c87ceaaf-75be-4bc4-84eb-ac2798507672")]
public partial interface INSSBuffer3 : INSSBuffer2
{
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-inssbuffer3-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(Guid guidBufferProperty, nint pvBufferProperty, uint dwBufferPropertySize);
    
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-inssbuffer3-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(Guid guidBufferProperty, nint pvBufferProperty, ref uint pdwBufferPropertySize);
}
