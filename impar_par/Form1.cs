using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace impar_par
{
    public partial class Form1 : Form
    {
        int valor =0;
        int somapares = 0;
        int somaimpares = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                Console.WriteLine("Informe o valor ou -1 para sair");
                var input = Console.ReadLine();
                valor = Convert.ToInt32(input);
                if (valor > 0)
                {
                    if ((valor % 2) == 0)
                        somapares += valor;
                    else
                        somaimpares += valor;
                }
            } while (valor > 0);
            Console.WriteLine($"Total Impar {somaimpares}/ Total Par {somapares}");
            Console.ReadLine();
        }
    }
}
