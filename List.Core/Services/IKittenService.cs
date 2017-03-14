using List.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Core.Services
{
    public interface IKittenService
    {
        Kitten CreateKitten(string extra = "");
    }
}
