using Android.Net.Http;
using Android.Views;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.BottomSheet;
using Android.Util;
using AndroidX.Window;
using System.ComponentModel;
namespace WorkClocker;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : AppCompatActivity
{
    class CustomCallback : BottomSheetBehavior.BottomSheetCallback
    {
        AppCompatActivity _containingActivity;
        public CustomCallback(AppCompatActivity containingActivity){
            _containingActivity = containingActivity;
        }
        public override void OnSlide(View bottomSheet, float newState){}
        

        public override void OnStateChanged(View view, int newState)
        {
            var button = _containingActivity.FindViewById<Button>(Resource.Id.bottomsheet_button);
            button!.Text = newState switch{
                BottomSheetBehavior.StateCollapsed => "State Collapsed",
                BottomSheetBehavior.StateDragging => "State Dragging",
                BottomSheetBehavior.StateExpanded => "State Expanded",
                BottomSheetBehavior.StateHalfExpanded => "State Half Expanded",
                BottomSheetBehavior.StateHidden => "State Hidden",
                BottomSheetBehavior.StateSettling => "State Settling",
                _ =>throw new ArgumentOutOfRangeException($"Not expected state: {newState}")
            };
        }
    }
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);


        var bottomSheet = FindViewById<FrameLayout>(Resource.Id.bottomSheet);
        var sheetBehaviour = BottomSheetBehavior.From(bottomSheet!);
        sheetBehaviour.Hideable = false;
        DisplayMetrics displayMetrics = new();
        Display!.GetMetrics(displayMetrics);
        sheetBehaviour.PeekHeight = displayMetrics.HeightPixels * 1/4;
        sheetBehaviour.MaxHeight = displayMetrics.HeightPixels * 2/3;
        sheetBehaviour.AddBottomSheetCallback(new CustomCallback(this));
    }
}