using MusicApp.Infrastructure;

namespace MusicApp.Tests
{
    public abstract class DataSeeder<T> where T : class
    {
        public abstract Task<MusicAppDbContext> ArrangeDbContext();

        protected MusicAppDbContext BuildDbContext()
        {
            throw new NotImplementedException();
        }
    }
}
