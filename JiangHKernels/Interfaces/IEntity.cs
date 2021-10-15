using JiangHKernels.Relations;
using System;
using System.Collections.Generic;

namespace JiangHKernels.Interfaces
{

    public interface IEntity
    {
        Action<IComponent> OnAddComponent { get; set; }
        Action<IComponent> OnRemoveComponent { get; set; }

        IEnumerable<T> GetComponents<T>() where T : class, IComponent;
        IEnumerable<IComponent> GetComponents();
        void AddComponent(IComponent component);
        void AddComponentRange(IEnumerable<IComponent> components);
        void RemoveComponent(IComponent component);
        void RemoveComponents<T>(Func<T, bool> func = null) where T : class, IComponent;

        IEnumerable<Relations.Relation> GetRelations();
    }
}
