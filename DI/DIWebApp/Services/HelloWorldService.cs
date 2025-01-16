
namespace DIWebApp.Services
{
    //Each Service should be defined by using contract

    public interface IHelloWorldService
    {
        string SayHello();
    }

    public class HelloWorlService : IHelloWorldService
    {
        public string SayHello()
        {
            return "Welcome to transflower";
        }
    }

}