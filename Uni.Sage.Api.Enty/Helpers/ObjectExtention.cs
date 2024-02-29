using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Uni.Sage.Api.Enty
{
    public static class ObjectExtention
    {
        public static string ToJson(this object obj) => JsonSerializer.Serialize(obj);
    }
}
