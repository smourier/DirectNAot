namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectmatrixvariable
[GeneratedComInterface, Guid("50666c24-b82f-4eed-a172-5b6e7e8522e0")]
public partial interface ID3D10EffectMatrixVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectmatrixvariable-setmatrix
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMatrix(ref float pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectmatrixvariable-getmatrix
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMatrix(ref float pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectmatrixvariable-setmatrixarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMatrixArray(ref float pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectmatrixvariable-getmatrixarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMatrixArray(ref float pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectmatrixvariable-setmatrixtranspose
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMatrixTranspose(ref float pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectmatrixvariable-getmatrixtranspose
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMatrixTranspose(ref float pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectmatrixvariable-setmatrixtransposearray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMatrixTransposeArray(ref float pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectmatrixvariable-getmatrixtransposearray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMatrixTransposeArray(ref float pData, uint Offset, uint Count);
}
