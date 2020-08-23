using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.Core.Util.IOC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection services);
    }
}
