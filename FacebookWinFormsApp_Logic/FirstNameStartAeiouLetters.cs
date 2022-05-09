namespace FacebookWinFormsApp_Logic
{
    public class FirstNameStartAeiouLetters : IClassifier
    {
        public string GetPropertyName()
        {
            return "FirstName";
        }

        public bool ShouldClassify(string i_Key)
        {
            string lowerCaseKey = i_Key.ToLower();
            bool hasAeiou = lowerCaseKey.Contains("a") || lowerCaseKey.Contains("e") || lowerCaseKey.Contains("i")
                            || lowerCaseKey.Contains("o") || lowerCaseKey.Contains("u");
            return  hasAeiou;
        }
    }
}