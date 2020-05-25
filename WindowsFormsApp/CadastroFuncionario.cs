using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Entities;
using WindowsFormsApp.Exceptions;
using WindowsFormsApp.Entities.ManipulationFiles;

namespace WindowsFormsApp
{

    public partial class CadastroFuncionario : Form
    {
        ListaFuncionario listaFuncionarios = new ListaFuncionario();

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MinhaJanela_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            LimparCampos();
            
            CarregamentoLv(ManipulationFile.LinesFile());
        }

        private void CarregamentoLv(List<string> lines)
        {
            for (int contador = 0; contador < lines.Count; contador++)
            {
                try
                {
                    string[] elementos = lines[contador].Split('|');

                    Funcionario funcionario = new Funcionario(elementos[0], elementos[1], elementos[2],
                    float.Parse(elementos[3]), float.Parse(elementos[4]), float.Parse(elementos[5]));

                    funcionario.CalcularLiquido(float.Parse(elementos[3]), float.Parse(elementos[4]), float.Parse(elementos[5]));

                    ListViewItem item = LvItem.Item(funcionario);

                    listaFuncionarios.ArmazenarFuncionario(funcionario);
                    lvListaFuncionarios.Items.Add(item);
                }
                catch (DomainException err)
                {
                    MessageBox.Show(err.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void LimparCampos()
        {
            tbNome.Text = string.Empty;
            tbCargo.Text = string.Empty;
            tbSalario.Text = "0";
            tbDesconto.Text = "0";
            tbAdicional.Text = "0";
            tbLiquido.Text = "0";
            tbCPF.Text = string.Empty;
            cbDesconto.Checked = false;
        }

        private void FormatarCampos()
        {
            float valor;

            valor = float.Parse(tbSalario.Text);
            tbSalario.Text = valor.ToString("N2");

            valor = float.Parse(tbDesconto.Text);
            tbDesconto.Text = valor.ToString("N2");

            valor = float.Parse(tbAdicional.Text);
            tbAdicional.Text = valor.ToString("N2");

            valor = float.Parse(tbLiquido.Text);
            tbLiquido.Text = valor.ToString("N2");
        }

        private void CalcularLiquido()
        {
            if (cbDesconto.Checked)
                tbLiquido.Text = Convert.ToString(float.Parse(tbSalario.Text) + float.Parse(tbAdicional.Text));
            else
                tbLiquido.Text = Convert.ToString(float.Parse(tbSalario.Text) - float.Parse(tbDesconto.Text) + float.Parse(tbAdicional.Text));

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // metodo ArmazenarFuncionario
                // responsavel por inserir um novo objeto Funcionario
                // em uma posição da list
                listaFuncionarios.ArmazenarFuncionario(tbNome.Text,
                                                       tbCPF.Text,
                                                       tbCargo.Text,
                                                       float.Parse(tbSalario.Text),
                                                       float.Parse(tbDesconto.Text),
                                                       float.Parse(tbAdicional.Text),
                                                       cbDesconto.Checked);

                // alimento uma "sublista" de item (que é uma linha da list view)
                // "pegando" os dados  dos textbox 
                int length = listaFuncionarios.RetornarTamanhoLista() - 1;
                ListViewItem item = LvItem.Item(listaFuncionarios.RetornaObjetoFuncionario(length));
                // adicionando o objeto item na listview
                lvListaFuncionarios.Items.Add(item);

                MessageBox.Show($"Calculou Salário Líquido para o funcionário {tbNome.Text}", "Atenção");
                LimparCampos();
            }
            catch (DomainException err)
            {
                MessageBox.Show(err.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LvListaFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbAdicional_Leave(object sender, EventArgs e)
        {
            CalcularLiquido();
            FormatarCampos();
        }

        private void TbSalario_Leave(object sender, EventArgs e)
        {
            CalcularLiquido();
            FormatarCampos();
        }

        private void TbDesconto_Leave(object sender, EventArgs e)
        {
            CalcularLiquido();
            FormatarCampos();
        }

        private void CbDesconto_CheckStateChanged(object sender, EventArgs e)
        {
            CalcularLiquido();
            FormatarCampos();
            if (cbDesconto.Checked)
                tbDesconto.Visible = false;
            else
                tbDesconto.Visible = true;
            tbDesconto.Text = "0,00";
        }

        // Evento Click do btnExcluir 
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // Este for, percorre a lista de itens selecionados na listview
            for (int itemList = lvListaFuncionarios.CheckedItems.Count - 1; itemList >= 0; itemList--)
            {
                // cria um objeto tipo list view item
                // joga pra esse objeto, a lista de funcionarios selecionados
                ListViewItem lista = lvListaFuncionarios.CheckedItems[itemList];
                // metodo remove = remove uma lista (item) da list view
                lvListaFuncionarios.Items.Remove(lista);

                // obtem o text da posição 0 da minha sublista da listview
                // que é a coluna "nome"
                string cpf = lista.SubItems[1].Text;

                // chamada ao metodo RemoverFuncionario
                // passando o parametro nome, obtido acima.
                listaFuncionarios.RemoverFuncionario(cpf);
            }
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            // metodo que ordena a lista de objetos funcionarios
            listaFuncionarios.OrdenarFuncionario();

            //limpa a listview (grid da tela)
            lvListaFuncionarios.Items.Clear();

            // obtem o tamanho da list
            // lembrando que aqui neste escopo, o listaFuncionario não é manipulado como list
            // apenas dentro da classe
            int tamanhoLista = listaFuncionarios.RetornarTamanhoLista();

            // objeto funcionarioObj "em branco"
            Funcionario funcionarioObj = new Funcionario();

            //percorre a list do inicio ao fim
            for (int indice = 0; indice < tamanhoLista; indice++)
            {
                // cada indice, funcionarioObj irá receber o objeto Funcionario da posição
                funcionarioObj = listaFuncionarios.RetornaObjetoFuncionario(indice);

                // alimento uma "sublista" de item (que é uma linha da list view)
                // "pegando" os dados direto do funcionarioObj
                ListViewItem item = LvItem.Item(funcionarioObj);
                // adicionando o objeto item na listview
                lvListaFuncionarios.Items.Add(item);
            }
        }
    }
}
