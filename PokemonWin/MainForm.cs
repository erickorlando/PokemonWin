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
            txtRowPerPage.Text = @"100";
            txtPagina.Text = @"0";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var proxy = new ProxyPokemon();
            proxy.GetListPokemons(Convert.ToInt32(txtRowPerPage.Text),
                Convert.ToInt32(txtPagina.Text));
            lblStatus.Text = @"Cargando....";

            proxy.ProcesoTerminado += (x) =>
             {
                 lblStatus.Invoke((MethodInvoker)(() =>
                 {
                     tvwPokemon.Nodes.Clear();
                     var nodoPadre = tvwPokemon.Nodes.Add("Pokemones");

                     foreach (var result in x.Results)
                     {
                         nodoPadre.Nodes.Add(result.Name);
                     }
                     lblStatus.Text = string.Empty;
                 }));
             };
        }
    }
}
