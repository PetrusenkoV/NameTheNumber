using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameTheNumber
{
    public enum possibleEndings
    {
        Empty,
        A,
        Ov
    }
    public class Mushroom
    {
        //public int Ending(int number)
        //{
        //    if (number / 10 == 1)
        //    {
        //        return 2;
        //    }
        //    else
        //    {
        //        int remains = number % 10;

        //        if (remains == 1)
        //        {
        //            return 0;
        //        }
        //        else if (remains >= 2 && remains <= 4)
        //        {
        //            return 1;
        //        }
        //        else
        //        {
        //            return 2;
        //        }
        //    }
        //}
        public possibleEndings Ending(int number)
        {
            if (IsSpecialNumber(number))
            {
                return possibleEndings.Ov;
            }

            if (IsEndingA(number))
            {
                return possibleEndings.A;
            }

            if (IsEndingEmpty(number))
            {
                return possibleEndings.Empty;
            }

            return possibleEndings.Ov;
        }
        public bool IsEndingEmpty(int number)
        {
            return (number % 10) == 1;
        }

        public bool IsEndingA(int number)
        {
            return (number % 10) <= 4 && (number % 10) >= 2;
        }

        public bool IsSpecialNumber(int number)
        {
            return number / 10 == 1;
        }
        //public string EndingMessage(possibleEndings ending)
        //{
        //    string result;

        //    switch (ending)
        //    {
        //        case possibleEndings.Empty:
        //            result = "";
        //            break;
        //        case possibleEndings.A:
        //            result = "а";
        //            break;                
        //        default:
        //            result = "ов";
        //            break;
        //    }

        //    return result;
        //}

        public string Message(int number)
        {
            possibleEndings ending = Ending(number);
            string result;

            switch (ending)
            {
                case possibleEndings.Empty:
                    result = "";
                    break;
                case possibleEndings.A:
                    result = "а";
                    break;
                default:
                    result = "ов";
                    break;
            }

            return result;
        }
    }
}
