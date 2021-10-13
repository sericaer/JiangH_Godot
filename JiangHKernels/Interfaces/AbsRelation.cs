namespace JiangHKernels.Interfaces
{
    public abstract class AbsRelation
    {
        public readonly IEntity p1;
        public readonly IEntity p2;

        public AbsRelation(IEntity p1, IEntity p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
}
}
