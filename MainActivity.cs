using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;

namespace WorkClocker;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : AppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
        /*
            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNavigation!.ItemSelected += (sender, args) =>{
                switch(args.Item.ItemId){
                    case Resource.Id.homeButton:
                        //TODO: Switch to home page
                       break;
                    case Resource.Id.settingsButton:
                        //TODO: Switch to settings page
                        break;
                    case Resource.Id.manualAddButton:
                       //TODO: Switch to manual add page
                       break;
                    default:
                        break;
                }
            };
        */
    }
}