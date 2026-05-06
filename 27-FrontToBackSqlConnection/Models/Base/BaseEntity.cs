namespace _27_FrontToBackSqlConnection.Models.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CretedAt { get; set; }
    }
}
