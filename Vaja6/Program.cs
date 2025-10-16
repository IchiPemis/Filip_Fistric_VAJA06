using System.IO;

namespace vaja6 {

    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

    class Igralec {
        private int id;
        private string u_ime;
        private string u_geslo;
        private static int stIg = 1;

        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }
        //vrne id
        public int Id {
            get
            {
                return id;
            }
        }
        //vrne ime in odstrani space pri spremem
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }
        //vrne geslo in odstrani space pri spremem
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }
        //vrne stIg?
        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {
//aaaaaaaaaaaa
        }
    }
}
