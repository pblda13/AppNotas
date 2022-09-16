using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Notas;Integrated Security=True");
        SqlCommand cmd;     
        const int ID = 1;


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float nota1 = float.Parse(textBox1.Text);
            float nota2 = float.Parse(textBox2.Text);
            float nota3 = float.Parse(textBox3.Text);
            float nota4 = float.Parse(textBox4.Text);

            OperacoesNotas resultado = new OperacoesNotas();
            
            label3.Text = resultado.MaiorNota(nota1, nota2, nota3, nota4).ToString();
            label4.Text = resultado.MenorNota(nota1, nota2, nota3, nota4).ToString();
            label5.Text = resultado.Media(nota1, nota2, nota3, nota4).ToString();
            label6.Text = resultado.SomaNotasPares(nota1, nota2, nota3, nota4).ToString();
            label7.Text = resultado.SomaNotasImpares(nota1, nota2, nota3, nota4).ToString();
            label8.Text = resultado.NotaasMaioresOuIgualSete(nota1, nota2, nota3, nota4).ToString();


        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Nota (n1,n2,n3,n4) VALUES(@n1,@n2,@n3,@n4)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@n1", textBox1.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@n2", textBox2.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@n3", textBox3.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@n4", textBox4.Text.ToUpper());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void btn_ler_Click(object sender, EventArgs e)
        {
            try
            {
                // SELECT* FROM Nota WHERE ID = @id

                
                cmd = new SqlCommand("SELECT MAX(ID) FROM Nota;", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    this.textBox1.Text += reader["n1"].ToString();
                    this.textBox2.Text += reader["n2"].ToString();
                    this.textBox3.Text += reader["n3"].ToString();
                    this.textBox4.Text += reader["n4"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
    

}



