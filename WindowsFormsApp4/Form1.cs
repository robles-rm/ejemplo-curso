using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon; //Guarda los datos obtenidos de la BD
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegcio negocio = new PokemonNegcio();
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            pbxPokemon.Load(listaPokemon[0].UrlImagen);


        }
        //Evento para mostar imagen segun pokemon seleccionado en PictureBox
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            pbxPokemon.Load(seleccionado.UrlImagen);
        }
    }
}
