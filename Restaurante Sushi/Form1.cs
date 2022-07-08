namespace Restaurante_Sushi
{
    public partial class Form1 : Form
    {
        int pos;

        double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_FrujiRoll(object sender, EventArgs e)
        {

            btn_Eliminar.Enabled = true;
            btn_Calcular.Enabled = true;
            string cantidad, nombre, precio;
            cantidad = "1";
            nombre = "Fruji Roll";
            precio = "87";
            dataGridView1.Rows.Add(cantidad, nombre, precio);
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ReiniciarPedido_Click(object sender, EventArgs e)
        {
            //aqui reinicia el datagridview
            dataGridView1.Rows.Clear();
            btn_Eliminar.Enabled = false;
            btn_Calcular.Enabled = false;
            lbl_SubTotal.Text = "$$$";
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //aqui elimina la fila posicionada
            dataGridView1.Rows.RemoveAt(pos);


        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            //aqui esta calculando haciendo la resta de EL DINERO DEL CLIENTE - SUBTOTAL
            double subtotal = 0;
            double dl = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["Dgv_Precio"].Value);

            }
            lbl_SubTotal.Text = Convert.ToString(subtotal);


            resultado = Convert.ToDouble(txtDineroCliente.Text) - Convert.ToDouble(subtotal);

            dl = Convert.ToDouble(txtDineroCliente.Text);





            if (dl > subtotal)
            lbl_Total.Text = Convert.ToString(resultado);
            else
            {
                MessageBox.Show("Ponga una cantidad valida (NO CONTIENE SUFICIENTE DINERO EL CLIENTE)");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Aquí selecciona la posicion presionada
            pos = dataGridView1.CurrentRow.Index;
            
            


        }

        private void btn_ShibuyaRoll_Click(object sender, EventArgs e)
        {
            //Aqui agrega el producto Shibuya Roll


            btn_Eliminar.Enabled = true;
            btn_Calcular.Enabled = true;
            string cantidad, nombre, precio;
            cantidad = "1";
            nombre = "Shibuya roll";
            precio = "105";
            dataGridView1.Rows.Add(cantidad, nombre, precio);
            


        }

        private void btn_RegioDon_Click(object sender, EventArgs e)
        {
            //Aqui agrega el producto Regio
            btn_Eliminar.Enabled = true;
            btn_Calcular.Enabled = true;
            string cantidad, nombre, precio;
            cantidad = "1";
            nombre = "Regio Don";
            precio = "130";
            dataGridView1.Rows.Add(cantidad, nombre, precio);
        }

        private void btn_Pepsi_Click(object sender, EventArgs e)
        {
            //Aqui agrega El Producto Pepsi
            btn_Eliminar.Enabled = true;
            btn_Calcular.Enabled = true;
            string cantidad, nombre, precio;
            cantidad = "1";
            nombre = "Pepsi";
            precio = "15";
            dataGridView1.Rows.Add(cantidad, nombre, precio);
        }

        private void btn_SubTotal_Click(object sender, EventArgs e)
        {
            // Aqui suma los valores para hacer el subtotal, de la columna Precio
            double subtotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["Dgv_Precio"].Value);
                
            }
            lbl_SubTotal.Text = Convert.ToString(subtotal);
        }

        private void txtDineroCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_EbiDon_Click(object sender, EventArgs e)
        {
            //aqui se agrega el producto
            btn_Eliminar.Enabled = true;
            btn_Calcular.Enabled = true;
            string cantidad, nombre, precio;
            cantidad = "1";
            nombre = "Ebi Don";
            precio = "78.50";
            dataGridView1.Rows.Add(cantidad, nombre, precio);
        }

        private void btn_AguaMineral_Click(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Calcular.Enabled = true;
            string cantidad, nombre, precio;
            cantidad = "1";
            nombre = "Agua Mineral";
            precio = "13.50";
            dataGridView1.Rows.Add(cantidad, nombre, precio);
        }

        private void btn_California_Click(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Calcular.Enabled = true;
            string cantidad, nombre, precio;
            cantidad = "1";
            nombre = "California";
            precio = "105.75";
            dataGridView1.Rows.Add(cantidad, nombre, precio);
        }

        private void btn_NamiRoll_Click(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Calcular.Enabled = true;
            string cantidad, nombre, precio;
            cantidad = "1";
            nombre = "Nami Roll";
            precio = "87.50";
            dataGridView1.Rows.Add(cantidad, nombre, precio);
        }

        private void txtPrueba_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}