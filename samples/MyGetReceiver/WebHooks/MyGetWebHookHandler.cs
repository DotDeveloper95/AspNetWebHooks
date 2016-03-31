﻿using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;
using Microsoft.AspNet.WebHooks.Payloads;

namespace MyGetReceiver.WebHooks
{
    public class MyGetWebHookHandler : MyGetWebHookHandlerBase
    {
        /// <summary>
        /// We use <see cref="MyGetWebHookHandlerBase"/> so just have to override the methods we want to process WebHooks for.
        /// This one processes the <see cref="PackageAddedPayload"/> WebHook.
        /// </summary>
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context, PackageAddedPayload payload)
        {
            return Task.FromResult(true);
        }

        /// <summary>
        /// This one processes the <see cref="PackageDeletedPayload"/> WebHook.
        /// </summary>
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context, PackageDeletedPayload payload)
        {
            return Task.FromResult(true);
        }
    }
}
