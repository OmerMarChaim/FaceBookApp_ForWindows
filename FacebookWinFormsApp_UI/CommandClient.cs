using FacebookWinFormsApp_Logic;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    internal class CommandClient
    {
        public readonly AlbumProxy r_AlbumProxy;
        private readonly List<MenuItem> r_Menu;

        public CommandClient(AlbumProxy i_AlbumProxy)
        {
            r_AlbumProxy = i_AlbumProxy;
            r_Menu = new List<MenuItem>()
                         {
                             new MenuItem
                                 {
                                     Text = "None", Command = new ExecuteNonClassifier { albumProxy = r_AlbumProxy }
                                 },
                             new MenuItem
                                 {
                                     Text = "First Name Start Aeiou Letters",
                                     Command = new ExecuteFirstNameStartAeiouLetters { albumProxy = r_AlbumProxy }
                                 }
                         };
        }

        public List<MenuItem> Menu
        {
            get => r_Menu;
        }

        private class ExecuteNonClassifier : ICommand
        {
            public AlbumProxy albumProxy { get; set; }

            public void Execute()
            {
                albumProxy.Property = new NonClassifier();
            }
        }

        private class ExecuteFirstNameStartAeiouLetters : ICommand
        {
            public AlbumProxy albumProxy { get; set; }

            public void Execute()
            {
                albumProxy.Property = new FirstNameStartAeiouLetters();
            }
        }
    }

}


    
