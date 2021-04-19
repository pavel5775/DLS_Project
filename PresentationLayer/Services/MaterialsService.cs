using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using BusinessLayer;
using PresentationLayer.ViewModels;

namespace PresentationLayer.Services
{
    public class MaterialsService
    {
        private DataManager _dataManager;
        public MaterialsService (DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public MaterialViewModel TransitMaterialToView(int materialId)
        {
            var vm = new MaterialViewModel()
            {
                Material = _dataManager.MatRepos.GetMaterialById(materialId)
            };

            var dir_id = vm.Material.DirectoryId;
            vm.DirectoryId = dir_id;
            var dir = _dataManager.DirRepos.GetDirectoryById(dir_id, true);            

            var current = dir.Materials.FirstOrDefault(x => x.Id==vm.Material.Id);
            var current_index = dir.Materials.IndexOf(current);
            var N = dir.Materials.Count();
            if (current_index!=0)
                vm.PrevMaterial = dir.Materials[current_index - 1];
            if (current_index != N-1)
                vm.NextMaterial = dir.Materials[current_index + 1];

            return vm;
        }

        public MaterialViewModel SaveMaterialToDb (MaterialViewModel vm)
        {
            Material material = null;

            if (vm.Id != 0)
                material = _dataManager.MatRepos.GetMaterialById(vm.Id);
            else
                material = new Material();

            material.Title = vm.Title;
            material.Html = vm.Html;
            material.DirectoryId = vm.DirectoryId;

            _dataManager.MatRepos.SaveMaterial(material);

            return TransitMaterialToView(material.Id);
        }        

    }
}
