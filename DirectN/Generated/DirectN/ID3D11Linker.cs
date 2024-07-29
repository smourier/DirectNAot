#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11linker
[GeneratedComInterface, Guid("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e")]
public partial interface ID3D11Linker
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11linker-link
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Link(ID3D11ModuleInstance pEntry, PSTR pEntryName, PSTR pTargetName, uint uFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3DBlob>))] out ID3DBlob ppShaderBlob, nint /* optional ID3DBlob* */ ppErrorBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11linker-uselibrary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UseLibrary(ID3D11ModuleInstance pLibraryMI);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11linker-addclipplanefromcbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry);
}
