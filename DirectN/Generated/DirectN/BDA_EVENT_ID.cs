﻿#nullable enable
namespace DirectN;

public enum BDA_EVENT_ID
{
    BDA_EVENT_SIGNAL_LOSS = 0,
    BDA_EVENT_SIGNAL_LOCK = 1,
    BDA_EVENT_DATA_START = 2,
    BDA_EVENT_DATA_STOP = 3,
    BDA_EVENT_CHANNEL_ACQUIRED = 4,
    BDA_EVENT_CHANNEL_LOST = 5,
    BDA_EVENT_CHANNEL_SOURCE_CHANGED = 6,
    BDA_EVENT_CHANNEL_ACTIVATED = 7,
    BDA_EVENT_CHANNEL_DEACTIVATED = 8,
    BDA_EVENT_SUBCHANNEL_ACQUIRED = 9,
    BDA_EVENT_SUBCHANNEL_LOST = 10,
    BDA_EVENT_SUBCHANNEL_SOURCE_CHANGED = 11,
    BDA_EVENT_SUBCHANNEL_ACTIVATED = 12,
    BDA_EVENT_SUBCHANNEL_DEACTIVATED = 13,
    BDA_EVENT_ACCESS_GRANTED = 14,
    BDA_EVENT_ACCESS_DENIED = 15,
    BDA_EVENT_OFFER_EXTENDED = 16,
    BDA_EVENT_PURCHASE_COMPLETED = 17,
    BDA_EVENT_SMART_CARD_INSERTED = 18,
    BDA_EVENT_SMART_CARD_REMOVED = 19,
}
