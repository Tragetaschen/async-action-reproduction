using System; // this is the culprit
using System.Threading;
using System.Threading.Tasks;
using lib1;

namespace lib2
{
    public class C
    {
        public async Task M(CancellationToken token) => await token;
    }
}
