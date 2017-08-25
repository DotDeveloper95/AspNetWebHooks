﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.WebHooks.Metadata
{
    /// <summary>
    /// An <see cref="IWebHookMetadata"/> service containing metadata about the Pusher receiver.
    /// </summary>
    public class PusherMetadata : WebHookMetadata, IWebHookRequestMetadataService
    {
        /// <summary>
        /// Instantiates a new <see cref="PusherMetadata"/> instance.
        /// </summary>
        public PusherMetadata()
            : base(PusherConstants.ReceiverName)
        {
        }

        /// <inheritdoc />
        public WebHookBodyType BodyType => WebHookBodyType.Json;

        /// <inheritdoc />
        public bool UseHttpContextModelBinder => false;
    }
}
