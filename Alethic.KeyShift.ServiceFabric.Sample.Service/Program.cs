﻿using System.Threading;
using System.Threading.Tasks;

using Microsoft.ServiceFabric.Services.Runtime;

namespace Alethic.KeyShift.ServiceFabric.Sample.Service
{

    public static class Program
    {
        
        public static Task Main(string[] args)
        {
            ServiceRuntime.RegisterServiceAsync("Alethic.KeyShift.ServiceFabric.Sample.Service", ctx => new SampleService(ctx));
            return Task.Delay(Timeout.Infinite);
        }

    }

}
