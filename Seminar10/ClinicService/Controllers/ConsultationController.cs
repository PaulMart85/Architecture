using ClinicService.Models.Requests;
using ClinicService.Models;
using ClinicService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationController : ControllerBase
    {
        private IConsultationRepository _consultRepository;

        public ConsultationController(IConsultationRepository consultRepository)
        {
            _consultRepository = consultRepository;
        }

        [HttpPost("create")]
        public ActionResult<int> Create([FromBody] CreateConsultRequest createConsultRequest)
        {
            Consultation consult = new Consultation();
            consult.ClientId = createConsultRequest.ClientId;
            consult.PetId = createConsultRequest.PetId;
            consult.ConsultationDate = createConsultRequest.ConsultationDate;
            consult.Description = createConsultRequest.Description;
            int res = _consultRepository.Create(consult);
            return Ok(res);
        }

        [HttpPut("update")]
        public ActionResult<int> Update([FromBody] UpdateConsultRequest updateConsultRequest)
        {
            Consultation consult = new Consultation();
            consult.ConsultationId = updateConsultRequest.ConsultationId;
            consult.ClientId = updateConsultRequest.ClientId;
            consult.PetId = updateConsultRequest.PetId;
            consult.ConsultationDate = updateConsultRequest.ConsultationDate;
            consult.Description = updateConsultRequest.Description;
            int res = _consultRepository.Update(consult);
            return Ok(res);
        }


        [HttpDelete("delete")]
        public ActionResult<int> Delete([FromQuery] int consultId)
        {
            int res = _consultRepository.Delete(consultId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public ActionResult<IList<Consultation>> GetAll()
        {
            IList<Consultation> consults = _consultRepository.GetAll();
            return Ok(consults);
        }

        [HttpGet("get-by-id/{consultId}")]
        public ActionResult<Consultation> GetById([FromRoute] int consultId)
        {
            Consultation consult = _consultRepository.GetById(consultId);
            return Ok(consult);
        }

    }
}
