// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Enter a maximum number: ");
int maxNum = Convert.ToInt16(Console.ReadLine());

for (var counter = 1; counter < maxNum+1; counter++)
{
    List<string> output = new List<string> { };

    if (counter % 11 == 0)
    {
        if (counter % 13 == 0)
        {
            output.Add("Fezz");
            output.Add("Bong");

        }
        else
        {
            output.Add("Bong");
        }
    }
    else if (counter % 13 == 0)
    {
        if (counter % 3 == 0 && counter % 5 == 0 && counter % 7 == 0)
        {
            output.Add("Fizz");
            output.Add("Fezz");
            output.Add("Buzz");
            output.Add("Bang");
        }
        else if (counter % 3 == 0 && counter % 5 == 0)
        {
            output.Add("Fizz");
            output.Add("Fezz");
            output.Add("Buzz");
        }
        else if (counter % 3 == 0 && counter % 7 == 0)
        {
            output.Add("Fizz");
            output.Add("Fezz");
            output.Add("Bang");
        }
        else if (counter % 5 == 0 && counter % 7 == 0)
        {
            output.Add("Fezz");
            output.Add("Buzz");
            output.Add("Bang");
        }

        else if (counter % 3 == 0)
        {
            output.Add("Fizz");
            output.Add("Fezz");
        }
        else if (counter % 5 == 0)
        {
            output.Add("Fezz");
            output.Add("Buzz");
        }
        else if (counter % 7 == 0)
        {
            output.Add("Fezz");
            output.Add("Bang");
        }
        else
        {
            output.Add("Fezz");
        }

    }
    else
    {
        if (counter % 3 == 0 && counter % 5 == 0 && counter % 7 == 0)
        {
            output.Add("Fizz");
            output.Add("Buzz");
            output.Add("Bang");
        }
        else if (counter % 3 == 0 && counter % 5 == 0)
        {
            output.Add("Fizz");
            output.Add("Buzz");
        }
        else if (counter % 3 == 0 && counter % 7 == 0)
        {
            output.Add("Fizz");
            output.Add("Bang");
        }
        else if (counter % 5 == 0 && counter % 7 == 0)
        {
            output.Add("Buzz");
            output.Add("Bang");
        }

        else if (counter % 3 == 0)
        {
            output.Add("Fizz");
        }
        else if (counter % 5 == 0)
        {
            output.Add("Buzz");
        }
        else if (counter % 7 == 0)
        {
            output.Add("Bang");
        }
    }

    if (output.Count == 0)
    {
        Console.WriteLine(counter);
    }
    else if (counter % 17 == 0)
    {
        output.Reverse();
        Console.WriteLine(string.Join("", output));
    }
    else
    {
        Console.WriteLine(string.Join("", output));
    }


}

