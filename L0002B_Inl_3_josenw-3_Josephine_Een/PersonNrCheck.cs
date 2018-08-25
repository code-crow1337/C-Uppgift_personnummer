using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L0002B_Inl_3_josenw_3_Josephine_Een
{
    class PersonNrCheck
    {
        public int PerNrAlgoritm(int[] nummer)
        {
            int summaEven = 0;
            int summa = 0;
            int total = 0;
            int summaOdd = 0;
            int length = nummer.Length; //längd på arrayen, dvs hur många ggr man ska köra igenom den
            for (int i = 0; i < length; i++)
            {
                int siffra = nummer[i];// tar informationen som finns i position i så som 9 i position 0
                int delsiffra1 = 0; //declarerar variablerna till 0 innan de används
                int delsiffra2 = 0;
                if (i % 2 == 0) //Om postion siffran är delbart med 2 och inget finns kvar, gångra talet som finns i den positionen med 2
                {
                    int even = siffra * 2; //exempel position 0 som har information 9 blir 2*9 = 18 och läggs i variabeln even


                    if (even > 9) //om nu informationen i even är större än 9 gör följande:
                    {
                        delsiffra1 = even % 10;// delsiffra1 får den remainder efter man delat med 10. detta fall 18%10 = 8
                        delsiffra2 = even / 10; // delsiffra 2 får när man delar even i detta fall 18/10 = 1
                        summa = delsiffra1 + delsiffra2; // summan blir då i detta fall 8+1 = 9
                        summaEven = summaEven + summa; // alla lämna positioners värde läggs ihop till summaEven
                    }
                    else summaEven = summaEven + even; //körs om even visar sig vara mindre än 9


                }
                if (i % 2 == 1)//samma som ovan men ojäman positioner så som 1,3,5,7 osv
                {
                    int odd = siffra * 1; //ojämna positoners värde multipliceras med 1
                   summaOdd = summaOdd + odd; /*eftersom varje siffra i arrayen fått sin egna position så är de svårt för ett ojämnt tal som multipliceras med 1
                     attbli större än 9.*/ 

                }

            }
            total = summaOdd + summaEven; //totalen blir förstås allas positioners värde efter multipliceringen. 

            return total; //skickar tillbaka värdet där metoden kallades dvs form1 klassen


        }
        public bool Giltigt(int total) //denna boolean metod kollar om personummret är giltigt
        {
            bool resultat = false;
            if (total % 10 == 0)
            {
                resultat = true;
            }
            else resultat = false; //om falskt kommer användaren ombes att försöka igen. 
            return resultat;
        }
        public int CheckSex(int[] nummer) /*kollar könet genom att ta emot arrayen med personummret och kolla specifikt på om positon 7 som är den näst sista siffran har någon
            remainder*/
        {
            if (nummer[8] % 2 == 0) //om noll så är de en kvinna
            {
                int sex = 0;
                return sex;
            }
            else
            {
                int sex = 1;
                return sex;
            }

        }

    }
}

