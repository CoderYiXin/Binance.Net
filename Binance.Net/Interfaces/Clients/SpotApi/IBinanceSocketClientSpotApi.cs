﻿using CryptoExchange.Net.Authentication;

namespace Binance.Net.Interfaces.Clients.SpotApi
{
    /// <summary>
    /// Spot API socket subscriptions and requests
    /// </summary>
    public interface IBinanceSocketClientSpotApi
    {
        /// <summary>
        /// Account streams and queries
        /// </summary>
        IBinanceSocketClientSpotApiAccount Account { get; }
        /// <summary>
        /// Exchange data streams and queries
        /// </summary>
        IBinanceSocketClientSpotApiExchangeData ExchangeData { get; }
        /// <summary>
        /// Trading data and queries
        /// </summary>
        IBinanceSocketClientSpotApiTrading Trading { get; }
        /// <summary>
        /// Set the API credentials for this API
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="credentials"></param>
        void SetApiCredentials<T>(T credentials) where T : ApiCredentials;
    }
}