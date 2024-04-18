namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11linker
[GeneratedComInterface, Guid("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e")]
public partial interface ID3D11Linker
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11linker-link
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Link(ID3D11ModuleInstance pEntry, PSTR pEntryName, PSTR pTargetName, uint uFlags, out ID3DBlob ppShaderBlob, nint/* nint */ ppErrorBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11linker-uselibrary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UseLibrary(ID3D11ModuleInstance pLibraryMI);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11linker-addclipplanefromcbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry);
}
