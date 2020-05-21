namespace Core.Domain.Models
{
    public class BaseDto<T> where T : struct
    {
        public T Id { get; set; }
    }
}