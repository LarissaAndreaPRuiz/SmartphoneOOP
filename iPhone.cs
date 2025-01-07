namespace ChallengeOOP.Models
{

    public class iPhone : Smartphone
    {
        public iPhone(string phoneNumber, string model, string imei, int memory) : base(phoneNumber, model, imei, memory)
        {
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing app {appName}...");
        }
    }
}
