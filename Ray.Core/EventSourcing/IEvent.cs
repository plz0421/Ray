﻿using Ray.Core.Message;
using System;

namespace Ray.Core.EventSourcing
{
    public interface IEvent : IMessage
    {
        string Id { get; set; }
        Int64 Version { get; set; }
        string TraceId { get; set; }
        DateTime Timestamp { get; set; }
    }

    public interface IEventBase<K> : IEvent, IActorOwnMessage<K>
    {
    }
}
