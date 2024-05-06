using SaveTheOcean2.Model;

namespace SaveTheOcean2.DAO
{
    public interface IAnimalDAO
    {
        AAnimal GetAnimalById(int id);
        public List<AAnimal> GetAllAnimals();
        void AddAnimal(AAnimal animal);
        void UpdateAnimal(AAnimal animal);
        void DeleteAnimal(int id);
    }
}
