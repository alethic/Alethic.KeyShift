﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Alethic.KeyShift
{

    /// <summary>
    /// Describes an interface to a remote <see cref="KsHost{TKey}"/> instance.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IKsHostClient<TKey>
    {

        /// <summary>
        /// Selects the data from the remote client.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="token"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<KsHostShiftLockResult> GetAsync(TKey key, string token, CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes the data from the remote client.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="token"></param>
        /// <param name="forward"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task ForwardAsync(TKey key, string token, Uri forward, CancellationToken cancellationToken = default);

    }

}
