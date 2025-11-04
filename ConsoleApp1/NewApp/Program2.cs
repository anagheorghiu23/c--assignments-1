namespace MediaItemApp
{
    class GravityCalculator()
    {
        private string usedObject;
        private double g = 9.81;
        private double m;
        private double G;
        DateTime parsedTime;

        private void ReadObjectName()
        {
            Console.Write("What is the object you want to test?");
            Console.WriteLine();
            usedObject = Console.ReadLine();
        }

        private void ReadMass()
        {
            Console.Write("What is the " + usedObject + "'s mass? (in grams)");
            Console.WriteLine();
            string textValue = Console.ReadLine();
            m = int.Parse(textValue);
        }

        private void ReadDate()
        {
            Console.Write("When are you doing the experiment?");
            Console.WriteLine();
            string response = Console.ReadLine();
            parsedTime = DateTime.Parse(response);
        }

        private void CalculateGravity()
        {
            G = m * g;
        }
        public void ReadAndSaveExperimentData()
        {
            ReadObjectName();
            ReadMass();
            ReadDate();
            CalculateGravity();
        }

        public void DisplayExperimentInfo()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++");


            Console.WriteLine("Object: " + usedObject);
            Console.WriteLine("Mass: " + m);
            Console.WriteLine("Date of the Experiment: " + parsedTime);
            Console.WriteLine("Calculated Force of Gravity: " + G);

            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
 class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the Pet Program!");
            Console.WriteLine();
        }

        private void ReadName()
        {
            Console.Write("What is the name of your pet?");
            name = Console.ReadLine();
        }

        private void ReadAge()
        {
            Console.Write("What is " + name + "'s age?");
            string textValue = Console.ReadLine();
            age = int.Parse(textValue);
        }

        private void ReadGender()
        {
            Console.Write("Is " + name + " female? (y/n)?");
            string strGender = Console.ReadLine();
            char response = strGender[0];
            if ((response == 'y') || (response == 'Y'))
                isFemale = true;
            else
                isFemale = false;
        }
        public void ReadAndSavePetData()
        {
            ReadName();
            ReadAge();
            ReadGender();
        }

        public void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++");

            string textOut = "Name: " + name + " Age: " + age;
            Console.WriteLine(textOut);
            if (isFemale == true)
                Console.WriteLine(name + ": She's such a wonderful pup!");
            else
                Console.WriteLine(name + ": He's such a wonderful pup!");

            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
    class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine();
        }
        private void ReadAlbumName()
        {
            Console.Write("What is the name of your favorite album?");
            albumName = Console.ReadLine();
        }

        private void ReadArtistName()
        {
            Console.Write("What is the name of Artist or Band for " + albumName + " ?");
            artistName = Console.ReadLine();
        }
        private void ReadNumOfTracks()
        {
            Console.Write("How many tracks does " + albumName + " have?");
            string textValue = Console.ReadLine();
            numOfTracks = int.Parse(textValue);
        }

        public void ReadAndSaveAlbumData()
        {
            ReadAlbumName();
            ReadArtistName();
            ReadNumOfTracks();
        }

        public void DisplayAlbumInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Album Name: " + albumName);
            Console.WriteLine("Arist/Band: " + artistName);
            Console.WriteLine("Number of Tracks: " + numOfTracks);
            Console.WriteLine();
        }

    }


    class TicketSeller
    {
        private string name;
        private double price = 99;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the TicketSeller Program!");
            Console.WriteLine();
        }

        private void ReadName()
        {
            Console.Write("What movie are you going to?");
            name = Console.ReadLine();
        }
        private void ReadNumOfAdults()
        {
            Console.Write("How many adult tickets?");
            string textValue = Console.ReadLine();
            numOfAdults = int.Parse(textValue);
        }
        private void ReadNumOfChildren()
        {
            Console.Write("How many children tickets?");
            string textValue = Console.ReadLine();
            numOfChildren = int.Parse(textValue);
        }
        private void CalculateTicketPrice()
        {
            amountToPay = numOfAdults * price + numOfChildren * (price * 0.25);
        }
        public void ReadAndSaveTicketData()
        {
            ReadName();
            ReadNumOfAdults();
            ReadNumOfChildren();
            CalculateTicketPrice();
        }

        public void DisplayTicketInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Movie: " + name);
            Console.WriteLine("Number of Adult tickets: " + numOfAdults);
            Console.WriteLine("Number of Children tickes: " + numOfChildren);
            Console.WriteLine("Price to pay: " + amountToPay);
            Console.WriteLine();
        }


    }





    class Program
    {
        static void Main(string[] args)
        {
            PrepareConsolesLook();

            Pet petObj = new Pet();
            petObj.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            petObj.ReadAndSavePetData();
            petObj.DisplayPetInfo();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            Album albumObj = new Album();
            albumObj.Start();
            albumObj.ReadAndSaveAlbumData();
            albumObj.DisplayAlbumInfo();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            TicketSeller ticketObj = new TicketSeller();
            ticketObj.Start();
            ticketObj.ReadAndSaveTicketData();
            ticketObj.DisplayTicketInfo();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();



            GravityCalculator experiment = new GravityCalculator();
            experiment.ReadAndSaveExperimentData();
            experiment.DisplayExperimentInfo();

            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();


        }
        static void PrepareConsolesLook()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
