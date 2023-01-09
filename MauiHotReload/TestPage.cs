using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Markup;

namespace MauiHotreload
{
    public class TestPage : ContentPage
    {
        public TestPage()
        {
            Load();
            hotreload.shared.HotReloadService.UpdateApplicatonEvent += (Type[] types) =>
            {
                MainThread.BeginInvokeOnMainThread(() => Load());
            };
        }

        internal void Load()
        {
            Content = new Label().Text("testasdfafdasddddddddddd").Center();
        }
    }
}


