using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            // put your code here
            if(array.Length == 0)
            {
                throw new ArgumentNullException();
            }
            else if (array[0] == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                string sg = "";
                for (int i = 0; i < array.Length; ++i)
                {
                    for (int j = 0; j < array.Length; ++j)
                    {
                        if (array[i].Length < array[j].Length)
                        {
                            sg = array[i];
                            array[i] = array[j];
                            array[j] = sg;
                        }
                    }
                }
            }

        }
    }
}
