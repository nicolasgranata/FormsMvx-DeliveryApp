using Android.Content;
using Android.Support.V7.Graphics.Drawable;
using Android.Widget;
using DeliveryApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(DeliveryApp.Forms.Views.MainPage), typeof(IconNavigationPageRenderer))]
namespace DeliveryApp.Droid.Renderers
{
    public class IconNavigationPageRenderer : MasterDetailPageRenderer
    {
        private readonly Context _context;

        public IconNavigationPageRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

            if (toolbar != null)
            {
                for (var i = 0; i < toolbar.ChildCount; i++)
                {
                    var imageButton = toolbar.GetChildAt(i) as Android.Widget.ImageButton;

                    var drawerArrow = imageButton?.Drawable as DrawerArrowDrawable;
                    if (drawerArrow == null)
                        continue;

                    imageButton.SetImageDrawable(_context.GetDrawable(Resource.Drawable.account_circle));
                }
            }
        }
    }
}