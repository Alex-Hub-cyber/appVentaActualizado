
namespace SistemaVentasP2.VISTA
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstadoProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateProducto = new System.Windows.Forms.Button();
            this.btnRemoveProducto = new System.Windows.Forms.Button();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.lblproducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(72, 209);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(98, 30);
            this.btnAgregarProducto.TabIndex = 13;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estado del producto :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio del producto :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre del producto :";
            // 
            // txtEstadoProducto
            // 
            this.txtEstadoProducto.Location = new System.Drawing.Point(187, 154);
            this.txtEstadoProducto.Name = "txtEstadoProducto";
            this.txtEstadoProducto.Size = new System.Drawing.Size(200, 20);
            this.txtEstadoProducto.TabIndex = 9;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(187, 110);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(200, 20);
            this.txtPrecioProducto.TabIndex = 8;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(187, 69);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 20);
            this.txtProducto.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(427, 193);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnUpdateProducto
            // 
            this.btnUpdateProducto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProducto.Location = new System.Drawing.Point(300, 208);
            this.btnUpdateProducto.Name = "btnUpdateProducto";
            this.btnUpdateProducto.Size = new System.Drawing.Size(98, 31);
            this.btnUpdateProducto.TabIndex = 18;
            this.btnUpdateProducto.Text = "Actualizar";
            this.btnUpdateProducto.UseVisualStyleBackColor = true;
            this.btnUpdateProducto.Click += new System.EventHandler(this.btnUpdateProducto_Click);
            // 
            // btnRemoveProducto
            // 
            this.btnRemoveProducto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProducto.Location = new System.Drawing.Point(187, 208);
            this.btnRemoveProducto.Name = "btnRemoveProducto";
            this.btnRemoveProducto.Size = new System.Drawing.Size(98, 31);
            this.btnRemoveProducto.TabIndex = 17;
            this.btnRemoveProducto.Text = "Eliminar";
            this.btnRemoveProducto.UseVisualStyleBackColor = true;
            this.btnRemoveProducto.Click += new System.EventHandler(this.btnRemoveProducto_Click);
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(393, 69);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(50, 20);
            this.txtidProducto.TabIndex = 19;
            this.txtidProducto.Visible = false;
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.lblproducto.Location = new System.Drawing.Point(67, 20);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(331, 25);
            this.lblproducto.TabIndex = 20;
            this.lblproducto.Text = "Ingrese los datos del producto";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(451, 473);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.txtidProducto);
            this.Controls.Add(this.btnUpdateProducto);
            this.Controls.Add(this.btnRemoveProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstadoProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstadoProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateProducto;
        private System.Windows.Forms.Button btnRemoveProducto;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblproducto;
    }
}