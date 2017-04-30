namespace Blog.DAL.Model
{
    public interface IStatus
    {
        bool IsActive { get; set; }
        bool IsDeleted { get; set; } 
    }
}