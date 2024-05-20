#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10view
[GeneratedComInterface, Guid("c902b03f-60a7-49ba-9936-2a3ab37a7e33")]
public partial interface ID3D10View : ID3D10DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10view-getresource
    [PreserveSig]
    void GetResource(out ID3D10Resource ppResource);
}
