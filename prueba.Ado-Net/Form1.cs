using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio1;
using Negocio1;
using winfrom_app;

namespace prueba.Ado_Net
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();

        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon selccionado = (Pokemon)dataGridView2.CurrentRow.DataBoundItem;

            cargarImagen(selccionado.UrlImagen);

        }
        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dataGridView2.DataSource = listaPokemon;
                dataGridView2.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBPokemons.Load(imagen);

            }
            catch (Exception ex)
            {

                pictureBPokemons.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");



            }
        }


       

        private void agregar_Click_1(object sender, EventArgs e)
        {
            frmAltaPokemon alta =new frmAltaPokemon();
            alta.ShowDialog();
            cargar();
        }
    }
}
