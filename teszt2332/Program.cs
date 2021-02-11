using System;

namespace teszt2332
{
    class Program
    {
        static void Main(string[] args)
        {
            emberOsztaly[] emberek = new emberOsztaly[3];
            emberek[0] = new emberOsztaly("Teszt Géza János József", 32, 181, "A-", 101.6);
            emberek[1] = new emberOsztaly("Teszt Béla", 20, 145, "A+", 73.2);
            emberek[2] = new emberOsztaly("Magas Géza", 25, 210, "0-", 81.2);

            int korhatar = 23;

            for (int i = 0; i < 3; i++)
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

        public emberOsztaly(string nev, int kor, double magassag, string vercsoport, double suly)
        {
            this.nev = nev;
            this.kor = kor;
            this.magassag = magassag;
            this.vercsoport = vercsoport;
            this.suly = suly;
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

            return tmp;
        }
    }
}
