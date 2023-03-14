using Android.App;
using Android.OS;
using Android.Graphics;
using Android.Widget;

namespace Android_sliding_puzzle
{
    [Activity(Label = "Android_sliding_puzzle", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity 
    {
        Button resetButton;
        GridLayout mainLayout;

        int gameViewWidth;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
        
        }
        private void setGameView()
        {
            //Obtiene el layout de los elementos de la vista
            resetButton = FindViewById<Button>(Resource.Id.resetButtonId);
            mainLayout = FindViewById<GridLayout>(Resource.Id.gameGridLayoutId);
            //Obtiene el ancho de la vista
            gameViewWidth = Resources.DisplayMetrics.WidthPixels;

            //Ubica el numero de columnas y filas
            mainLayout.ColumnCount = 4;
            mainLayout.RowCount = 4;
            //La cuadrícula debe ser de tamaño cuadrado igual al teléfono
            mainLayout.LayoutParameters = new LinearLayout.LayoutParams(gameViewWidth, gameViewWidth);
            //Asignar color gris al layout
            mainLayout.SetBackgroundColor(Color.Gray);

        }
     
    }
}