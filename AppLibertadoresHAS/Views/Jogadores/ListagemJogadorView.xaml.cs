using AppLibertadoresHAS.Services;
using AppLibertadoresHAS.ViewModels;

namespace AppLibertadoresHAS.Views.Jogadores;

public partial class ListagemJogadorView : ContentPage
{
	ListagemJogadorViewModel listagemViewModel;
	public ListagemJogadorView()
	{
		InitializeComponent();

		listagemViewModel = new ListagemJogadorViewModel();
		BindingContext = listagemViewModel; 
		Title = "Listar Jogadores"
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
		_ = listagemViewModel.ObterJogadores();
    }
}