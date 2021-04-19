using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IMaterialsRepository
    {
        IEnumerable<Material> GetAllMaterials(bool includeDirectory = false);
        IEnumerable<Material> GetMaterialsByDirectory(int directoryId, bool includeDirectory = false);
        Material GetMaterialById(int materialId, bool includeDirectory = false);
        void SaveMaterial (Material material);
        void DeleteMaterial (Material material);
    }
}
