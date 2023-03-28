﻿using System;
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
        private void dataGridView2_SelectionChanged_1(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow != null)
            {
            Pokemon seleccionado = (Pokemon)dataGridView2.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
            }
        }
        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dataGridView2.DataSource = listaPokemon;
                ocultarColumnas();
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dataGridView2.Columns["UrlImagen"].Visible = false;
            dataGridView2.Columns["Id"].Visible = false;
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

        private void Modificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dataGridView2.CurrentRow.DataBoundItem;

            frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            eliminar();
            
           
        }

        private void EliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);

        }
        private void eliminar(bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿estas seguro de que querees eliminar?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dataGridView2.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);

                    cargar();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                List<Pokemon> listaFiltrada;
                string filtro = txtFiltro.Text;

                if (filtro.Length >= 2)
                {
                    listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper())); //lambda

                }
                else
                {
                    listaFiltrada = listaPokemon;
                }
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = listaFiltrada;
                ocultarColumnas();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {

                List<Pokemon> listaFiltrada;
                string filtro = txtFiltro.Text;

                if (filtro.Length >=2)
                {
                    listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper())); //lambda

                }
                else
                {
                    listaFiltrada = listaPokemon;
                }
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = listaFiltrada;
                ocultarColumnas();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

