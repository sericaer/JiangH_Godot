using System;
using System.Linq;
using System.Collections.Generic;
using JiangHKernels.Interfaces;

namespace JiangHKernels.Entitys
{
    public class EntityManager
    {
        public Dictionary<Type, List<IEntity>> itf2Entitys;
        public Dictionary<Type, List<IEntity>> com2Entitys;

        private List<IEntity> all;

        public IEnumerable<T> GetEntitysByInterface<T>() where T : GMInterface
        {
            var type = typeof(T);
            if (!itf2Entitys.ContainsKey(type))
            {
                itf2Entitys.Add(type, new List<IEntity>());
            }

            return itf2Entitys[type].Select(x => (T)x);
        }

        public EntityManager()
        {
            all = new List<IEntity>();

            itf2Entitys = new Dictionary<Type, List<IEntity>>();
            com2Entitys = new Dictionary<Type, List<IEntity>>();
            
        }

        internal void Build()
        {

        }
        public void AddEntity(IEntity entity)
        {
            all.Add(entity);

            var entityType = entity.GetType();
            var gmInterfaceType = entityType.GetInterfaces().SingleOrDefault(x => (typeof(GMInterface)).IsAssignableFrom(x) && x != typeof(GMInterface));
            if(gmInterfaceType != null)
            {
                if(!itf2Entitys.ContainsKey(gmInterfaceType))
                {
                    itf2Entitys.Add(gmInterfaceType, new List<IEntity>());
                }

                itf2Entitys[gmInterfaceType].Add(entity);
            }

            //foreach(var component in entity.GetComponents())
            //{
            //    var componentType = component.GetType();
            //    if(!com2Entitys.ContainsKey(componentType))
            //    {
            //        com2Entitys.Add(componentType, new List<IEntity>());
            //    }

            //    com2Entitys[componentType].Add(entity);
            //}

            //entity.OnAddComponent = (component) =>
            //{
            //    var componentType = component.GetType();
            //    if (!com2Entitys.ContainsKey(componentType))
            //    {
            //        com2Entitys.Add(componentType, new List<IEntity>());
            //    }

            //    com2Entitys[componentType].Add(entity);
            //};

            //entity.OnRemoveComponent = (component) =>
            //{
            //    var componentType = component.GetType();
            //    if (com2Entitys.ContainsKey(componentType))
            //    {
            //        com2Entitys[componentType].Remove(entity);
            //    }
            //};
        }
    }
}