namespace WebApplication1.Models
{
    public class Cafedra
    {
        public int CafedraId { get; set; }

        public string CafedraName { get; set; }
        public int AdminId { get; set; }
        public Prepod Admin { get; internal set; }
    }
}
