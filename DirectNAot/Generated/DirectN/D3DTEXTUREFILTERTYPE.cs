namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dtexturefiltertype
public enum D3DTEXTUREFILTERTYPE
{
    D3DTEXF_NONE = 0,
    D3DTEXF_POINT = 1,
    D3DTEXF_LINEAR = 2,
    D3DTEXF_ANISOTROPIC = 3,
    D3DTEXF_PYRAMIDALQUAD = 6,
    D3DTEXF_GAUSSIANQUAD = 7,
    D3DTEXF_CONVOLUTIONMONO = 8,
}
