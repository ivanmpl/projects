using System;

namespace temp2
{
    public class Program
    {
        static int[] cellComplete(int[] states, int days)
        {
            int[] new_states = new int[states.Length];
            Array.Copy(states, new_states, states.Length);

            for (int j = 0; j < days; j++)
            {
                Array.Copy(states, new_states, states.Length);

                for (int i = 0; i < states.Length; i++)
                {
                    Console.Write(states[i]);

                    if (i == 0)
                    {
                        if (states[i + 1] == 0)
                        {
                            new_states[i] = 0;
                        }

                        if (states[i + 1] == 1)
                        {
                            new_states[i] = 1;
                        }
                    }

                    else if (i == states.Length - 1)
                    {

                        if (states[i - 1] == 0)
                        {
                            new_states[i] = 0;
                        }

                        if (states[i - 1] == 1)
                        {
                            new_states[i] = 1;
                        }
                    }

                    else
                    {
                        if ((states[i - 1] == 0 && states[i + 1] == 0) || (states[i - 1] == 1 && states[i + 1] == 1))
                        {
                            new_states[i] = 0;

                        }
                        else
                        {
                            new_states[i] = 1;
                        }
                    }

                }

            }

            return new_states;
        }
        static void Main(string[] args)
        {
            int[] ar = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            int[] br = cellComplete(ar, 1);

            foreach (var item in br)
            {
                Console.Write(item.ToString());
            }
        }
    }

}