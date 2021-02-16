using System;

namespace teszt2332
{
    class Program
    {
        static void Main(string[] args)
        {
            emberOsztaly[] emberek = new emberOsztaly[5];
            emberek[0] = new emberOsztaly("Teszt Géza János József", 32, 181, "A-", 101.6);
            emberek[1] = new emberOsztaly("Teszt Béla", 20, 145, "A+", 73.2);
            emberek[2] = new emberOsztaly("Magas Géza", 25, 210, "0-", 81.2);
            emberek[3] = new emberOsztaly("Kis Árpád", 30, 176, "AB+", 76.4);
            emberek[4] = new emberOsztaly("Nagy Tamás", 42, 185, "B-", 122.9);

            int korhatar = 23;


            emberek[4].pluszegyev();
            emberek[4].pluszegyev();

            for (int i = 0; i < emberek.Length; i++)
            {
                if (emberek[i].idosebbMint(korhatar))
                {
                    Console.WriteLine(emberek[i].ToString());
                }
            }
        }
    }

    public class emberOsztaly
    {
        private string nev;
        private int kor;
        private double magassag;
        private string vercsoport;
        private double suly;
        private double BMI = -1;

        public emberOsztaly(string nev, int kor, double magassag, string vercsoport, double suly)
        {
            this.nev = nev;
            this.kor = kor;
            this.magassag = magassag;
            this.vercsoport = vercsoport;
            this.suly = suly;
            this.BMI = suly / ((magassag / 100) * (magassag / 100));
        }

        public double getBMI()
        {
            if (BMI != -1)
                return BMI;
            else
            {
                BMI = suly / ((magassag / 100) * (magassag / 100));
                return BMI;
            }
        }

        public void pluszegyev()
        {
           kor = kor + 1;
        }

        public bool ketkorKozott(int kormin, int kormax)
        {
            if (this.kor >= kormin & this.kor <= kormax)
                return true;
            else
                return false;
        }


        public emberOsztaly()
        {

        }

        public emberOsztaly(string nev)
        {
            this.nev = nev;
        }

        public bool idosebbMint(int kor)
        {
            if (this.kor >= kor)
                return true;
            else
                return false;
        }
        public bool dagibbMint(int dagi)
        {
            if (this.getBMI() > dagi)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            //Teszt Géza Benedek János
            string tmp;
            string[] nevreszek = nev.Split(' '); //nevreszek[0] = Teszt nevreszek[1] = Géza...

            tmp = nevreszek[0].ToCharArray()[0] + ". "; //[T]eszt + ". " -> "T. "

            for (int i = 1; i < nevreszek.Length; i++)
            {
                tmp += nevreszek[i] + " ";
            }

            if (dagibbMint(25)) 
            {
                tmp += "Dagi ";
            }

            return tmp;
        }
    }
}
