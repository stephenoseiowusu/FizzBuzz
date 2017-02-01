using System;

public class Fizz
{ 
  
  
	public Fizz(ref int min, int max)
	{
        this.min = min;
        this.max = max;

        if(min > max)
        {
            int temp = min;
            min = max;
            max = temp;
        }
        results = new string[max];
        calculate();
        min = 4;
	}

    public string[] results;
    public int min;
    public int max;

    public void calculate()
    {
        int counter = 0;
        for(int i = min; i  <= max ; i++)
        {
            
            if(i % 3 == 0 && i % 5 == 0)
            {
                results[counter] = "FizzBuzz";
            }
            else if(i % 3 == 0)
            {
                results[counter] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[counter] = "Buzz";
            }
            counter = counter + 1;
        }
    }

    public override String ToString()
    {
        String result = "";

        for(int j =0; j < results.Length; j ++)
        {
            if(results[j]!= null)
            {
              //  Console.WriteLine(results[j]);
                result += results[j] + "\n";
            }
            
        }
        return result;
    }
     
}
