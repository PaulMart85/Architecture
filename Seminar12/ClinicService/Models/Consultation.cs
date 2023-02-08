namespace ClinicService.Models
{
    public class Consultation
    {
        public Consultation() { }

        public Consultation(int consultationId, int clientId, int petId, DateTime consultationDate, string description)
        {
            ConsultationId = consultationId;
            ClientId = clientId;
            PetId = petId;
            ConsultationDate = consultationDate;
            Description = description;
        }

        public int ConsultationId { get; set; }

        public int ClientId { get; set; }


        public int PetId { get; set; }

        public DateTime ConsultationDate { get; set; }

        public string Description { get; set; }
    }
}
