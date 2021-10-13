using System;
using System.Collections.Generic;

namespace JiangHKernels.Interfaces
{

    public interface IEntity
    {
        IEnumerable<T> GetComponents<T>() where T : class, IComponent;
        
        void AddComponent(IComponent component);
        void AddComponentRange(IEnumerable<IComponent> components);
        void RemoveComponent(IComponent component);
        void RemoveComponents<T>(Func<T, bool> func = null) where T : class, IComponent;

        IEnumerable<T> GetRelations<T>() where T : AbsRelation;
    }
}
