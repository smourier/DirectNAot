namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodecsdk/ne-wincodecsdk-wicpersistoptions
public enum WICPersistOptions
{
    WICPersistOptionDefault = 0,
    WICPersistOptionLittleEndian = 0,
    WICPersistOptionBigEndian = 1,
    WICPersistOptionStrictFormat = 2,
    WICPersistOptionNoCacheStream = 4,
    WICPersistOptionPreferUTF8 = 8,
    WICPersistOptionMask = 65535,
}
