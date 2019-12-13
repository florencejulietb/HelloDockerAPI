using System;

namespace HelloDockerAPI
{
    public class HelloDockerService
    {
        public string SayHello(string inputMsg)
        {
            return "Welcome " + inputMsg;
        }
    }
}
