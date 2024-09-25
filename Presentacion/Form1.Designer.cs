
namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCpro = new System.Windows.Forms.TextBox();
            this.txtPunit = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtDsto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combpago = new System.Windows.Forms.ComboBox();
            this.combAlmacen = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(120, 29);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(112, 22);
            this.txtCodCli.TabIndex = 0;
            this.txtCodCli.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // txtnombCli
            // 
            this.txtnombCli.Location = new System.Drawing.Point(268, 29);
            this.txtnombCli.Name = "txtnombCli";
            this.txtnombCli.Size = new System.Drawing.Size(262, 22);
            this.txtnombCli.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Almacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descuento";
            // 
            // txtCpro
            // 
            this.txtCpro.Location = new System.Drawing.Point(134, 150);
            this.txtCpro.Name = "txtCpro";
            this.txtCpro.Size = new System.Drawing.Size(112, 22);
            this.txtCpro.TabIndex = 10;
            // 
            // txtPunit
            // 
            this.txtPunit.Location = new System.Drawing.Point(134, 188);
            this.txtPunit.Name = "txtPunit";
            this.txtPunit.Size = new System.Drawing.Size(112, 22);
            this.txtPunit.TabIndex = 11;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(134, 225);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(112, 22);
            this.txtCant.TabIndex = 12;
            // 
            // txtDsto
            // 
            this.txtDsto.Location = new System.Drawing.Point(134, 262);
            this.txtDsto.Name = "txtDsto";
            this.txtDsto.Size = new System.Drawing.Size(112, 22);
            this.txtDsto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pago";
            // 
            // combpago
            // 
            this.combpago.FormattingEnabled = true;
            this.combpago.Location = new System.Drawing.Point(531, 147);
            this.combpago.Name = "combpago";
            this.combpago.Size = new System.Drawing.Size(121, 24);
            this.combpago.TabIndex = 15;
            // 
            // combAlmacen
            // 
            this.combAlmacen.FormattingEnabled = true;
            this.combAlmacen.Location = new System.Drawing.Point(125, 69);
            this.combAlmacen.Name = "combAlmacen";
            this.combAlmacen.Size = new System.Drawing.Size(121, 24);
            this.combAlmacen.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combAlmacen);
            this.Controls.Add(this.combpago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDsto);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtPunit);
            this.Controls.Add(this.txtCpro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodCli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCpro;
        private System.Windows.Forms.TextBox txtPunit;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtDsto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combpago;
        private System.Windows.Forms.ComboBox combAlmacen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

