using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Business;
using App.Transversal.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        IGeneralService generalService;

        public GeneralController(GeneralService generalService)
        {
            this.generalService = generalService;
        }

        // GET: api/General
        [HttpGet]
        public IEnumerable<GeneralModel> Get()
        {
            List<GeneralModel> generals = generalService.GetGenerals().ToList();
            return generals;
        }

        // GET: api/General/5
        [HttpGet("{id}", Name = "Get")]
        public GeneralModel Get(int id)
        {
            GeneralModel general = generalService.GetGeneral(id);
            return general;
        }

        // POST: api/General
        [HttpPost]
        public int Post([FromBody] GeneralModel value)
        {
            return generalService.CreateGeneral(value);
        }

        // PUT: api/General/5
        [HttpPut("{id}")]
        public int Put(int id, [FromBody] GeneralModel value)
        {
            return generalService.UpdateGeneral(id,value);
        }

        // DELETE: api/General/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return generalService.DeleteGeneral(id);
        }
    }
}
