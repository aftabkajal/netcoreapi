using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreApi.Core.SharedKernel
{
   public abstract class IEntity
    {
        public Guid Id { get; set; }
    }
}
