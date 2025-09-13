namespace Application.Interfaces
{
    public interface IEmailService
    {
        Task<bool> SendEmail();
    }
}
