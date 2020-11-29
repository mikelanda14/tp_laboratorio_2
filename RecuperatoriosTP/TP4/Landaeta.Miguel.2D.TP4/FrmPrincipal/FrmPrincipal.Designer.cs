namespace FrmPrincipal
{
    partial class FrmPrincipal
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
            this.DgListaProductos = new System.Windows.Forms.DataGridView();
            this.DgVenta = new System.Windows.Forms.DataGridView();
            this.LblVenta = new System.Windows.Forms.Label();
            this.LblListaProductos = new System.Windows.Forms.Label();
            this.LblMontoTotal = new System.Windows.Forms.Label();
            this.LblImporte = new System.Windows.Forms.Label();
            this.BtnCobrar = new System.Windows.Forms.Button();
            this.BtnSim = new System.Windows.Forms.Button();
            this.BtnListaXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // DgListaProductos
            // 
            this.DgListaProductos.AllowUserToAddRows = false;
            this.DgListaProductos.AllowUserToDeleteRows = false;
            this.DgListaProductos.AllowUserToResizeColumns = false;
            this.DgListaProductos.AllowUserToResizeRows = false;
            this.DgListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgListaProductos.Location = new System.Drawing.Point(33, 77);
            this.DgListaProductos.Name = "DgListaProductos";
            this.DgListaProductos.Size = new System.Drawing.Size(269, 313);
            this.DgListaProductos.TabIndex = 0;
            this.DgListaProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgListaProductos_CellMouseClick);
            // 
            // DgVenta
            // 
            this.DgVenta.AllowUserToAddRows = false;
            this.DgVenta.AllowUserToDeleteRows = false;
            this.DgVenta.AllowUserToResizeColumns = false;
            this.DgVenta.AllowUserToResizeRows = false;
            this.DgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVenta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgVenta.Location = new System.Drawing.Point(370, 77);
            this.DgVenta.Name = "DgVenta";
            this.DgVenta.Size = new System.Drawing.Size(276, 313);
            this.DgVenta.TabIndex = 1;
            // 
            // LblVenta
            // 
            this.LblVenta.AutoSize = true;
            this.LblVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVenta.Location = new System.Drawing.Point(492, 39);
            this.LblVenta.Name = "LblVenta";
            this.LblVenta.Size = new System.Drawing.Size(59, 24);
            this.LblVenta.TabIndex = 2;
            this.LblVenta.Text = "Venta";
            // 
            // LblListaProductos
            // 
            this.LblListaProductos.AutoSize = true;
            this.LblListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaProductos.Location = new System.Drawing.Point(102, 39);
            this.LblListaProductos.Name = "LblListaProductos";
            this.LblListaProductos.Size = new System.Drawing.Size(95, 24);
            this.LblListaProductos.TabIndex = 3;
            this.LblListaProductos.Text = "Productos";
            // 
            // LblMontoTotal
            // 
            this.LblMontoTotal.AutoSize = true;
            this.LblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoTotal.Location = new System.Drawing.Point(404, 393);
            this.LblMontoTotal.Name = "LblMontoTotal";
            this.LblMontoTotal.Size = new System.Drawing.Size(109, 24);
            this.LblMontoTotal.TabIndex = 4;
            this.LblMontoTotal.Text = "Monto Total";
            // 
            // LblImporte
            // 
            this.LblImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblImporte.AutoSize = true;
            this.LblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImporte.Location = new System.Drawing.Point(587, 393);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(20, 24);
            this.LblImporte.TabIndex = 5;
            this.LblImporte.Text = "0";
            this.LblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCobrar
            // 
            this.BtnCobrar.Location = new System.Drawing.Point(531, 420);
            this.BtnCobrar.Name = "BtnCobrar";
            this.BtnCobrar.Size = new System.Drawing.Size(104, 25);
            this.BtnCobrar.TabIndex = 6;
            this.BtnCobrar.Text = "Cobrar";
            this.BtnCobrar.UseVisualStyleBackColor = true;
            this.BtnCobrar.Click += new System.EventHandler(this.BtnCobrar_Click);
            // 
            // BtnSim
            // 
            this.BtnSim.Location = new System.Drawing.Point(571, 25);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(75, 23);
            this.BtnSim.TabIndex = 7;
            this.BtnSim.Text = "Simulacion";
            this.BtnSim.UseVisualStyleBackColor = true;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click);
            // 
            // BtnListaXml
            // 
            this.BtnListaXml.Location = new System.Drawing.Point(33, 421);
            this.BtnListaXml.Name = "BtnListaXml";
            this.BtnListaXml.Size = new System.Drawing.Size(134, 24);
            this.BtnListaXml.TabIndex = 8;
            this.BtnListaXml.Text = "Cargar Productos XML";
            this.BtnListaXml.UseVisualStyleBackColor = true;
            this.BtnListaXml.Click += new System.EventHandler(this.BtnListaXml_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(680, 457);
            this.Controls.Add(this.BtnListaXml);
            this.Controls.Add(this.BtnSim);
            this.Controls.Add(this.BtnCobrar);
            this.Controls.Add(this.LblImporte);
            this.Controls.Add(this.LblMontoTotal);
            this.Controls.Add(this.LblListaProductos);
            this.Controls.Add(this.LblVenta);
            this.Controls.Add(this.DgVenta);
            this.Controls.Add(this.DgListaProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.Text = "Landaeta.Miguel.2D";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgListaProductos;
        private System.Windows.Forms.DataGridView DgVenta;
        private System.Windows.Forms.Label LblVenta;
        private System.Windows.Forms.Label LblListaProductos;
        private System.Windows.Forms.Label LblMontoTotal;
        private System.Windows.Forms.Label LblImporte;
        private System.Windows.Forms.Button BtnCobrar;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Button BtnListaXml;
    }
}

