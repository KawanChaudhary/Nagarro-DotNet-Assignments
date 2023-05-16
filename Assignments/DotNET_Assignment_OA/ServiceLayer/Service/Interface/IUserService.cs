namespace ServiceLayer.Service.Interface
{
    public interface IUserService
    {
        string FirsTName();
        string GetEmail();
        string GetUserId();
        bool IsAdmin();
        bool IsAuthenticated();
        string LastName();
    }
}