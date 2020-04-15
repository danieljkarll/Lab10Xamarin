using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample_Personality_Test
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public int index = -1;


        public MainPage()
        {
            InitializeComponent();
            NextQuestion();
        }

        void OnLeftButtonClicked(object sender, EventArgs args)
        {
            Factions.All[Questions.All[index].Affirmative].Points++;
            NextQuestion();
        }

        void OnRightButtonClicked(object sender, EventArgs args)
        {
            Factions.All[Questions.All[index].Negative].Points++;
            NextQuestion();
        }
        void CheckResults(object sender, EventArgs args)
        {
            FinalizeEverything();
        }
        private void NextQuestion()
        {
            index++;
            if(index > 0){
                Check_Button.IsVisible = true;
            }
            if (index < Questions.All.Count)
            {
                Question.Text = Questions.All[index].Prompt;
                Left_Button.Text = Questions.All[index].Left;
                Right_Button.Text = Questions.All[index].Right;
            }
            else
            {
                FinalizeEverything();
                //Left_Button.Text = "";
                //Right_Button.Text = "";
                //Left_Button.IsVisible = false;
                //Right_Button.IsVisible = false;
                //int Result_House_Points = 0;
                //string Result_House = "";
                //foreach (Factions home in Factions.All)
                //{
                //    if (home.Points > Result_House_Points)
                //    {
                //        Result_House = home.Name;
                //        Result_House_Points = home.Points;
                //    }
                //}
                //Banner.IsVisible = true;
                //string Image_Name = Result_House.ToLower()+".jpg";
                //Question.Text = Result_House;
                //Banner.Source = Image_Name;
            }
        }


        private void FinalizeEverything()
        {
                Left_Button.Text = "";
                Right_Button.Text = "";
                Left_Button.IsVisible = false;
                Right_Button.IsVisible = false;
                int Result_House_Points = 0;
                string Result_House = "";
                foreach (Factions home in Factions.All)
                {
                    if (home.Points > Result_House_Points)
                    {
                        Result_House = home.Name;
                        Result_House_Points = home.Points;
                    }
                }
                Check_Button.IsVisible = false;
                Banner.IsVisible = true;
                string Image_Name = Result_House.ToLower() + ".jpg";
                Question.Text = Result_House;
                Banner.Source = Image_Name;
        }
    }
}
