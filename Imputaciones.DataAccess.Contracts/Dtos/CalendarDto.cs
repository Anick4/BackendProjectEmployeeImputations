namespace Imputaciones.DataAccess.Contracts.Dtos
{
    public class CalendarDto
    {
        public int Calendar_Id { get; set; }
        public int Daily_Hours { get; set; }
        public Boolean Monday { get; set; }
        public Boolean Tuesday { get; set; }
        public Boolean Wednesday { get; set; }
        public Boolean Thursday { get; set; }
        public Boolean Friday { get; set; }
        public Boolean Saturday { get; set; }
        public Boolean Sunday { get; set; }
    }
}
