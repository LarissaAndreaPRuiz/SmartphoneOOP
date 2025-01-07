namespace ChallengeOOP.Models
{
    public abstract class Smartphone
    {
        public string PhoneNumber { get; set; }
        public string Model { get; set; }
        public string IMEI { get; set; }
        public int Memory { get; set; }

        public Smartphone(string phoneNumber, string model, string imei, int memory)
        {
            PhoneNumber = phoneNumber;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }

        public void MakeCall()
        {
            Console.WriteLine("Making a call...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving a call...");
        }

        public abstract void InstallApp(string appName);
    }
}