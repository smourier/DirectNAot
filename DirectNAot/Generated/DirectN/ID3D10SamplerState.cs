namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10samplerstate
[GeneratedComInterface, Guid("9b7e4c0c-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10SamplerState : ID3D10DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10samplerstate-getdesc
    [PreserveSig]
    public void GetDesc(out D3D10_SAMPLER_DESC pDesc);
}
