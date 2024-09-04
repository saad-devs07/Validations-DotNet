namespace Validations.Models
{
    public enum Smonth
    {
        Jan,Feb,Mar,Apr,May,June,July,Aug,Sept,Oct,Nov,Dec
    }
    public class Fees
    {
        public int Id { get; set; }
        public Smonth smonth { get; set; }
        public int SAmount { get; set; }
        public DateTime SDate { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
