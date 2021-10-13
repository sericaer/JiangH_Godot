using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiangHGodot.Mod
{
    class ModMgr
    {
        public string path { get; private set; }

        public ModItem native { get; private set; }

        public ModMgr(string path)
        {
            this.path = path;

            native = new ModItem($"{this.path}native");
            native.LoadPack();
        }
    }
}
