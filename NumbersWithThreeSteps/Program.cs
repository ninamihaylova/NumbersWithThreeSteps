class NumbersWithThreeSteps {
    public static void Main (String[]args)
    {

        int n = int.Parse(Console.ReadLine());

        for (int i=1;i<=n;i+=3) {
            Console.WriteLine(i);

        }
    }
}