namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_2/nn-d2d1_2-id2d1commandsink1
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("9eb767fd-4269-4467-b8c2-eb30cb305743")]
public partial interface ID2D1CommandSink1 : ID2D1CommandSink
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-id2d1commandsink1-setprimitiveblend1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrimitiveBlend1(D2D1_PRIMITIVE_BLEND primitiveBlend);
}
