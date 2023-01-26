﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

namespace Microsoft.Azure.WebJobs.CosmosDb.ChangeProcessor
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IProcessor<TLease, TContinuation>
        where TLease : ILease<TContinuation>
    {
        public Task<TContinuation?> ProcessAsync(TLease lease, CancellationToken cancellationToken, Action<TimeSpan> delay, Action<TContinuation> checkpoint);
    }
}
