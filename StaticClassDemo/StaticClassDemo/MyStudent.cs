namespace StaticClassDemo
{
    public class MyStudent
    {
        private string major;

        private static int classCount;

        public static int getClassCount
        {
            get {return classCount;}
        }

        public string GetMajor()
        {
            return major;
        }

        public static void SetMajor(string newMajor)
        {
            major = newMajor;
            classCount += 1;
        }
    }
}
