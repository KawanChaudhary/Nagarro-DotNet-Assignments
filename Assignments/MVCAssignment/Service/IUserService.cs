namespace MVCAssignment.Service
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