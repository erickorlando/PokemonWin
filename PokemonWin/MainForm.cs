using PokemonWin.Service;
using System;
using System.Windows.Forms;

namespace PokemonWin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            var proxy = new ProxyPokemon();
            var response = await proxy.GetListPokemons();
            lblStatus.Text = @"Cargando....";

            proxy.ProcesoTerminado += () =>
             {
                 lblStatus.Invoke((MethodInvoker)(() =>
                 {
                     tvwPokemon.Nodes.Clear();
                     var nodoPadre = tvwPokemon.Nodes.Add("Pokemones");

                     foreach (var result in response.Results)
                     {
                         nodoPadre.Nodes.Add(result.Name);
                     }
                     lblStatus.Text = string.Empty;
                 }));
             };
        }
    }
}
