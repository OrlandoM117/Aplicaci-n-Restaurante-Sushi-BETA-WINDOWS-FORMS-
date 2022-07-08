namespace Restaurante_Sushi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FujiRoll = new System.Windows.Forms.Button();
            this.btn_ShibuyaRoll = new System.Windows.Forms.Button();
            this.btn_California = new System.Windows.Forms.Button();
            this.btn_NamiRoll = new System.Windows.Forms.Button();
            this.btn_RegioDon = new System.Windows.Forms.Button();
            this.btn_EbiDon = new System.Windows.Forms.Button();
            this.btn_Pepsi = new System.Windows.Forms.Button();
            this.btn_AguaMineral = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDineroCliente = new System.Windows.Forms.TextBox();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Pedido = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dgv_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ReiniciarPedido = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_SubTotal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FujiRoll
            // 
            this.btn_FujiRoll.Location = new System.Drawing.Point(117, 14);
            this.btn_FujiRoll.Name = "btn_FujiRoll";
            this.btn_FujiRoll.Size = new System.Drawing.Size(133, 79);
            this.btn_FujiRoll.TabIndex = 0;
            this.btn_FujiRoll.Text = "Fuji Roll";
            this.btn_FujiRoll.UseVisualStyleBackColor = true;
            this.btn_FujiRoll.Click += new System.EventHandler(this.btn_FrujiRoll);
            // 
            // btn_ShibuyaRoll
            // 
            this.btn_ShibuyaRoll.Location = new System.Drawing.Point(283, 14);
            this.btn_ShibuyaRoll.Name = "btn_ShibuyaRoll";
            this.btn_ShibuyaRoll.Size = new System.Drawing.Size(133, 79);
            this.btn_ShibuyaRoll.TabIndex = 1;
            this.btn_ShibuyaRoll.Text = "Shibuya Roll";
            this.btn_ShibuyaRoll.UseVisualStyleBackColor = true;
            this.btn_ShibuyaRoll.Click += new System.EventHandler(this.btn_ShibuyaRoll_Click);
            // 
            // btn_California
            // 
            this.btn_California.Location = new System.Drawing.Point(440, 14);
            this.btn_California.Name = "btn_California";
            this.btn_California.Size = new System.Drawing.Size(133, 79);
            this.btn_California.TabIndex = 2;
            this.btn_California.Text = "California";
            this.btn_California.UseVisualStyleBackColor = true;
            this.btn_California.Click += new System.EventHandler(this.btn_California_Click);
            // 
            // btn_NamiRoll
            // 
            this.btn_NamiRoll.Location = new System.Drawing.Point(602, 14);
            this.btn_NamiRoll.Name = "btn_NamiRoll";
            this.btn_NamiRoll.Size = new System.Drawing.Size(133, 79);
            this.btn_NamiRoll.TabIndex = 3;
            this.btn_NamiRoll.Text = "Nami Roll";
            this.btn_NamiRoll.UseVisualStyleBackColor = true;
            this.btn_NamiRoll.Click += new System.EventHandler(this.btn_NamiRoll_Click);
            // 
            // btn_RegioDon
            // 
            this.btn_RegioDon.Location = new System.Drawing.Point(117, 121);
            this.btn_RegioDon.Name = "btn_RegioDon";
            this.btn_RegioDon.Size = new System.Drawing.Size(133, 79);
            this.btn_RegioDon.TabIndex = 4;
            this.btn_RegioDon.Text = "Regio Don";
            this.btn_RegioDon.UseVisualStyleBackColor = true;
            this.btn_RegioDon.Click += new System.EventHandler(this.btn_RegioDon_Click);
            // 
            // btn_EbiDon
            // 
            this.btn_EbiDon.Location = new System.Drawing.Point(283, 121);
            this.btn_EbiDon.Name = "btn_EbiDon";
            this.btn_EbiDon.Size = new System.Drawing.Size(133, 79);
            this.btn_EbiDon.TabIndex = 5;
            this.btn_EbiDon.Text = "Ebi Don";
            this.btn_EbiDon.UseVisualStyleBackColor = true;
            this.btn_EbiDon.Click += new System.EventHandler(this.btn_EbiDon_Click);
            // 
            // btn_Pepsi
            // 
            this.btn_Pepsi.Location = new System.Drawing.Point(117, 231);
            this.btn_Pepsi.Name = "btn_Pepsi";
            this.btn_Pepsi.Size = new System.Drawing.Size(133, 79);
            this.btn_Pepsi.TabIndex = 6;
            this.btn_Pepsi.Text = "Pepsi";
            this.btn_Pepsi.UseVisualStyleBackColor = true;
            this.btn_Pepsi.Click += new System.EventHandler(this.btn_Pepsi_Click);
            // 
            // btn_AguaMineral
            // 
            this.btn_AguaMineral.Location = new System.Drawing.Point(283, 231);
            this.btn_AguaMineral.Name = "btn_AguaMineral";
            this.btn_AguaMineral.Size = new System.Drawing.Size(133, 79);
            this.btn_AguaMineral.TabIndex = 7;
            this.btn_AguaMineral.Text = "Agua Mineral";
            this.btn_AguaMineral.UseVisualStyleBackColor = true;
            this.btn_AguaMineral.Click += new System.EventHandler(this.btn_AguaMineral_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sushi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sopas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sodas";
            // 
            // txtDineroCliente
            // 
            this.txtDineroCliente.Location = new System.Drawing.Point(924, 492);
            this.txtDineroCliente.Name = "txtDineroCliente";
            this.txtDineroCliente.Size = new System.Drawing.Size(83, 27);
            this.txtDineroCliente.TabIndex = 11;
            this.txtDineroCliente.TextChanged += new System.EventHandler(this.txtDineroCliente_TextChanged);
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Location = new System.Drawing.Point(951, 469);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(33, 20);
            this.lbl_SubTotal.TabIndex = 12;
            this.lbl_SubTotal.Text = "$$$";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(459, 191);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(114, 77);
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Text = "Eliminar Producto";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Pedido
            // 
            this.btn_Pedido.AutoSize = true;
            this.btn_Pedido.Location = new System.Drawing.Point(748, 116);
            this.btn_Pedido.Name = "btn_Pedido";
            this.btn_Pedido.Size = new System.Drawing.Size(55, 20);
            this.btn_Pedido.TabIndex = 14;
            this.btn_Pedido.Text = "Pedido";
            this.btn_Pedido.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgv_Cantidad,
            this.Dgv_Nombre,
            this.Dgv_Precio});
            this.dataGridView1.Location = new System.Drawing.Point(577, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(430, 329);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Dgv_Cantidad
            // 
            this.Dgv_Cantidad.HeaderText = "Cantidad";
            this.Dgv_Cantidad.MinimumWidth = 6;
            this.Dgv_Cantidad.Name = "Dgv_Cantidad";
            this.Dgv_Cantidad.Width = 125;
            // 
            // Dgv_Nombre
            // 
            this.Dgv_Nombre.HeaderText = "Nombre";
            this.Dgv_Nombre.MinimumWidth = 6;
            this.Dgv_Nombre.Name = "Dgv_Nombre";
            this.Dgv_Nombre.Width = 125;
            // 
            // Dgv_Precio
            // 
            this.Dgv_Precio.HeaderText = "Precio";
            this.Dgv_Precio.MinimumWidth = 6;
            this.Dgv_Precio.Name = "Dgv_Precio";
            this.Dgv_Precio.Width = 125;
            // 
            // btn_ReiniciarPedido
            // 
            this.btn_ReiniciarPedido.Location = new System.Drawing.Point(459, 274);
            this.btn_ReiniciarPedido.Name = "btn_ReiniciarPedido";
            this.btn_ReiniciarPedido.Size = new System.Drawing.Size(114, 77);
            this.btn_ReiniciarPedido.TabIndex = 16;
            this.btn_ReiniciarPedido.Text = "Reiniciar Pedido";
            this.btn_ReiniciarPedido.UseVisualStyleBackColor = true;
            this.btn_ReiniciarPedido.Click += new System.EventHandler(this.btn_ReiniciarPedido_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(589, 472);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(114, 77);
            this.btn_Calcular.TabIndex = 17;
            this.btn_Calcular.Text = "Calcular TOTAL";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "SUBTOTAL:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(951, 529);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(33, 20);
            this.lbl_Total.TabIndex = 19;
            this.lbl_Total.Text = "$$$";
            this.lbl_Total.Click += new System.EventHandler(this.lbl_Total_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "DINERO RECIBIDO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "CAMBIO:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(12, 466);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(133, 79);
            this.btn_Salir.TabIndex = 22;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // btn_SubTotal
            // 
            this.btn_SubTotal.Location = new System.Drawing.Point(459, 357);
            this.btn_SubTotal.Name = "btn_SubTotal";
            this.btn_SubTotal.Size = new System.Drawing.Size(114, 77);
            this.btn_SubTotal.TabIndex = 23;
            this.btn_SubTotal.Text = "Calcular SUBTOTAL";
            this.btn_SubTotal.UseVisualStyleBackColor = true;
            this.btn_SubTotal.Click += new System.EventHandler(this.btn_SubTotal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(901, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 557);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_SubTotal);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_ReiniciarPedido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Pedido);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.lbl_SubTotal);
            this.Controls.Add(this.txtDineroCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AguaMineral);
            this.Controls.Add(this.btn_Pepsi);
            this.Controls.Add(this.btn_EbiDon);
            this.Controls.Add(this.btn_RegioDon);
            this.Controls.Add(this.btn_NamiRoll);
            this.Controls.Add(this.btn_California);
            this.Controls.Add(this.btn_ShibuyaRoll);
            this.Controls.Add(this.btn_FujiRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_FujiRoll;
        private Button btn_ShibuyaRoll;
        private Button btn_California;
        private Button btn_NamiRoll;
        private Button btn_RegioDon;
        private Button btn_EbiDon;
        private Button btn_Pepsi;
        private Button btn_AguaMineral;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDineroCliente;
        private Label lbl_SubTotal;
        private Button btn_Eliminar;
        private Label btn_Pedido;
        private DataGridView dataGridView1;
        private Button btn_ReiniciarPedido;
        private Button btn_Calcular;
        private Label label4;
        private Label lbl_Total;
        private Label label6;
        private Label label5;
        private Button btn_Salir;
        private DataGridViewTextBoxColumn Dgv_Cantidad;
        private DataGridViewTextBoxColumn Dgv_Nombre;
        private DataGridViewTextBoxColumn Dgv_Precio;
        private Button btn_SubTotal;
        private Label label7;
    }
}