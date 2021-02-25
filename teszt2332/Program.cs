using System;

namespace teszt2332
{
    class Program
    {
        static void Main(string[] args)
        {
            emberOsztaly[] emberek = new emberOsztaly[6];
            emberek[0] = new emberOsztaly("Teszt Géza János József", 13, 181, "A-", 101.6);
            emberek[1] = new emberOsztaly("Teszt Béla", 20, 145, "A+", 73.2);
            emberek[2] = new emberOsztaly("Magas Géza", 25, 210, "0-", 81.2);
            emberek[3] = new emberOsztaly("Kis Árpád", 15, 176, "AB+", 76.4);
            emberek[4] = new emberOsztaly("Nagy Tamás", 42, 185, "B-", 122.9);
            emberek[5] = new emberOsztaly("Beviz Elek", 54, 170, "0+", 63.2, "kék");

            //int korhatar = 23;

            //emberek[4].pluszegyev();
            //emberek[4].pluszegyev();

            for (int i = 0; i < emberek.Length; i++)
            {
                //if (emberek[i].ketkorKozott(0, 15))
                //{
                //    emberek[i].pluszegyev();
                //}
                //if (emberek[i].konyebbNehezebb(70, 100))
                //{
                Console.WriteLine(emberek[i].ToString());
                //}
                //emberek[i].pluszegyevAkicsiknek();
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
        private string szemszin = "barna";

        public emberOsztaly(string nev, int kor, double magassag, string vercsoport, double suly)
        {
            setTulajdonsagok(nev, kor, magassag, vercsoport, suly, szemszin);
        }

        public emberOsztaly(string nev, int kor, double magassag, string vercsoport, double suly, string szemszin)
        {
            setTulajdonsagok(nev, kor, magassag, vercsoport, suly, szemszin);

        }

        private void setTulajdonsagok(string nev, int kor, double magassag, string vercsoport, double suly, string szemszin)
        {
            this.nev = nev;
            this.kor = kor;
            this.magassag = magassag;
            this.vercsoport = vercsoport;
            this.suly = suly;
            this.BMI = suly / ((magassag / 100) * (magassag / 100));
            this.szemszin = szemszin;
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

        public void pluszegyevAkicsiknek()
        {
            if (this.kor <= 15)
            {
                pluszegyev();
                //kor = kor + 1;
            }
        }

        public bool ketkorKozott(int kormin, int kormax)
        {
            if (this.kor >= kormin & this.kor <= kormax)
                return true;
            else
                return false;
        }

        public bool konnyebbmint(double suly)
        {
            return this.suly < suly;
        }

        public bool nehezebbmint(double suly)
        {
            return !konnyebbmint(suly);
        }

        public bool idosebbMint(int kor)
        {
            return ketkorKozott(kor, 999);
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

            if (ketkorKozott(0, 20))
            {
                tmp += "Fiatal";
            }

            if (ketkorKozott(50, 999))
            {
                tmp += "Idős";
            }

            return tmp;
        }
    }
}
