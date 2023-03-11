
namespace Activity_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reads the file
            string text = System.IO.File.ReadAllText(@"C:\Users\ackle\OneDrive\Desktop\GCU\CST-150 Code\Topic 6\Activity 12\Activity 12\TextFile1.txt");
            //Sepreates the words into seperate items in an array.
            string[] words = text.Split(' ');
            //Used for counting how many words end with e or t.
            int counter = 0;
            //Foreach loop iterates through each item in the array to check if it ends in e or t.
            foreach (string word in words)
            {
                //Conditional will remove period and change all characters to lowercase.
                //EndsWith() method will return true if the word ends with t or e.
                if(word.Replace(".", string.Empty).ToLower().EndsWith('e') || word.Replace(".", string.Empty).ToLower().EndsWith('t'))
                {
                    counter++;
                }
            }
            //Displays the number of words that ends with e or t.
            Console.WriteLine($"There are {counter} words that end with e or t.");
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}