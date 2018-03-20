using Android.App;
using Android.OS;
using Android.Widget;

namespace App3
{
    [Activity(Label = "Alcohol party")]
    class QuantityActivity : Activity
    {
        public static int count = 0;
        protected override void OnCreate(Bundle savedInstanceState){ 
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Quantity);
            GetSelectedTextView();
            PressButtonAll();
        }

        private void PressButtonAll()
        {
            PressButtonPlus();
            PressButtonMinus();
            PressButtonNext();
        }

        private void PressButtonMinus(){
            FindViewById<Button>(Resource.Id.buttonQuantityMinus).Click += delegate{
                if (count <= 0) count = 0;
                else FindViewById<TextView>(Resource.Id.textQuantity).Text = (--count).ToString();
            };
        }

        private void PressButtonPlus(){
            FindViewById<Button>(Resource.Id.buttonQuantityPlus).Click += (o, e) => FindViewById<TextView>(Resource.Id.textQuantity).Text = (++count).ToString();
        }

        private void PressButtonNext(){
            FindViewById<Button>(Resource.Id.buttonNext).Click += (o, e) =>
            {
                StartActivity(typeof(SelectAlcoholeActivity));
            };
        }

        private string GetSelectedTextView()
        {
            return FindViewById<TextView>(Resource.Id.textSelected).Text = "Selected Alcohole: " + MainActivity.nameLevel + " level";
        }
    }
}   