namespace dateTime

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatumOmSjuDagar();
        }

        static public void DatumOmSjuDagar()
        {
            var dateTime = DateTime.Now.AddDays(7);
            Console.WriteLine(dateTime);

        }
    }
}