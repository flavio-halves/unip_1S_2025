﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Entidade;
using Sistema.Model;



namespace Sistema.View
{
    public partial class frmCadUsuario : Form
    {
        UsuarioEnt objTabela = new UsuarioEnt();

        private string opc;
        public frmCadUsuario()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void HabitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtUsuario.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            iniciarOpc();
        }

        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabitarCampos();
                    LimparCampos();

                    break;

                case "Salvar":

                    try
                    {
                        objTabela.Nome = txtNome.Text;
                        objTabela.Usuario = txtUsuario.Text;
                        objTabela.Senha = txtSenha.Text;

                        int x = UsuarioModel.Inserir(objTabela);

                        if (x > 0)
                        {

                            MessageBox.Show(string.Format("Usuario {0} foi inserido com sucesso", txtNome));
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro ao inserir");
                        }
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao Salvar" + ex.Message);
                        throw;

                    }
                    break;



                case "Excluir":
                    break;

                case "Editar":
                    break;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            iniciarOpc();

            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            iniciarOpc();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            iniciarOpc();
        }
    }
}
