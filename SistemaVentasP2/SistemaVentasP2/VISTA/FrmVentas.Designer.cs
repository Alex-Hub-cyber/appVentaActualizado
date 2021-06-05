
namespace SistemaVentasP2.VISTA
{
    partial class FrmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtgDeVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtUltimaVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmenu = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.TxtTotalFinal = new System.Windows.Forms.TextBox();
            this.BtnGuardarVenta = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDeVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(476, 230);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(125, 20);
            this.TxtCantidad.TabIndex = 35;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged);
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(473, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cantidad :";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.Location = new System.Drawing.Point(18, 230);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(124, 20);
            this.TxtPrecio.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Precio :";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Enabled = false;
            this.TxtNombreProducto.Location = new System.Drawing.Point(476, 183);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(125, 20);
            this.TxtNombreProducto.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nombre Producto :";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(17, 183);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(125, 20);
            this.TxtId.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "codígo producto :";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnBuscar.Location = new System.Drawing.Point(149, 123);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(63, 19);
            this.BtnBuscar.TabIndex = 27;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscarProducto
            // 
            this.TxtBuscarProducto.Location = new System.Drawing.Point(18, 123);
            this.TxtBuscarProducto.Name = "TxtBuscarProducto";
            this.TxtBuscarProducto.Size = new System.Drawing.Size(125, 20);
            this.TxtBuscarProducto.TabIndex = 26;
            this.TxtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarProducto_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Buscar Producto :";
            // 
            // DtgDeVentas
            // 
            this.DtgDeVentas.AllowUserToAddRows = false;
            this.DtgDeVentas.AllowUserToDeleteRows = false;
            this.DtgDeVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDeVentas.BackgroundColor = System.Drawing.Color.Lavender;
            this.DtgDeVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDeVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.DtgDeVentas.Location = new System.Drawing.Point(18, 275);
            this.DtgDeVentas.Name = "DtgDeVentas";
            this.DtgDeVentas.ReadOnly = true;
            this.DtgDeVentas.Size = new System.Drawing.Size(848, 175);
            this.DtgDeVentas.TabIndex = 24;
            this.DtgDeVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDeVentas_CellClick);
            this.DtgDeVentas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DtgDeVentas_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cliente :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(476, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo de documento :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(476, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // TxtUltimaVenta
            // 
            this.TxtUltimaVenta.Enabled = false;
            this.TxtUltimaVenta.Location = new System.Drawing.Point(17, 62);
            this.TxtUltimaVenta.Name = "TxtUltimaVenta";
            this.TxtUltimaVenta.Size = new System.Drawing.Size(125, 20);
            this.TxtUltimaVenta.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Numero de documento :";
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.Location = new System.Drawing.Point(279, 9);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(181, 25);
            this.lblmenu.TabIndex = 36;
            this.lblmenu.Text = "Menu principal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(658, 211);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 16);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "Total :";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(660, 230);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(125, 20);
            this.TxtTotal.TabIndex = 38;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Location = new System.Drawing.Point(791, 230);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 39;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFinal.Location = new System.Drawing.Point(658, 474);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(82, 16);
            this.lblFinal.TabIndex = 40;
            this.lblFinal.Text = "Total Final";
            // 
            // TxtTotalFinal
            // 
            this.TxtTotalFinal.Enabled = false;
            this.TxtTotalFinal.Location = new System.Drawing.Point(741, 470);
            this.TxtTotalFinal.Name = "TxtTotalFinal";
            this.TxtTotalFinal.Size = new System.Drawing.Size(125, 20);
            this.TxtTotalFinal.TabIndex = 41;
            // 
            // BtnGuardarVenta
            // 
            this.BtnGuardarVenta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnGuardarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGuardarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGuardarVenta.FlatAppearance.BorderSize = 4;
            this.BtnGuardarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGuardarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnGuardarVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardarVenta.Location = new System.Drawing.Point(741, 499);
            this.BtnGuardarVenta.Name = "BtnGuardarVenta";
            this.BtnGuardarVenta.Size = new System.Drawing.Size(125, 43);
            this.BtnGuardarVenta.TabIndex = 43;
            this.BtnGuardarVenta.Text = "Guardar Venta";
            this.BtnGuardarVenta.UseVisualStyleBackColor = false;
            this.BtnGuardarVenta.Click += new System.EventHandler(this.BtnGuardarVenta_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(674, 9);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 44;
            // 
            // FrmVenta
            // 
            this.AcceptButton = this.BtnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(886, 554);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.BtnGuardarVenta);
            this.Controls.Add(this.TxtTotalFinal);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblmenu);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtgDeVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtUltimaVenta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDeVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBuscarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DtgDeVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtUltimaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmenu;
        public System.Windows.Forms.TextBox TxtPrecio;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        public System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label lblFinal;
        public System.Windows.Forms.TextBox TxtTotalFinal;
        public System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnGuardarVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}