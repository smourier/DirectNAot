﻿#nullable enable
namespace DirectN;

public partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA2
{
    public HRESULT DeviceRemovedReason;
    public D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 AutoBreadcrumbsOutput;
    public D3D12_DRED_PAGE_FAULT_OUTPUT1 PageFaultOutput;
}
