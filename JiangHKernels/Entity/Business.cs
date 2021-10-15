using JiangHKernels.Interfaces;
using System;
using System.Collections.Generic;

namespace JiangHKernels.Entitys
{
    public class Business : Entity, IBusiness
    {
        public string name => throw new NotImplementedException();

        public ISociety society => throw new NotImplementedException();

        public IEnumerable<IProduct> productsBase => throw new NotImplementedException();

        public IEnumerable<IProduct> productsCurr => throw new NotImplementedException();

        public IEnumerable<(string desc, double value)> efficientDetail => throw new NotImplementedException();

        public Action<IComponent> OnAddComponent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Action<IComponent> OnRemoveComponent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddComponent(IComponent component)
        {
            throw new NotImplementedException();
        }

        public void AddComponentRange(IEnumerable<IComponent> components)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IComponent> GetComponents()
        {
            throw new NotImplementedException();
        }

        public void RemoveComponent(IComponent component)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IEntity.GetComponents<T>()
        {
            throw new NotImplementedException();
        }

        void IEntity.RemoveComponents<T>(Func<T, bool> func)
        {
            throw new NotImplementedException();
        }
    }
}