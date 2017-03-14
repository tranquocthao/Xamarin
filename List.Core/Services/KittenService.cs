using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List.Services;

namespace List.Core.Services
{
    public class KittenService : IKittenService
    {
        public Kitten CreateKitten(string extra = "")
        {
            return new Kitten()
            {
                Number = "mot" + extra
            };
        }
    }
}
