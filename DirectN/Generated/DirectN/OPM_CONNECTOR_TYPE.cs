﻿#nullable enable
namespace DirectN;

public enum OPM_CONNECTOR_TYPE
{
    OPM_CONNECTOR_TYPE_OTHER = -1,
    OPM_CONNECTOR_TYPE_VGA = 0,
    OPM_CONNECTOR_TYPE_SVIDEO = 1,
    OPM_CONNECTOR_TYPE_COMPOSITE_VIDEO = 2,
    OPM_CONNECTOR_TYPE_COMPONENT_VIDEO = 3,
    OPM_CONNECTOR_TYPE_DVI = 4,
    OPM_CONNECTOR_TYPE_HDMI = 5,
    OPM_CONNECTOR_TYPE_LVDS = 6,
    OPM_CONNECTOR_TYPE_D_JPN = 8,
    OPM_CONNECTOR_TYPE_SDI = 9,
    OPM_CONNECTOR_TYPE_DISPLAYPORT_EXTERNAL = 10,
    OPM_CONNECTOR_TYPE_DISPLAYPORT_EMBEDDED = 11,
    OPM_CONNECTOR_TYPE_UDI_EXTERNAL = 12,
    OPM_CONNECTOR_TYPE_UDI_EMBEDDED = 13,
    OPM_CONNECTOR_TYPE_RESERVED = 14,
    OPM_CONNECTOR_TYPE_MIRACAST = 15,
    OPM_CONNECTOR_TYPE_TRANSPORT_AGNOSTIC_DIGITAL_MODE_A = 16,
    OPM_CONNECTOR_TYPE_TRANSPORT_AGNOSTIC_DIGITAL_MODE_B = 17,
    OPM_COPP_COMPATIBLE_CONNECTOR_TYPE_INTERNAL = int.MinValue,
}
