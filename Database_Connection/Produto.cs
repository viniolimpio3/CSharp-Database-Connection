using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Connection
{
    class Produto{
        //Atributos da entidade Produto
        
        private int cod;
        private string product;
        private string description;
        private decimal valor;
        private int cod_fornecedor;

        public int Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int Cod_forn
        {
            get { return cod_fornecedor; }
            set { cod_fornecedor = value; }
        }
        
    }
}
