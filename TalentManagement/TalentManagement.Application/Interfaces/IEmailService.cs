using System.Threading.Tasks;
using TalentManagement.Application.DTOs.Email;

namespace TalentManagement.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
