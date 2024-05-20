#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1concretetransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("1a799d8a-69f7-4e4c-9fed-437ccc6684cc")]
public partial interface ID2D1ConcreteTransform : ID2D1TransformNode
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1concretetransform-setoutputbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1concretetransform-setcached
    [PreserveSig]
    void SetCached([MarshalAs(UnmanagedType.U4)] bool isCached);
}
