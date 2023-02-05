using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciclo2ou3
{
    public partial class Form1 : Form
    {
       
        public enum eTipoOperacao
        {
            Insercao = 0,
            Edicao = 1
        }

        eTipoOperacao Op;
        const string fileName = "OperaçãoVeiculo.xml";
        DataTable tabVeiculo = new DataTable("Veiculo");
        DataRow linConta;
        int idConta;
        int litroos;
        public Form1()
        {
            InitializeComponent();

            if (System.IO.File.Exists(fileName))
            {
                tabVeiculo.ReadXml(fileName);
            }
            else
            {
                tabVeiculo.Columns.Add("Placa", typeof(int));
                tabVeiculo.Columns.Add("Marca", typeof(string));
                tabVeiculo.Columns.Add("Modelo", typeof(string));
                tabVeiculo.Columns.Add("ConsumoM", typeof(double));
                tabVeiculo.Columns.Add("Combustivel", typeof(double));
                tabVeiculo.Columns.Add("Odometro", typeof(double));


            }
            LimpaControles();
        }
        private void LimpaControles()
        {
            txtPlaca.Clear();
            txtModelo.Clear();
            txtConsumomedio.Clear();
            txtOdometro.Clear();
            txtMarca.Clear();
            txtCombustivel.Clear();
            txtLitros.Clear();
            txtQuilometros.Clear();
            btnGravar.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(txtPlaca.Text, out num))
            {
                MessageBox.Show("Favor informar uma Placa Válida!");
                return;
            }
            //Verifica se a conta existe
            idConta = -1;
            for (int i = 0; i < tabVeiculo.Rows.Count; i++)
            {
                if ((int)tabVeiculo.Rows[i]["Placa"] == num)
                {
                    idConta = i;
                    litroos = i;
                    Op = eTipoOperacao.Edicao;
                    txtMarca.Text = tabVeiculo.Rows[i]["Marca"].ToString();
                    txtModelo.Text = tabVeiculo.Rows[i]["Modelo"].ToString();
                    txtConsumomedio.Text = tabVeiculo.Rows[i]["ConsumoM"].ToString();
                    txtCombustivel.Text = tabVeiculo.Rows[i]["Combustivel"].ToString();
                    txtOdometro.Text = tabVeiculo.Rows[i]["Odometro"].ToString();
                    break;
                }
            }
            if (idConta == -1)
            {
                Op = eTipoOperacao.Insercao;
            }
            //Habilita Controles
            AlteraEstado(true);

        }
        private void AlteraEstado(bool edicao_insercao)
        {
            //Habilita Controles
            btnBuscar.Enabled = !edicao_insercao;
            txtPlaca.Enabled = !edicao_insercao;
            btnGravar.Enabled = edicao_insercao;
            txtMarca.Enabled = edicao_insercao;
            txtModelo.Enabled = edicao_insercao;
            btnAbastecer.Enabled = edicao_insercao;
            txtLitros.Enabled = edicao_insercao;
            txtQuilometros.Enabled = edicao_insercao;
            btnRodar.Enabled = edicao_insercao;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Op == eTipoOperacao.Insercao)
            {
                linConta = tabVeiculo.NewRow();
                linConta["Placa"] = Convert.ToInt32(txtPlaca.Text);
            }
            else
            {
                linConta = tabVeiculo.Rows[idConta];
            }
            if (Op == eTipoOperacao.Insercao)
            {
                tabVeiculo.Rows.Add(linConta);
            }
            tabVeiculo.AcceptChanges();
            tabVeiculo.WriteXml(fileName, XmlWriteMode.WriteSchema);

            //LimpaCampos
            LimpaControles();
            AlteraEstado(false);
        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            double litros,total,novo;
            if(!double.TryParse(txtLitros.Text, out litros))
            {
                MessageBox.Show("Quantidade de litros inválida!");
                return;
            }
            total = Convert.ToDouble(tabVeiculo.Rows[litroos]["Combustivel"].ToString());
            novo = litroos + total;
            if (Op == eTipoOperacao.Insercao)
            {
                linConta = tabVeiculo.NewRow();
                linConta["Placa"] = Convert.ToInt32(txtPlaca.Text);
            }
            else
            {
                linConta = tabVeiculo.Rows[idConta];
            }
            //tabVeiculo.Columns.Add("Marca", typeof(string));
            //tabVeiculo.Columns.Add("Modelo", typeof(string));
            //tabVeiculo.Columns.Add("ConsumoM", typeof(double));
            //tabVeiculo.Columns.Add("Combustivel", typeof(double));
            //tabVeiculo.Columns.Add("Odometro", typeof(double));
            linConta["Placa"] = Convert.ToInt32(txtPlaca.Text);
            linConta["Marca"] = txtMarca.Text;
            linConta["Modelo"] = txtModelo.Text;
            linConta["Combustivel"] = Convert.ToDouble(txtCombustivel.Text);
            linConta["Odometro"] = Convert.ToDouble(txtOdometro.Text);
            tabVeiculo.Rows[idConta]["Placa"] = Convert.ToInt32(txtPlaca.Text);
            tabVeiculo.Rows[idConta]["Marca"] = txtMarca.Text;
            tabVeiculo.Rows[idConta]["Modelo"] = txtModelo.Text;
            tabVeiculo.Rows[idConta]["Combustivel"] = Convert.ToDouble(txtCombustivel.Text);
            tabVeiculo.Rows[idConta]["Odometro"] = Convert.ToDouble(txtOdometro.Text);

            if (Op == eTipoOperacao.Insercao)
            {
                tabVeiculo.Rows.Add(linConta);
            }
            tabVeiculo.AcceptChanges();
            tabVeiculo.WriteXml(fileName, XmlWriteMode.WriteSchema);

        }

        private void btnRodar_Click(object sender, EventArgs e)
        {
            double litros, total, novo;
            if (!double.TryParse(txtQuilometros.Text, out litros))
            {
                MessageBox.Show("Quantidade de Quilometros inválida!");
                return;
            }
            total = Convert.ToDouble(tabVeiculo.Rows[litroos]["Odometro"].ToString());
            novo = litroos + total;
            if (Op == eTipoOperacao.Insercao)
            {
                linConta = tabVeiculo.NewRow();
                linConta["Placa"] = Convert.ToInt32(txtPlaca.Text);
            }
            else
            {
                linConta = tabVeiculo.Rows[idConta];
            }
            //tabVeiculo.Columns.Add("Marca", typeof(string));
            //tabVeiculo.Columns.Add("Modelo", typeof(string));
            //tabVeiculo.Columns.Add("ConsumoM", typeof(double));
            //tabVeiculo.Columns.Add("Combustivel", typeof(double));
            //tabVeiculo.Columns.Add("Odometro", typeof(double));
            linConta["Marca"] = txtMarca.Text;
            linConta["Modelo"] = txtModelo.Text;
            linConta["Combustivel"] = Convert.ToDouble(txtCombustivel.Text);
            linConta["Odometro"] = Convert.ToDouble(txtOdometro.Text);

            if (Op == eTipoOperacao.Insercao)
            {
                tabVeiculo.Rows.Add(linConta);
            }
            tabVeiculo.AcceptChanges();
            tabVeiculo.WriteXml(fileName, XmlWriteMode.WriteSchema);
        }
    }
}
