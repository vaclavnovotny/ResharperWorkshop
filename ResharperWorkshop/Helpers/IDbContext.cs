namespace ResharperWorkshop.Helpers
{
    public interface IDbContext
    {
        Task<IEnumerable<object>?> ToListAsync();
    }
}
