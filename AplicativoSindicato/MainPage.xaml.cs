namespace AplicativoSindicato
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Seu código aqui
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            } // Fecha Método
        } // <-- Adicionado para fechar o método Button_Clicked

    } // Fecha Class
} // Fecha Namespace
