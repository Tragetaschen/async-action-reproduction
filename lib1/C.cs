using System.Threading;
using System.Threading.Tasks;

namespace lib1
{
    public class C
    {
        public async Task M(CancellationToken token) => await token;
    }
}
