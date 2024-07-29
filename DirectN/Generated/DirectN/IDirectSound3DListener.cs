#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("279afa84-4981-11ce-a521-0020af0be560")]
public partial interface IDirectSound3DListener
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DS3DLISTENER pListener);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDistanceFactor(out float pflDistanceFactor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDopplerFactor(out float pflDopplerFactor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOrientation(out D3DVECTOR pvOrientFront, out D3DVECTOR pvOrientTop);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPosition(out D3DVECTOR pvPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRolloffFactor(out float pflRolloffFactor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVelocity(out D3DVECTOR pvVelocity);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DS3DLISTENER pcListener, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDistanceFactor(float flDistanceFactor, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDopplerFactor(float flDopplerFactor, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOrientation(float xFront, float yFront, float zFront, float xTop, float yTop, float zTop, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPosition(float x, float y, float z, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRolloffFactor(float flRolloffFactor, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVelocity(float x, float y, float z, uint dwApply);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitDeferredSettings();
}
