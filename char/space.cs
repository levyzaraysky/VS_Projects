using System;

public class SpaceCounter
{
    public static int CountSpaces(string input)
    {
        int con = 0;
        bool first = false;
        bool last = false;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ' && i == 0)
            {
                con++;
                first = true;
            }
            else if (input[i] == ' ' && i == input.Length - 1)
            {
                con++;
                last = true;
            }
            else if (input[i] == ' ')
            {
                con++;
            }
        }

        if (first && !last)
        {
            return con;
        }
        else if (!first && last)
        {
            return con;
        }
        else if (first && last)
        {
            return con - 1;
        }
        else
        {
            return con + 1;
        }
    }
}