#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectvectorvariable
[GeneratedComInterface, Guid("62b98c44-1f82-4c67-bcd0-72cf8f217e81")]
public partial interface ID3D10EffectVectorVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-setboolvector
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBoolVector(ref BOOL pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-setintvector
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIntVector(ref int pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-setfloatvector
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFloatVector(ref float pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-getboolvector
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBoolVector(ref BOOL pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-getintvector
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIntVector(ref int pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-getfloatvector
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFloatVector(ref float pData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-setboolvectorarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBoolVectorArray(ref BOOL pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-setintvectorarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIntVectorArray(ref int pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-setfloatvectorarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFloatVectorArray(ref float pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-getboolvectorarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBoolVectorArray(ref BOOL pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-getintvectorarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIntVectorArray(ref int pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectvectorvariable-getfloatvectorarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFloatVectorArray(ref float pData, uint Offset, uint Count);
}
