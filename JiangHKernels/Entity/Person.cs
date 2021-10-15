using JiangHKernels.Interfaces;
using System;
using System.Linq;

namespace JiangHKernels.Entitys
{
    public class Person : Entity, IPerson
    {
        #region("gdscript interface")

        [Obsolete("this interface used for gdscript")]
        public string full_name => fullName;

        [Obsolete("this interface used for gdscript")]
        public IBusiness[] get_businesses() => GetBusinesses();

        #endregion

        public PersonDef def => throw new NotImplementedException();

        public string fullName { get; set; }

        public int maxBusinessCount => throw new NotImplementedException();

        public ISociety society => throw new NotImplementedException();

        public Person(string name)
        {
            this.fullName = name;
        }

        public IBusiness[] GetBusinesses()
        {
            return GetRelations().Where(x => x.p2 is Business).Select(x=>x.p2 as Business).ToArray();
        }
    }
}