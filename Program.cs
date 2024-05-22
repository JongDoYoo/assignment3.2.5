namespace _3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 5, 3 };
            int[] array2 = { 9, 8, 3 };
            int[] array3 = { 1, 2, 3 };
            Console.WriteLine(FindIndex(array1, 5));
            Console.WriteLine(FindIndex(array2, 3));
            Console.WriteLine(FindIndex(array3, 4));
        }
        static int FindIndex(int[] myList, int find) 
        {
            int i = 0;  
            while (i < myList.Length) 
            {
                foreach (int num in myList) 
                {
                    if (num == find)
                    {
                        return i;
                    }
                    else 
                    {
                        i++;
                    }
                }              
            }
            return -1;
        }
    }
}
