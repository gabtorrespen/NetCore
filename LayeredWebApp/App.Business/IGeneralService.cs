using App.Transversal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Business
{
    public interface IGeneralService
    {
        public IEnumerable<GeneralModel> GetGenerals(string filterName = null);
        public GeneralModel GetGeneral(int id);
        public int CreateGeneral(GeneralModel value);
        public int UpdateGeneral(int id, GeneralModel value);
        public int DeleteGeneral(int id);
    }
}
