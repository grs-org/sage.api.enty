using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Shared.Communication
{
    public abstract class Request
    {
        public string ConnectionName { get; set; }
    }
}
