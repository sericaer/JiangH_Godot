using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiangHKernels
{
    public class Facade : Godot.Object
    {
        public Person player;

        public Facade()
        {
            player = new Person();
            player.name = "测试";
        }

        public void Changed()
        {
            player = new Person();
            player.name = "测试2";
        }
    }

    public class Person : Godot.Object
    {
        public string name;
    }
}
