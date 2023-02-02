namespace ClinicService.Models.Requests
{
    public class CreateConsultRequest
    {

        public int ClientId { get; set; }

        public int PetId { get; set; }

        public DateTime ConsultationDate { get; set; }

        public string Description { get; set; }
    }
}
