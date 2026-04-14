using System.Globalization;
using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper? _db;

        public static SQLiteDatabaseHelper Db 
        {
            get 
            {
                if (_db == null)
                {
                    string caminho_do_arquivo = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3"
                            );

                    _db = new SQLiteDatabaseHelper(caminho_do_arquivo);
                }
                return _db;
            }
        }
        public App()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window w = new Window(new AppShell());
            w.Width = 400;
            w.Height = 800;
            return w;
        }
    }
}