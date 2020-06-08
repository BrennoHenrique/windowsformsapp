using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.EntitiesCadFuncionario
{
    class LvItem
    {
        public static ListViewItem Item(Funcionario funcionario)
        {
            ListViewItem item = new ListViewItem(new[] {funcionario.nome, funcionario.cpf, funcionario.Cargo,
                                                        funcionario.salarioBruto.ToString("N2"), 
                                                        funcionario.desconto.ToString("N2"),
                                                        funcionario.adicional.ToString("N2"),
                                                        funcionario.salarioLiquido.ToString("N2")});
            return item;
        }
    }
}
