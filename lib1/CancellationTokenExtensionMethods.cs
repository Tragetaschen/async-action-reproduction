using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace lib1
{
    public static class CancellationTokenExtensionMethods
    {
        public static CancellationTokenAwaiter GetAwaiter(this CancellationToken cancellationToken)
            => new CancellationTokenAwaiter(cancellationToken);

        public struct CancellationTokenAwaiter : INotifyCompletion
        {
            private readonly CancellationToken cancellationToken;

            public CancellationTokenAwaiter(CancellationToken cancellationToken)
                => this.cancellationToken = cancellationToken;

            public bool IsCompleted => cancellationToken.IsCancellationRequested;

            public void OnCompleted(Action continuation) => cancellationToken.Register(continuation);

            public void GetResult() => cancellationToken.WaitHandle.WaitOne();
        }
    }
}
