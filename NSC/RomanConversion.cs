using System;
using System.Collections.Generic;
using System.Text;

namespace NSC
{
    public class RomanConversion
    {

        public static string ArabicToRoman(double ArabicNumber)
        {
            string RomanNumber = "";
            int IntPart = Convert.ToInt32(Math.Floor(Math.Abs(ArabicNumber)));
            int i, M, C, X;
            M = (IntPart / 1000);
            for (i = 0; i < M; i++)
            {
                RomanNumber += "M";
            }

            IntPart -= M * 1000;

            C = (IntPart / 100);
            switch (C)
            {
                case 1:
                    RomanNumber += "C";
                    break;
                case 2:
                    RomanNumber += "CC";
                    break;
                case 3:
                    RomanNumber += "CCC";
                    break;
                case 4:
                    RomanNumber += "CD";
                    break;
                case 5:
                    RomanNumber += "D";
                    break;
                case 6:
                    RomanNumber += "DC";
                    break;
                case 7:
                    RomanNumber += "DCC";
                    break;
                case 8:
                    RomanNumber += "DCCC";
                    break;
                case 9:
                    RomanNumber += "CM";
                    break;
            }
            IntPart -= C * 100;

            X = (IntPart / 10);
            switch (X)
            {
                case 1:
                    RomanNumber += "X";
                    break;
                case 2:
                    RomanNumber += "XX";
                    break;
                case 3:
                    RomanNumber += "XXX";
                    break;
                case 4:
                    RomanNumber += "XL";
                    break;
                case 5:
                    RomanNumber += "L";
                    break;
                case 6:
                    RomanNumber += "LX";
                    break;
                case 7:
                    RomanNumber += "LXX";
                    break;
                case 8:
                    RomanNumber += "LXXX";
                    break;
                case 9:
                    RomanNumber += "XC";
                    break;
            }
            IntPart -= X * 10;

            switch (IntPart)
            {
                case 1:
                    RomanNumber += "I";
                    break;
                case 2:
                    RomanNumber += "II";
                    break;
                case 3:
                    RomanNumber += "III";
                    break;
                case 4:
                    RomanNumber += "IV";
                    break;
                case 5:
                    RomanNumber += "V";
                    break;
                case 6:
                    RomanNumber += "VI";
                    break;
                case 7:
                    RomanNumber += "VII";
                    break;
                case 8:
                    RomanNumber += "VIII";
                    break;
                case 9:
                    RomanNumber += "IX";
                    break;
            }
            
            return RomanNumber;
        }

        public static double RomanToArabic(string RomanNumber)
        {
            double ArabicNumber = 0;
            int CurPos = 0;
            string TempRoman = RomanNumber + "      ";

            while ((TempRoman.Substring(CurPos, 1) == "M") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 1000;
                CurPos++;
            }
            if ((TempRoman.Substring(CurPos, 1) == "D") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 500;
                CurPos += 1;
                while ((TempRoman.Substring(CurPos, 1) == "C") && (CurPos < RomanNumber.Length))
                {
                    ArabicNumber += 100;
                    CurPos++;
                }
            }
            if ((TempRoman.Substring(CurPos, 2) == "CD") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 400;
                CurPos += 2;
            }
            while ((TempRoman.Substring(CurPos, 1) == "C") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 100;
                CurPos++;
            }

            if ((TempRoman.Substring(CurPos, 2) == "CM") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 900;
                CurPos += 2;
            }
            if ((TempRoman.Substring(CurPos, 1) == "L") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 50;
                CurPos += 1;
                while ((TempRoman.Substring(CurPos, 1) == "X") && (CurPos < RomanNumber.Length))
                {
                    ArabicNumber += 10;
                    CurPos++;
                }
            }
            if ((TempRoman.Substring(CurPos, 2) == "XL") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 40;
                CurPos += 2;
            }
            while ((TempRoman.Substring(CurPos, 1) == "X") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 100;
                CurPos++;
            }

            if ((TempRoman.Substring(CurPos, 2) == "XC") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 90;
                CurPos += 2;
            }
            if ((TempRoman.Substring(CurPos, 1) == "V") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 5;
                CurPos += 1;
                while ((TempRoman.Substring(CurPos, 1) == "I") && (CurPos < RomanNumber.Length))
                {
                    ArabicNumber += 1;
                    CurPos++;
                }
            }
            if ((TempRoman.Substring(CurPos, 2) == "IV") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 4;
                CurPos += 2;
            }
            while ((TempRoman.Substring(CurPos, 1) == "I") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 1;
                CurPos++;
            }

            if ((TempRoman.Substring(CurPos, 2) == "IX") && (CurPos < RomanNumber.Length))
            {
                ArabicNumber += 9;
                CurPos += 2;
            }
            return ArabicNumber;
        }

    }
}
