#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.graphics.imaging.interop/nn-windows-graphics-imaging-interop-isoftwarebitmapnative
[GeneratedComInterface, Guid("94bc8415-04ea-4b2e-af13-4de95aa898eb")]
public partial interface ISoftwareBitmapNative : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(in Guid riid, out nint /* void */ ppv);
}
