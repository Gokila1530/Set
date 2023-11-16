namespace Set
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            HashSet<string> mySet = new HashSet<string>();

            mySet.Add("C");
            mySet.Add("C++");
            mySet.Add("C#");
            mySet.Add("Java");
            mySet.Add("C++");

            foreach (var val in mySet)
            {
                Console.WriteLine(val);
            }

        }
    }
}