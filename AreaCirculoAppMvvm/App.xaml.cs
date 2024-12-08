
    using AreaCirculoAppMvvm.Views;

    namespace AreaCirculoAppMvvm;

    public partial class App : Application
    {
    [Obsolete]
    public App(MainPage mainPage)
        {
            InitializeComponent();

        MainPage = mainPage;

       }
}
