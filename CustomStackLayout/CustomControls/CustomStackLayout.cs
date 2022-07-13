using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomStackLayout.CustomControls
{
    public class CustomStackLayout : StackLayout
    {
        public CustomStackLayout()
        {
            var g1 = new GradientStop
            {
                Color = Color.Red,
                Offset = 0.0f,
            };

            var g2 = new GradientStop
            {
                Color = Color.Orange,
                Offset = 0.2f,
            };

            var g3 = new GradientStop
            {
                Color = Color.Yellow,
                Offset = 0.4f,
            };

            var g4 = new GradientStop
            {
                Color = Color.Green,
                Offset = 0.6f,
            };

            var g5 = new GradientStop
            {
                Color = Color.Blue,
                Offset = 0.8f,
            };

            var g6 = new GradientStop
            {
                Color = Color.Purple,
                Offset = 0.9f,
            };

            var gc = new GradientStopCollection();
            gc.Add(g1);
            gc.Add(g2);
            gc.Add(g3);
            gc.Add(g4);
            gc.Add(g5);
            gc.Add(g6);

            var linearGradientBrush = new LinearGradientBrush { GradientStops = gc };
            this.Background = linearGradientBrush;
        }
    }
}
