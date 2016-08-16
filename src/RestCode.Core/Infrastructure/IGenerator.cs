using System.Threading.Tasks;

namespace RestCode.Core.Infrastructure
{
    public interface IGenerator
    {
        Task<string> Process();
    }
}
