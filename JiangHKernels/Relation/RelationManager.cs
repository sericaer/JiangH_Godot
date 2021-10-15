using JiangHKernels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiangHKernels.Relations
{
    class RelationManager
    {
        public List<Relation> all = new List<Relation>();

        public Dictionary<IEntity, List<Relation>> dict = new Dictionary<IEntity, List<Relation>>();

        internal void Add(IEntity p1, IEntity p2)
        {
            var relation = new Relation(p1, p2);
            all.Add(relation);

            if(!dict.ContainsKey(p1))
            {
                dict.Add(p1, new List<Relation>());
            }
            dict[p1].Add(relation);

            if (!dict.ContainsKey(p2))
            {
                dict.Add(p2, new List<Relation>());
            }
            dict[p2].Add(relation);
        }

        internal IEnumerable<Relation> Find(IEntity entity)
        {
            if(!dict.ContainsKey(entity))
            {
                return Relation.EmptyEnum;
            }

            return dict[entity];
        }
    }

    public class Relation
    {
        public static IEnumerable<Relation> EmptyEnum = new Relation[] { };

        public readonly IEntity p1;
        public readonly IEntity p2;

        public Relation(IEntity p1, IEntity p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
    }
}
