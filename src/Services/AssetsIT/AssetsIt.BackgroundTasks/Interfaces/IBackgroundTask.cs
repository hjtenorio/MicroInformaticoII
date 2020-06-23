using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIt.BackgroundTasks.Interfaces
{
    public interface IBackgroundTask
    {
        Task ExecuteAsync();
    }
}
