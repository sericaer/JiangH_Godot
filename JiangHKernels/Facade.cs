using JiangHKernels.Entitys;
using JiangHKernels.Interfaces;
using JiangHKernels.Relations;
using JiangHKernels.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiangHKernels
{
    public class Facade : Godot.Object
    {
        public IPerson player;
        public IEnumerable<IPerson> persons => entityMgr.GetEntitysByInterface<IPerson>();

        public EntityManager entityMgr;

        RelationManager relationMgr;

        public Facade()
        {
            Entity.funcGetRelations = (entity) =>
            {
                return relationMgr.Find(entity);
            };

            entityMgr = new EntityManager();
            relationMgr = new RelationManager();

            entityMgr.AddEntity(new Person("测试"));
            entityMgr.AddEntity(new Person("测试2"));

            entityMgr.AddEntity(new Business());
            entityMgr.AddEntity(new Business());
            entityMgr.AddEntity(new Business());
            entityMgr.AddEntity(new Business());
            entityMgr.AddEntity(new Business());

            IEnumerable<IBusiness> businesses = entityMgr.GetEntitysByInterface<IBusiness>();
            relationMgr.Add(persons.First(), businesses.Last());

            player = persons.First();
        }

        public void Changed()
        {
            player = persons.Last();
        }
    }

    //public class Person : EntityElement
    //{
    //    public string name;
    //    public int businessCount { get; private set; }

    //    public Person()
    //    {
    //        businessCount = 12;
    //    }
    //}
}
