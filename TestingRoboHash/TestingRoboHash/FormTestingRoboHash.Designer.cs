namespace TestingRoboHash
{
    partial class FormTestingRoboHash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewButton = new System.Windows.Forms.Button();
            this.ImageGridView = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPicture = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewButton
            // 
            this.ViewButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ViewButton.Location = new System.Drawing.Point(30, 23);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(100, 60);
            this.ViewButton.TabIndex = 0;
            this.ViewButton.Text = "En Un GridView";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ImageGridView
            // 
            this.ImageGridView.AllowUserToAddRows = false;
            this.ImageGridView.AllowUserToDeleteRows = false;
            this.ImageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColURL,
            this.ColPicture});
            this.ImageGridView.Location = new System.Drawing.Point(30, 89);
            this.ImageGridView.Name = "ImageGridView";
            this.ImageGridView.ReadOnly = true;
            this.ImageGridView.Size = new System.Drawing.Size(644, 316);
            this.ImageGridView.TabIndex = 1;
            // 
            // ColNombre
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.ColNombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColNombre.DividerWidth = 1;
            this.ColNombre.HeaderText = "Un Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColURL
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.ColURL.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColURL.DividerWidth = 1;
            this.ColURL.HeaderText = "URL Imagen";
            this.ColURL.Name = "ColURL";
            this.ColURL.ReadOnly = true;
            this.ColURL.Width = 150;
            // 
            // ColPicture
            // 
            this.ColPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPicture.HeaderText = "Una Imagen";
            this.ColPicture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColPicture.Name = "ColPicture";
            this.ColPicture.ReadOnly = true;
            // 
            // FormTestingRoboHash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(703, 417);
            this.Controls.Add(this.ImageGridView);
            this.Controls.Add(this.ViewButton);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormTestingRoboHash";
            this.Text = "Testing RoboHash Pictures";
            ((System.ComponentModel.ISupportInitialize)(this.ImageGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.DataGridView ImageGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColURL;
        private System.Windows.Forms.DataGridViewImageColumn ColPicture;
    }
}

