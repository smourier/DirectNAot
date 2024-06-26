﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/ns-mfsharingengine-device_info
public partial struct DEVICE_INFO
{
    public BSTR pFriendlyDeviceName;
    public BSTR pUniqueDeviceName;
    public BSTR pManufacturerName;
    public BSTR pModelName;
    public BSTR pIconURL;
}
