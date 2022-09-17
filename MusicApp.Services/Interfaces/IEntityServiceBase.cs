namespace MusicApp.Services.Interfaces
{
    public interface IEntityServiceBase<T> where T : class
    {
        Task<int> Delete(int? id);
        Task<T> GetById(int? id);
    }
}