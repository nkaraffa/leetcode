public class Solution {
    public string IntToRoman(int num) {
        /*Algorthim
             * Constraint:  1 <= num <= 3999
             * 1. Create dictionary
             * 2. Read input integer -> interpret integer with dictionary
             * 3. Convert int value to string, using dictionary
             * 4. Return string result
            */

            Dictionary<int, string> romDict = new Dictionary<int, string>();
            romDict.Add(1000, "M");
            romDict.Add(900, "CM");
            romDict.Add(500, "D");
            romDict.Add(400, "CD");
            romDict.Add(100, "C");
            romDict.Add(90, "XC");
            romDict.Add(50, "L");
            romDict.Add(40, "XL");
            romDict.Add(10, "X");
            romDict.Add(9, "IX");
            romDict.Add(5, "V");
            romDict.Add(4, "IV");
            romDict.Add(1, "I");

            string answer = "";
            int[] intTerms = new int[4];        //Thousand, Hundred, Ten, Single

            if (romDict.Keys.Contains(num))     //Dictionary contains exact input value
            {
                answer = answer + romDict[num];
                return answer;
            }
            else
            {
                intTerms[0] = num / 1000;   // # of terms
                int temp = num % 1000;      //remainder
                intTerms[1] = temp / 100;
                temp = num % 100;
                intTerms[2] = temp / 10;
                temp = num % 10;
                intTerms[3] = temp / 1;

                for (int i = 0; i < intTerms.Length; i++)
                {
                    if (intTerms[i] != 0)
                    {
                        if (i == 0)         //Thousand
                        {
                            answer = string.Concat(Enumerable.Repeat('M', intTerms[i]));
                        }
                        else if (i == 1)     //Hundred
                        {
                            if (intTerms[i] * 100 == 900 | intTerms[i] * 100 == 500 | intTerms[i] * 100 == 400 | intTerms[i] * 100 == 100)
                            {
                                answer = answer + romDict[intTerms[i] * 100];
                            }
                            else if (intTerms[i] > 5)
                            {
                                answer = answer + "D" + string.Concat(Enumerable.Repeat('C', intTerms[i]-5));
                            }
                            else if (intTerms[i] < 5)
                            {
                                answer = answer + string.Concat(Enumerable.Repeat('C', intTerms[i]));
                            }
                        }
                        else if (i == 2)     //Ten
                        {
                            if (intTerms[i] * 10 == 90 | intTerms[i] * 10 == 50 | intTerms[i] * 10 == 40 | intTerms[i] * 10 == 10)
                            {
                                answer = answer + romDict[intTerms[i] * 10];
                            }
                            else if (intTerms[i] > 5)
                            {
                                answer = answer + "L" + string.Concat(Enumerable.Repeat('X', intTerms[i] - 5));
                            }
                            else if (intTerms[i] < 5)
                            {
                                answer = answer + string.Concat(Enumerable.Repeat('X', intTerms[i]));
                            }
                        }
                        else if (i == 3)    //Single
                        {
                            if (intTerms[i] == 9 | intTerms[i] == 5 | intTerms[i] == 4 | intTerms[i] == 1)
                            {
                                answer = answer + romDict[intTerms[i]];
                            }
                            else if (intTerms[i] > 5)
                            {
                                answer = answer + "V" + string.Concat(Enumerable.Repeat('I', intTerms[i] - 5));
                            }
                            else if (intTerms[i] < 5)
                            {
                                answer = answer + string.Concat(Enumerable.Repeat('I', intTerms[i]));
                            }
                        }
                    }
                }

                return answer;
            }  
    }
}