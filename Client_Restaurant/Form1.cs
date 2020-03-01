using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_Restaurant.localhost;

namespace Client_Restaurant
{
    public partial class Form1 : Form
    {
        localhost.wservice webs = new localhost.wservice();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = webs.getAllRestaurant();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            
        {
            txtid.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[0].Value.ToString();
            txtnombre.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[1].Value.ToString();
            txtrnc.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[3].Value.ToString();
            txttelefono.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[4].Value.ToString();
            txtpersonae.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[5].Value.ToString();
            txtcantidad.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[6].Value.ToString();
            txtfechac.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[7].Value.ToString();
            txtfecham.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[8].Value.ToString();
            txttipocomida.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[9].Value.ToString();
            txtventas.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[10].Value.ToString();
            tbguid.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[11].Value.ToString();
            txtdireccion.Text = dtgv.Rows[dtgv.CurrentCellAddress.Y].Cells[2].Value.ToString();

        }
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            localhost.wservice webs = new localhost.wservice();
            webs.PostRestaurant(   Nombre: txtnombre.Text,
                                   Direccion: txtdireccion.Text,
                                   RNC: txtrnc.Text,
                                   Telefono: txttelefono.Text,
                                   Persona_Encargada: txtpersonae.Text,
                                   Cantidad_Emplados: Convert.ToInt32(txtcantidad.Text),
                                   Fecha_Creacion: Convert.ToDateTime(txtfechac.Text),
                                   Fecha_Modificacion: Convert.ToDateTime(txtfecham.Text),
                                   Tipo_Comida: txttipocomida.Text,
                                   Ventas_Mensuales_Promedio: Convert.ToDouble(txtventas.Text),
                                   GuidReg: (tbguid.Text));
            string msg = "Restaurant creado";
            MessageBox.Show(msg);
            dtgv.DataSource = webs.getAllRestaurant();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            webs.DeleteRestaurant(id:Convert.ToInt32(txtid.Text));
            string msg = "Restaurant eliminado";
            MessageBox.Show(msg);
            dtgv.DataSource = webs.getAllRestaurant();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                 webs.PutRestaurant(id: Convert.ToInt32(txtid.Text),
                                    Nombre: txtnombre.Text,
                                    Direccion: txtdireccion.Text,
                                    RNC: txtrnc.Text,
                                    Telefono: txttelefono.Text,
                                    Persona_Encargada: txtpersonae.Text,
                                    Cantidad_Emplados: Convert.ToInt32(txtcantidad.Text),
                                    Fecha_Creacion: Convert.ToDateTime(txtfechac.Text),
                                    Fecha_Modificacion: Convert.ToDateTime(txtfecham.Text),
                                    Tipo_Comida: txttipocomida.Text,
                                    Ventas_Mensuales_Promedio: Convert.ToDouble(txtventas.Text),
                                    GuidReg: (tbguid.Text));
            string msg = "Restaurant actualizado";
            MessageBox.Show(msg);
            dtgv.DataSource = webs.getAllRestaurant();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtrnc.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtpersonae.Clear();
            txtcantidad.Clear();
            txtfechac.Clear();
            txtfecham.Clear();
            txtnombre.Clear();
            txtventas.Clear();
            txtnombre.Clear();
            tbguid.Clear();
        }
    }
}
