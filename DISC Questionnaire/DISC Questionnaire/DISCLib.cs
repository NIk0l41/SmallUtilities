using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISC_Questionnaire
{
    class DiscCalculator{

        int[] most = new int[4];
        int[] least = new int[4];
        int[] change = new int[4];

        /*public string[] Start(int[,] input) {
            int[] change = { 0, 0, 0, 0 };
            for (int i = 0; i < 4; i++) {
                most[i] = input[i, 0];
                least[i] = input[1, i];
                change[i] = most[i] - least[i];
            }
        }*/

        public int[] g1(int[] a) {
            //This was a spur of the moment code epiphany, but I'll try to explain how it works.
            int[] b = { 0,0,0,0};
            for (int i = 0; i < a.Length; i++) {
                int d = 0;
                for (int j = 0; j < a.Length; j++){
                    //Essentially, we compare every item in the array to each item.
                    //If it's bigger, then the tmp score 'd' is increased.
                    if (a[i] > a[j]) {
                        d++;
                    }
                }
                //Once a comparison is complete, the slot of the out array corresponding to the numbers 'rank' is filled with that number.
                //But we need to continue to compare numbers, so we loop it.
                b[d] = a[i];
            }
            //What's left is an array organised from smallest to largest. 'b'
            //End Epiphany.

            //But now we need to return an array that has the items that fall below the line removed.
            //Here, -1 will dictate that that slot is irrelevant to the personality output.
            if (a[0] < 7) {
                a[0] = -1;
            }
            if (a[1] < 4)
            {     
                a[1] = -1;
            }
            if (a[2] < 5)
            {
                a[2] = -1;
            }
            if (a[3] < 4)
            {
                a[3] = -1;
            }
            //Ok, now we compare array 'a' and 'b' to each other and we should have an output!
            /*string output = "";
            for (int i = 0; i < a.Length; i++) {
                if ()
            }
            switch (b[3]) {
                case a[0]:
                    output += "D";
                    break;
            }
            */
            return b;
        }


    }

    class Personality{

    }
}
