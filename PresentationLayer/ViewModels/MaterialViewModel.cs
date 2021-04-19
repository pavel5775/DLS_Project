using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.ViewModels
{
    public class MaterialViewModel: PageViewModel
    {
        public Material Material { get; set; }
        public Material NextMaterial { get; set; }
        public Material PrevMaterial { get; set; }
        public int DirectoryId { get; set; }        
    }
}
