namespace prac_1
{
	partial class RelojDigital
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelojDigital));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mostrarAnalógicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblHoraActual = new System.Windows.Forms.Label();
			this.ct_HoraActual = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.opcionesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(292, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.acercaDeToolStripMenuItem.Text = "Acerca de";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.colorDeFondoToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.mostrarAnalógicoToolStripMenuItem});
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.opcionesToolStripMenuItem.Text = "Opciones";
			this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
			// 
			// actualizarToolStripMenuItem
			// 
			this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
			this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.actualizarToolStripMenuItem.Text = "Actualizar";
			this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
			// 
			// colorDeFondoToolStripMenuItem
			// 
			this.colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
			this.colorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.colorDeFondoToolStripMenuItem.Text = "Color de fondo";
			this.colorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.colorDeFondoToolStripMenuItem_Click);
			// 
			// fuenteToolStripMenuItem
			// 
			this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
			this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.fuenteToolStripMenuItem.Text = "Fuente";
			this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
			// 
			// mostrarAnalógicoToolStripMenuItem
			// 
			this.mostrarAnalógicoToolStripMenuItem.Name = "mostrarAnalógicoToolStripMenuItem";
			this.mostrarAnalógicoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.mostrarAnalógicoToolStripMenuItem.Text = "Mostrar analógico";
			this.mostrarAnalógicoToolStripMenuItem.Click += new System.EventHandler(this.mostrarAnalógicoToolStripMenuItem_Click);
			// 
			// lblHoraActual
			// 
			this.lblHoraActual.AutoSize = true;
			this.lblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblHoraActual.Location = new System.Drawing.Point(14, 60);
			this.lblHoraActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHoraActual.Name = "lblHoraActual";
			this.lblHoraActual.Size = new System.Drawing.Size(81, 17);
			this.lblHoraActual.TabIndex = 1;
			this.lblHoraActual.Text = "Hora actual";
			// 
			// ct_HoraActual
			// 
			this.ct_HoraActual.Location = new System.Drawing.Point(17, 107);
			this.ct_HoraActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ct_HoraActual.Name = "ct_HoraActual";
			this.ct_HoraActual.ReadOnly = true;
			this.ct_HoraActual.Size = new System.Drawing.Size(145, 20);
			this.ct_HoraActual.TabIndex = 2;
			this.ct_HoraActual.TabStop = false;
			this.ct_HoraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// RelojDigital
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 269);
			this.Controls.Add(this.ct_HoraActual);
			this.Controls.Add(this.lblHoraActual);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(100, 100);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "RelojDigital";
			this.Text = "Reloj digital";
			this.Load += new System.EventHandler(this.RelojDigital_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.Label lblHoraActual;
		private System.Windows.Forms.TextBox ct_HoraActual;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorDeFondoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mostrarAnalógicoToolStripMenuItem;
	}
}

