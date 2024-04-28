public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        //I am setting up a list to hold the values from the loop
        var multipleList1 = new double [length];
        //I want to put in a loop here that is going to go through and basically do X * number for
        //however long the length is it will do that
        //As my code goes through the for loop it is going to calculate the value for each
        //based on each i value. the code is also going to add each value to the list
        //as it goes through the loop
        for (int i=0 ; i<length; i++)
        {
            multipleList1[i] = number * (i+1);

        }
        return multipleList1;

        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //My first thoughts on this part of the program are not the most efficient at all
        //but I am pretty sure it will work. I am thinking that I will have me loop go through
        //every single value in the list and add the number to each individual number and then
        //so for example if the list is [1,2,3] and i am shifting right 4 then it will take
        //the 1 and add 4 then put in into a new list. then it will take 2 and add 4 then put
        //it into the new list and then the same thing for 3.

        //After I cam up with my idea above, I realized it is not going to work because the
        //lists are supposed to not only move to the right but the last numbers have to 
        //be carried over to the left side...

        //I think after studying a little bit more I am going to try and do what I had
        //originally planned, but I will use remove range and insert range to move the end portion
        //of the list to the front.

        //The following code didn't work and I had to change the code above so that there
        //was a variable that coulde be returned to so I think that was too complicated and
        //will change it:

        //var numList1 = new double [data.Count];

       // for (int i=0; i<data.Count; i++)
        //{
            //numList1[i] = data[i] + amount;


        //}
        //return numList1;


        //I think I need to try it without using a loop.

        int i = data.Count;
        int checkRemainder = amount % i;

        if (checkRemainder > 0)
        {
            List<int> newList = data.GetRange(i - checkRemainder, checkRemainder);
            data.RemoveRange(i-checkRemainder,checkRemainder);
            data.InsertRange(0,newList);

        }



    }
}
