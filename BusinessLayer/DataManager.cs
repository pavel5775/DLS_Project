using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;

namespace BusinessLayer
{
    public class DataManager
    {
        private IDirectoriesRepository _dirRepos;
        private IMaterialsRepository _matRepos;

        public DataManager (IDirectoriesRepository dirRepos, IMaterialsRepository matRepos)
        {
            _dirRepos = dirRepos;
            _matRepos = matRepos;
        }
        public IDirectoriesRepository /*Directories*/ DirRepos {
            get { return _dirRepos; } 
        }

        public IMaterialsRepository /*Materials*/ MatRepos
        {
            get { return _matRepos; }
        }
    }
}
