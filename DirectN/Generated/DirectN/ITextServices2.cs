#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/nl-textserv-itextservices2
[GeneratedComInterface, Guid("8d33f741-cf58-11ce-a89d-00aa006cadc5")]
public partial interface ITextServices2 : ITextServices
{
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxGetNaturalSize2(uint dwAspect, HDC hdcDraw, HDC hicTargetDev, ref DVTARGETDEVICE ptd, uint dwMode, in SIZE psizelExtent, ref int pwidth, ref int pheight, ref int pascent);
    
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txdrawd2d
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvThiscall)])]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TxDrawD2D(ID2D1RenderTarget pRenderTarget, ref RECTL lprcBounds, ref RECT lprcUpdate, int lViewId);
}
