using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Database_Connection
{
    class Util
    {
        private object response;

        public void sair()
        {
            this.response = MessageBox.Show("Deseja sair dessa aplicação?", "" +
                "***FINALIZANDO***",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (response.Equals(DialogResult.Yes)) Application.Exit();
        }

        public void limparControles(Control c)
        {
            foreach (Control caixa in c.Controls){
                if(caixa is TextBox){
                    (( TextBox )caixa).Clear();
                }else{
                    limparControles(caixa);
                }
            }
        }

    }
}
