namespace FacebookWinFormsApp_Logic
{
    public class NonClassifier : IClassifier
    {
        public string GetPropertyName()
        {
            return "NON";
        }

        public bool ShouldClassify(string i_Key)
        {
            return true;
        }
    }
}