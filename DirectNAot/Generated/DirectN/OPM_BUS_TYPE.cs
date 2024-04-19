﻿namespace DirectN;

public enum OPM_BUS_TYPE
{
    OPM_BUS_TYPE_OTHER = 0,
    OPM_BUS_TYPE_PCI = 1,
    OPM_BUS_TYPE_PCIX = 2,
    OPM_BUS_TYPE_PCIEXPRESS = 3,
    OPM_BUS_TYPE_AGP = 4,
    OPM_BUS_IMPLEMENTATION_MODIFIER_INSIDE_OF_CHIPSET = 65536,
    OPM_BUS_IMPLEMENTATION_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 131072,
    OPM_BUS_IMPLEMENTATION_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 196608,
    OPM_BUS_IMPLEMENTATION_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 262144,
    OPM_BUS_IMPLEMENTATION_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 327680,
    OPM_BUS_IMPLEMENTATION_MODIFIER_NON_STANDARD = int.MinValue,
    OPM_COPP_COMPATIBLE_BUS_TYPE_INTEGRATED = int.MinValue,
}
