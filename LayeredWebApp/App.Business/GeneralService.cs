using App.Data;
using App.Data.Models;
using App.Transversal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace App.Business
{
    public class GeneralService : IGeneralService
    {
        GenericRepository<General> generalRepository;

        public GeneralService(GenericRepository<General> generalRepository)
        {
            this.generalRepository = generalRepository;
        }

        public GeneralModel GetGeneral(int id)
        {
            General general = generalRepository.GetByID(id);
            
            return general==null?new GeneralModel():new GeneralModel
            {
                Id = general.Id,
                Name = general.Name,
                Description = general.Description
            };
        }

        public IEnumerable<GeneralModel> GetGenerals(string filterName = null)
        {
            return generalRepository.Get(general => general.Name == (filterName??general.Name)).Select(general => new GeneralModel
            {
                Id = general.Id,
                Name = general.Name,
                Description = general.Description
            });
        }

        public int CreateGeneral(GeneralModel value)
        {
            generalRepository.Insert(new General
            {
                Id = value.Id,
                Description = value.Description,
                Name = value.Name
            });

            return generalRepository.Save();
        }

        public int UpdateGeneral(int id, GeneralModel value)
        {
            generalRepository.Update(id,new General
            {
                Id = id,
                Description = value.Description,
                Name = value.Name
            });

            return generalRepository.Save();
        }

        public int DeleteGeneral(int id)
        {
            generalRepository.Delete(id);

            return generalRepository.Save();
        }
    }
}
