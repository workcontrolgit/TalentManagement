
namespace TalentManagement.Application.Filters
{
    public class QueryParameter : PagingParameter
    {
        public virtual string OrderBy { get; set; }
        public virtual string Fields { get; set; }

    }
}
