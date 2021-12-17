using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_compras
{
    public partial class Form1 : Form
    {
        class produto
        {
            public string nome;
            public double preco;
        }

        List<produto> LISTA_PRODUTOS;
        List<produto> LISTA_COMPRAS;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LISTA_PRODUTOS = new List<produto>()
            {
                new produto(){ nome = "Laranja", preco = 10 },
                new produto(){ nome = "Ananás", preco = 25 },
                new produto(){ nome = "Banana", preco = 5.5 }
            };

            foreach (produto p in LISTA_PRODUTOS)
            {
                lst_produtos.Items.Add(ConstruirLinhaProduto(p));
            }

            IniciarCompras();
        }

        private string ConstruirLinhaProduto(produto p)
        {
            string preco = p.preco.ToString("0.00") + " $";
            return p.nome + new string(' ', 30 - p.nome.Length - preco.Length) + preco;
        }

        private void IniciarCompras()
        {
            LISTA_COMPRAS = new List<produto>();
            lst_compras.Items.Clear();
            label_total.Text = "0,00 $";
        }

        private void lst_produtos_DoubleClick_1(object sender, EventArgs e)
        {
            if (lst_produtos.SelectedIndex == -1) return;
            produto p = LISTA_PRODUTOS[lst_produtos.SelectedIndex];
            AdicionarProdutoCompra(p);
        }

        private void AdicionarProdutoCompra(produto p)
        {
            LISTA_COMPRAS.Add(p);
            lst_compras.Items.Add(ConstruirLinhaProduto(p));

            var total = LISTA_COMPRAS.Sum(i => i.preco);
            label_total.Text = total.ToString("0.00") + " $";
        }

        private void cmd_nova_compra_Click_1(object sender, EventArgs e)
        {
            IniciarCompras();
        }

        private void cmd_finalizar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Conta finalizada!" + Environment.NewLine + label_total.Text);

        }                         
    }    
}
