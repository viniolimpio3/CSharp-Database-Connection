using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database_Connection
{
    public partial class ListForm : Form
    {
        Util util = new Util();
        Banco db = new Banco();
        MySqlDataReader objDados;
        StringBuilder query = new StringBuilder();

        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            query.Append("select * from tabprod");
            objDados = db.dataSet(query.ToString());

            while (objDados.Read()){

                grid.Rows.Add(
                    objDados["CodProd"].ToString(),
                    objDados["NomeProd"].ToString(),
                    objDados["DescProd"].ToString(),
                    objDados["Valor"].ToString(),
                    objDados["CodFor"].ToString()                    
                    );
            }
            if (!objDados.IsClosed) objDados.Close(); query.Remove(0, query.Length);

        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            ListForm_Load(sender, e);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            grid.Rows.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            util.sair();
        }
    }
}