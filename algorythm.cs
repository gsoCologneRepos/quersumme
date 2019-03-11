using System;
using System.Linq;

namespace Anw{
    class algorythm{
        public static int crossSum(int i){
            int summe = 0;
            string zahl =i.ToString();
            var temp = zahl.Select(x => x.ToString()).ToArray();
            var temp2 = zahl.Select(x => Convert.ToInt32(x)).Sum();

            try{
                for(int j = 0; j <temp.Length ; j++){
                    summe += Convert.ToInt32(temp[j]);
                }

            }
            catch(ArgumentOutOfRangeException e){
                Console.WriteLine(e);
                Console.WriteLine("---------------------");
                Console.WriteLine("A critical Error Accoured, out of bounce.");
            }
            
            return summe;
        }
    }
}