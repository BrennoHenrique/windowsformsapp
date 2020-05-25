using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp.Exceptions;
using WindowsFormsApp.EntitiesAgenda;

namespace WindowsFormsApp
{
    public partial class Agenda : Form
    {
        private AgendaEntitie agenda = new AgendaEntitie();
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            RedimensionaColuna();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            boxNome.Text = string.Empty;
            boxEndereco.Text = string.Empty;
            boxTelefone.Text = string.Empty;
            boxEmail.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SalvaComEditar())
                {
                    ListViewItem item = new ListViewItem(new[] { boxNome.Text, boxEndereco.Text,
                                                                 boxTelefone.Text, boxEmail.Text});

                    this.agenda.AddPessoa(boxNome.Text, boxEndereco.Text, boxTelefone.Text, boxEmail.Text);

                    lvAgenda.Items.Add(item);
                }
                else
                {
                    Pessoa pessoa = new Pessoa(boxNome.Text, boxEndereco.Text, boxTelefone.Text, boxEmail.Text);

                    lvAgenda.SelectedItems[0].SubItems[0].Text = pessoa.Nome;
                    lvAgenda.SelectedItems[0].SubItems[1].Text = pessoa.Endereco;
                    lvAgenda.SelectedItems[0].SubItems[2].Text = pessoa.Telefone;
                    lvAgenda.SelectedItems[0].SubItems[3].Text = pessoa.Email;

                    agenda.EditarPessoa(pessoa, lvAgenda.Items.IndexOf(lvAgenda.SelectedItems[0]));
                }
            }
            catch (DomainException err)
            {
                MessageBox.Show(err.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (lvAgenda.SelectedItems.Count > 0)
                    if (lvAgenda.SelectedItems[0].Selected)
                        lvAgenda.SelectedItems[0].Selected = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvAgenda.SelectedItems.Count > 0)
            {
                ListViewItem item = lvAgenda.SelectedItems[0];
                boxNome.Text = item.SubItems[0].Text;
                boxEndereco.Text = item.SubItems[1].Text;
                boxTelefone.Text = item.SubItems[2].Text;
                boxEmail.Text = item.SubItems[3].Text;
            }
        }

        private bool SalvaComEditar()
        {
            if (lvAgenda.SelectedItems.Count > 0)
                return true;
            else
                return false;
        }

        private void lvAgenda_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int indiceColumn = e.Column;

            if (indiceColumn == 0)
            {
                agenda.OrdenaListaPessoa();

                lvAgenda.Items.Clear();

                for (int indice = 0; indice < agenda.RetornaTamanhoLista(); indice++)
                {
                    Pessoa pessoa = agenda.RetornaPessoa(indice);

                    ListViewItem item = new ListViewItem(new[] { pessoa.Nome, pessoa.Endereco, pessoa.Telefone, pessoa.Email });
                    lvAgenda.Items.Add(item);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvAgenda.SelectedItems.Count > 0)
            {
                ListViewItem item = lvAgenda.SelectedItems[0];

                int index = lvAgenda.Items.IndexOf(item);

                lvAgenda.SelectedItems[0].SubItems.Clear();
                agenda.ExcluirPessoa(index);

                lvAgenda.SelectedItems[0].Selected = false;

                lvAgenda_ColumnClick(sender, new ColumnClickEventArgs(0));
            }
        }

        private void RedimensionaColuna()
        {
            try
            {
                lvAgenda.Columns[0].Width = 238;
                lvAgenda.Columns[1].Width = 159;
                lvAgenda.Columns[2].Width = 91;
                lvAgenda.Columns[3].Width = 146;
            }
            catch (StackOverflowException)
            {
                lvAgenda.Columns[0].Width = 238;
                lvAgenda.Columns[1].Width = 159;
                lvAgenda.Columns[2].Width = 91;
                lvAgenda.Columns[3].Width = 146;
            }
        }

        private void lvAgenda_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            MessageBox.Show("Não é possível alterar a posição das colunas!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            RedimensionaColuna();
        }
    }
}
