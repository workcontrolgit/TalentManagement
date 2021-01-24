using System;
using TalentManagement.Application.Interfaces;

namespace TalentManagement.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
