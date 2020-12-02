using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokemonWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (var ctx = new PokemonDb())
            {
                ctx.Database.EnsureCreated();

                var list = new List<Pokemon>();
                for (var i = 0; i < 1000; i++)
                {
                    var pokemon = new Pokemon
                    {
                        Name = $"pokemon {i+1}",
                        Type = $"Type {i+1}",
                        BirthDate = DateTime.Today.AddMonths(-i),
                        Strenght = i * 3
                    };
                    list.Add(pokemon);
                }
                

                ctx.AddRange(list);
                ctx.SaveChanges();

                MessageBox.Show(@"Pokemon guardado, revise BD!");
            }

            Cursor = Cursors.Default;
        }
    }
}
