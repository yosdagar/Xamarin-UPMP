using System;
using Android.App;
using Android.Widget;
using Android.OS;
using EnviarCorreo.Nativo.Services;

namespace EnviarCorreo.Nativo
{
    [Activity(Label = "EnviarCorreo.Nativo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button actionButton;
        string emailBase = "yosdagar@gmail.com";
        string codeBase = "iniciativa";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            actionButton = FindViewById<Button>(Resource.Id.btnReportar);
            actionButton.Click += btnReportar_Click;
        }

        private async void btnReportar_Click(object sender, EventArgs e)
        {
            ServiceHelper serviceHelper = new ServiceHelper();
            if (emailBase == "yosdagar@gmail.com" || codeBase == "iniciativa")
            {


            }
            actionButton.Enabled = false;
            await serviceHelper.InsertarEntidad("yosdagar@gmail.com", "iniciativa");
            actionButton.Text = "Reporte enviado";

            Toast.MakeText(this, "Tienes correo nuevo!", ToastLength.Short).Show();
        }
    }
}