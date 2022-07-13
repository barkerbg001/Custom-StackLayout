using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomStackLayout.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class CustomStackLayout : StackLayout
    {
        public CustomStackLayout()
        {
            SetBackground();
        }

        private void SetBackground()
        {
            if(DateTime.Now.Month == 6)
            {
                BackgroundPrideMonth();
            }
        }
        private void BackgroundPrideMonth()
        {
            var gc = new GradientStopCollection
                        {
                            new GradientStop
                        {
                            Color = Color.Red,
                            Offset = 0.0f,
                        },
                            new GradientStop
                        {
                            Color = Color.Orange,
                            Offset = 0.2f,
                        },
                            new GradientStop
                        {
                            Color = Color.Yellow,
                            Offset = 0.4f,
                        },
                            new GradientStop
                        {
                            Color = Color.Green,
                            Offset = 0.6f,
                        },
                            new GradientStop
                        {
                            Color = Color.Blue,
                            Offset = 0.8f,
                        },
                            new GradientStop
                        {
                            Color = Color.Purple,
                            Offset = 0.9f,
                        }
                        };

            Background = new LinearGradientBrush { GradientStops = gc };
        }
    }
}
