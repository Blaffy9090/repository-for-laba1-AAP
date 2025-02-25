namespace WebApplication1.Models
{
    public class Prepod
    {
        public int PrepodId { get; set; }

        public string FirstName { get; set;}

        public string LastName { get; set;}

        public string MiddleName { get; set;}

        public int CafedraId {  get; set; }
        
        public Cafedra Cafedra { get; set; }
    }
}
