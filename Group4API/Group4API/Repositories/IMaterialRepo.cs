// Made By Nabeel

using Group4API.Models;

namespace Group4API.Repositories
{
    public interface IMaterialRepo
    {
        Material CreateMaterial(Material material);

        IEnumerable<Material> GetMaterials();

        Material GetMaterialById(int id);

        Material EditMaterial(Material Material);

        void DeleteMaterial(Material material);
    }
}
