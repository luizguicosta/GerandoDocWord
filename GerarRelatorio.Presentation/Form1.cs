using GerarRelatorio.Business;
using GerarRelatorio.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace GerarRelatorio.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            var model = new RelatorioPessoaModel
            {
                Nome = tbNome.Text,
                Sobrenome = tbSobrenome.Text,
                Idade = (int)tbIdade.Value,
                DataNascimento = dtNascimento.Value,
                DataAdmissao = dtAdmissao.Value,
                DataPromocao = dtPromocao.Value,
                Descricao = rtbDescricao.Text
            };

            var result = RelatorioPessoa.GerarRelatorio(model);
            if (result)
            {
                MessageBox.Show("Relatório gerado com Sucesso!!!");
            }
            else
            {
                MessageBox.Show("Erro ao gerar o relatório");
            }
        }
    }
}
