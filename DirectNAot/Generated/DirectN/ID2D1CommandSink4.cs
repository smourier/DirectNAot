#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1commandsink4
[GeneratedComInterface, Guid("c78a6519-40d6-4218-b2de-beeeb744bb3e")]
public partial interface ID2D1CommandSink4 : ID2D1CommandSink3
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1commandsink4-setprimitiveblend2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrimitiveBlend2(D2D1_PRIMITIVE_BLEND primitiveBlend);
}
