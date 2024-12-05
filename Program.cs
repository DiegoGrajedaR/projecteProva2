namespace projecteProva2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MsgInput = "Introdueix 20 nombres enters";
            const int SizeArray = 3;

            int[] arrayValues = new int[SizeArray];
            int inputNumber;

            Console.WriteLine(MsgInput);

            for (int i = 0; i < SizeArray; i++) {
                inputNumber = Console.Read();
                arrayValues[i] = inputNumber;
        }


    }
}
