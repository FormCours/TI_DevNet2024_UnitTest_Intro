using Demo_Test_01.CustomExceptions;

namespace Demo_Test_01.Utils
{
    public static class MathUtils
    {
        public static int Addition(int nb1, int nb2)
        {
            try
            {
                return checked(nb1 + nb2);
            }
            catch
            {
                throw new MathUtilsException();
            }
        }
        public static int Addition(int nb1, int nb2, params int[] nbs)
        {
            int resultat = Addition(nb1, nb2);

            foreach (int val in nbs)
            {
                resultat = Addition(resultat, val);
            }

            return resultat;
        }
        public static double Addition(double nb1, double nb2) 
        {
            
            return Math.Round(nb1 + nb2 , 5);
        }
        public static double Addition(double nb1, double nb2, params double[] nbs)
        {
            double resultat = Addition(nb1, nb2);

            foreach (double val in nbs)
            {
                resultat = Addition(resultat, val);
            }
            return resultat;
        }

        public static int Soustraction(int nb1, int nb2)
        {
            throw new NotImplementedException();
        }
        public static int Soustraction(int nb1, int nb2, params int[] nbs)
        {
            throw new NotImplementedException();
        }
        public static double Soustraction(double nb1, double nb2)
        {
            throw new NotImplementedException();
        }
        public static double Soustraction(double nb1, double nb2, params double[] nbs)
        {
            throw new NotImplementedException();
        }

        public static int Multiplication(int nb1, int nb2)
        {
            throw new NotImplementedException();
        }
        public static double Multiplication(double nb1, double nb2)
        {
            throw new NotImplementedException();
        }

        public static int Division(int nb1, int nb2)
        {
            throw new NotImplementedException();
        }
        public static double Division(double nb1, double nb2)
        {
            throw new NotImplementedException();
        }
    }
}
