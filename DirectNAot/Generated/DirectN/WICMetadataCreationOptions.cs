namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/ne-wincodecsdk-wicmetadatacreationoptions
public enum WICMetadataCreationOptions
{
    WICMetadataCreationDefault = 0,
    WICMetadataCreationAllowUnknown = 0,
    WICMetadataCreationFailUnknown = 65536,
    WICMetadataCreationMask = -65536,
}
