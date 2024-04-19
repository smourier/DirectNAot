namespace DirectN;

[GeneratedComInterface, Guid("279afa86-4981-11ce-a521-0020af0be560")]
public partial interface IDirectSound3DBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DS3DBUFFER pDs3dBuffer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConeAngles(out uint pdwInsideConeAngle, out uint pdwOutsideConeAngle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConeOrientation(out D3DVECTOR pvOrientation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConeOutsideVolume(out int plConeOutsideVolume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxDistance(out float pflMaxDistance);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMinDistance(out float pflMinDistance);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMode(out uint pdwMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPosition(out D3DVECTOR pvPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVelocity(out D3DVECTOR pvVelocity);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DS3DBUFFER pcDs3dBuffer, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConeAngles(uint dwInsideConeAngle, uint dwOutsideConeAngle, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConeOrientation(float x, float y, float z, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConeOutsideVolume(int lConeOutsideVolume, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxDistance(float flMaxDistance, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMinDistance(float flMinDistance, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMode(uint dwMode, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPosition(float x, float y, float z, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVelocity(float x, float y, float z, uint dwApply);
}
