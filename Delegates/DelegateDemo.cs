namespace Deleates
{
    class DelegateDemo
    {
        public delegate int Notify(int num1, int num2);

        public int Addition(int num1, int num2)
        {
            System.Console.WriteLine("Addition");
            return num1 + num2;
        }

        public int Substract(int num1, int num2)
        {
            System.Console.WriteLine("Substraction");
            return num1 - num2;
        }

        public void Demo()
        {
            Notify delegateObj = Addition;
            delegateObj += Substract;
            System.Console.WriteLine(delegateObj(5, 5));
        }
    }
}