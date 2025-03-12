namespace Mission10_Linde.Data
{
    public interface EfBowlerRepository : IBowlerRepository
    {
        private readonly BowlersContext _bowlersContext;
        public EfBowlerRepository(BowlersContext temp)
        {
            _bowlersContext = temp;
        }
        public List<Bowler> Bowlers => _bowlersContext.Bowlers.ToList();
    }
}
