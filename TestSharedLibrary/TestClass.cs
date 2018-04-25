namespace TestSharedLibrary
{
    public class TestClass
    {
        private int number1;
        private int number2;

        private string string1;

        public int Number1 { get { return number1; } set { number1 = value; } }
        public int Number2 { get { return number2; } set { number2 = value; } }

        public string String1 { get { return string1; } set { string1 = value; } }

        public int Sum()
        {
            return number1 * number2;
        }
    }
}
