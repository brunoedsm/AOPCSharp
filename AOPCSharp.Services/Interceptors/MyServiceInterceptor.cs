//using Castle.DynamicProxy;
//using System.Diagnostics;

//namespace AOPCSharp.Services.Interceptors
//{
//    public class MyServiceInterceptor : IInterceptor
//    {
//        public void Intercept(IInvocation invocation)
//        {
//            var watch = Stopwatch.StartNew();
//            invocation.Proceed();
//            watch.Stop();
//            var elapsedMs = watch.ElapsedMilliseconds;

//            Debug.WriteLine(string.Format("ELAPSED_TIME: {0}", elapsedMs));

//        }
//    }
//}
