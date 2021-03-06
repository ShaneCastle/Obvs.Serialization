﻿using Obvs.Configuration;

namespace Obvs.Serialization.ProtoBuf.Configuration
{
    public static class FluentConfigExtensions
    {
        public static ICanCreateEndpointAsClientOrServer<TMessage, TCommand, TEvent, TRequest, TResponse> SerializedAsProtoBuf<TMessage, TCommand, TEvent, TRequest, TResponse>(this ICanSpecifyEndpointSerializers<TMessage, TCommand, TEvent, TRequest, TResponse> config)
            where TMessage : class
            where TCommand : class, TMessage
            where TEvent : class, TMessage
            where TRequest : class, TMessage
            where TResponse : class, TMessage
        {
            return config.SerializedWith(new ProtoBufMessageSerializer(), new ProtoBufMessageDeserializerFactory());
        }
    }
}