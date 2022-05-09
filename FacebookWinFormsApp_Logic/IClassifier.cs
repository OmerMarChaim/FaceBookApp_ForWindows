namespace FacebookWinFormsApp_Logic
{
    public interface IClassifier
    {
        string GetPropertyName();

        bool ShouldClassify(string i_Key);
    }
}