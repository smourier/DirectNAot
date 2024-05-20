﻿#nullable enable
namespace DirectN;

[Flags]
public enum D3D12_DEVICE_FLAGS
{
    D3D12_DEVICE_FLAG_NONE = 0,
    D3D12_DEVICE_FLAG_DEBUG_LAYER_ENABLED = 1,
    D3D12_DEVICE_FLAG_GPU_BASED_VALIDATION_ENABLED = 2,
    D3D12_DEVICE_FLAG_SYNCHRONIZED_COMMAND_QUEUE_VALIDATION_DISABLED = 4,
    D3D12_DEVICE_FLAG_DRED_AUTO_BREADCRUMBS_ENABLED = 8,
    D3D12_DEVICE_FLAG_DRED_PAGE_FAULT_REPORTING_ENABLED = 16,
    D3D12_DEVICE_FLAG_DRED_WATSON_REPORTING_ENABLED = 32,
    D3D12_DEVICE_FLAG_DRED_BREADCRUMB_CONTEXT_ENABLED = 64,
    D3D12_DEVICE_FLAG_DRED_USE_MARKERS_ONLY_BREADCRUMBS = 128,
    D3D12_DEVICE_FLAG_SHADER_INSTRUMENTATION_ENABLED = 256,
    D3D12_DEVICE_FLAG_AUTO_DEBUG_NAME_ENABLED = 512,
    D3D12_DEVICE_FLAG_FORCE_LEGACY_STATE_VALIDATION = 1024,
}