namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectscalarvariable
[GeneratedComInterface, Guid("00e48f7b-d2c8-49e8-a86c-022dee53431f")]
public partial interface ID3D10EffectScalarVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setfloat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFloat(float Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getfloat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFloat(out float pValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setfloatarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFloatArray([MarshalUsing(CountElementName = nameof(Count))] in float[] pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getfloatarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFloatArray([MarshalUsing(CountElementName = nameof(Count))] out float[] pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInt(int Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInt(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setintarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIntArray([MarshalUsing(CountElementName = nameof(Count))] in int[] pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getintarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIntArray([MarshalUsing(CountElementName = nameof(Count))] out int[] pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setbool
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBool([MarshalAs(UnmanagedType.U4)] bool Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getbool
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBool([MarshalAs(UnmanagedType.U4)] out bool pValue);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-setboolarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBoolArray([In][Out][MarshalUsing(CountElementName = nameof(Count))] int[] pData, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectscalarvariable-getboolarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBoolArray([MarshalUsing(CountElementName = nameof(Count))] out int[] pData, uint Offset, uint Count);
}
