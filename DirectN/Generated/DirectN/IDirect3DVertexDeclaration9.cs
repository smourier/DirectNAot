#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dvertexdeclaration9
[GeneratedComInterface, Guid("dd13c59c-36fa-4098-a8fb-c7ed39dc8546")]
public partial interface IDirect3DVertexDeclaration9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvertexdeclaration9-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9>))] out IDirect3DDevice9 ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvertexdeclaration9-getdeclaration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeclaration(ref D3DVERTEXELEMENT9 pElement, ref uint pNumElements);
}
