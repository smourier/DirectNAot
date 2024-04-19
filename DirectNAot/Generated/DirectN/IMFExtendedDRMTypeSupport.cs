namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfextendeddrmtypesupport
[GeneratedComInterface, Guid("332ec562-3758-468d-a784-e38f23552128")]
public partial interface IMFExtendedDRMTypeSupport
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfextendeddrmtypesupport-istypesupportedex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsTypeSupportedEx(BSTR type, BSTR keySystem, out MF_MEDIA_ENGINE_CANPLAY pAnswer);
}
