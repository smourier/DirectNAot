#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensorprofilecollection
[SupportedOSPlatform("windows10.0.17134")]
[GeneratedComInterface, Guid("c95ea55b-0187-48be-9353-8d2507662351")]
public partial interface IMFSensorProfileCollection
{
    [PreserveSig]
    uint GetProfileCount();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprofilecollection-getprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProfile(uint Index, out IMFSensorProfile ppProfile);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprofilecollection-addprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddProfile(IMFSensorProfile pProfile);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprofilecollection-findprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindProfile(in SENSORPROFILEID ProfileId, out IMFSensorProfile ppProfile);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprofilecollection-removeprofilebyindex
    [PreserveSig]
    void RemoveProfileByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprofilecollection-removeprofile
    [PreserveSig]
    void RemoveProfile(in SENSORPROFILEID ProfileId);
}
