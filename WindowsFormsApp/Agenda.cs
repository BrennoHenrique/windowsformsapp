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
using WindowsFormsApp.EntitiesAgenda.ManipulationDB;

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
            Controle Controle = new Controle();

            try
            {
                List<Pessoa> Pessoas = Controle.LoadForms();

                for (int contador = 0; contador < Pessoas.Count; contador++)
                {
                    agenda.AddPessoa(Pessoas[contador]);

                    ListViewItem item = new ListViewItem(new[] {Pessoas[contador].Nome, Pessoas[contador].Endereco,
                                                            Pessoas[contador].Telefone, Pessoas[contador].Email});

                    lvAgenda.Items.Add(item);
                }
            }
            catch (DomainException err)
            {
                MessageBox.Show(err.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Dados informados pelo banco de dados incorretamente!\n" +
                                "Para iniciar o programa corretamente, é necessário que faça o acesso ao banco de dados e corrija os erros dos cadastros.\n" +
                                "O programa será encerrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            boxNome.Text = string.Empty;
            boxEndereco.Text = string.Empty;
            boxTelefone.Text = string.Empty;
            boxEmail.Text = string.Empty;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Controle Controle = new Controle();

            try
            {
                if (!SalvaComEditar())
                {
                    ListViewItem item = new ListViewItem(new[] { boxNome.Text, boxEndereco.Text,
                                                                 boxTelefone.Text, boxEmail.Text});

                    Pessoa pessoa = new Pessoa(boxNome.Text, boxEndereco.Text,
                                               boxTelefone.Text, boxEmail.Text);

                    Controle.InsertInAgenda(boxNome.Text, boxEndereco.Text,
                                            boxTelefone.Text, boxEmail.Text);

                    if (Controle.Menssagem.Equals(""))
                    {
                        this.agenda.AddPessoa(pessoa);
                        lvAgenda.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show(Controle.Menssagem);
                    }
                    LimparCampos();
                }
                else
                {
                    Pessoa pessoa = new Pessoa(boxNome.Text, boxEndereco.Text, boxTelefone.Text, boxEmail.Text);

                    Controle.UpdateInAgenda(lvAgenda.SelectedItems[0].SubItems[0].Text,
                                            lvAgenda.SelectedItems[0].SubItems[1].Text,
                                            lvAgenda.SelectedItems[0].SubItems[2].Text,
                                            lvAgenda.SelectedItems[0].SubItems[3].Text, pessoa);

                    if (Controle.Menssagem.Equals(""))
                    {
                        lvAgenda.SelectedItems[0].SubItems[0].Text = pessoa.Nome;
                        lvAgenda.SelectedItems[0].SubItems[1].Text = pessoa.Endereco;
                        lvAgenda.SelectedItems[0].SubItems[2].Text = pessoa.Telefone;
                        lvAgenda.SelectedItems[0].SubItems[3].Text = pessoa.Email;

                        agenda.EditarPessoa(pessoa, lvAgenda.Items.IndexOf(lvAgenda.SelectedItems[0]));
                    }
                    else
                    {
                        MessageBox.Show(Controle.Menssagem);
                    }
                    LimparCampos();
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
            Controle Controle = new Controle();

            if (lvAgenda.SelectedItems.Count > 0)
            {
                ListViewItem item = lvAgenda.SelectedItems[0];

                Controle.DeleteInAgenda(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text,
                                        item.SubItems[3].Text);

                if (Controle.Menssagem.Equals(""))
                {
                    int index = lvAgenda.Items.IndexOf(item);

                    lvAgenda.SelectedItems[0].SubItems.Clear();
                    agenda.ExcluirPessoa(index);

                    lvAgenda.SelectedItems[0].Selected = false;

                    lvAgenda_ColumnClick(sender, new ColumnClickEventArgs(0));
                }
                else
                {
                    MessageBox.Show(Controle.Menssagem);
                }
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
