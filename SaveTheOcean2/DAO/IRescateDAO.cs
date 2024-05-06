using SaveTheOcean2.Model;

namespace SaveTheOcean2.DAO
{
    public interface IRescateDAO
    {
        Rescate GetRescateById(int id);
        public List<Rescate> GetAllRescates();
        void AddRescate(Rescate rescate);
        void UpdateRescate(Rescate rescate);
        void DeleteRescate(int id);
    }
}
