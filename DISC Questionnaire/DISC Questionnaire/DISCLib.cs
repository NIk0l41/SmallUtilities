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

        public string[] Start(int[,] input) {
            int[] change = { 0, 0, 0, 0 };
            for (int i = 0; i < 4; i++) {
                most[i] = input[i, 0];
                least[i] = input[1, i];
                change[i] = most[i] - least[i];
            }
            string out1 = "1";
            string out2 = "2";
            string out3 = "3";
            string[] out0 = { out1, out2, out3 };
            return out0;
        }

        string Mask1(int[] input) {
            
        }

    }

    class Personality{

    }
}
