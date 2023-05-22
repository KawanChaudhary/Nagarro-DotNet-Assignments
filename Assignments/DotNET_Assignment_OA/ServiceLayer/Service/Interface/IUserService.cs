namespace ServiceLayer.Service.Interface
{
    public interface IUserService
    {
        string FirstName();
        string GetEmail();
        string GetUserId();
        bool IsAdmin();
        bool IsAuthenticated();
        string LastName();
    }
}