using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_1
{
	public partial class RelojDigital : Form
	{

		//campo privado
		private TimeSpan m_DesfaseHorario = new TimeSpan(0);
		//campo privado m_RelojAnalogico de tipo RelojAnalogico asignando un objeto de su clase
		private RelojAnalogico m_relojAnalogico = new RelojAnalogico();	

		//constructor de reloj digital
		public RelojDigital()
		{
			InitializeComponent();

			//punto 3.1 fuente
			//ct_HoraActual.Font = new Font("Times New Roman", 16, FontStyle.Regular);
			//ct_HoraActual.Font = new Font("Times New Roman", 16, FontStyle.Regular, GraphicsUnit.Pixel);

			//Modificar linea para obtener letra Arial de 12 puntos en negrita
			ct_HoraActual.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

			//punto 3.2 color
			ct_HoraActual.BackColor = Color.White;
			//modificar color de la caja de texto para que sea azul
			ct_HoraActual.ForeColor = Color.Blue;

			//inicializar hora
			MostrarHoraActual();

			//hacer visible reloj Analogico
			m_relojAnalogico.Show(this);

			//evento shown
			this.Shown += RelojdDigital_Shown;

			//configurar boton para que actulice
			//bt_Actualizar.Click += bt_Actualizar_Click;

		}


		private void RelojDigital_Load(object sender, EventArgs e)
		{

		}

		//manejador orden salir
		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//Evento click para mostrar AcercaDe como un dialogo modal
		private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AcercaDe dlg = new AcercaDe();
			dlg.ShowDialog();	//muestra el dialogo de forma modal
		}

		//metodo privado para mostrar la hora
		private void MostrarHoraActual()
		{
			//obtener la hora actual y ajustarla desfase y actulizar la caja de texto
			DateTime hora = DateTime.Now + m_DesfaseHorario;
			ct_HoraActual.Text = hora.ToLongTimeString();

			//actualizar la hora del reloj analogico
			m_relojAnalogico.Hora = hora;

		}
		private void bt_Actualizar_Click(object sender, EventArgs e)
		{
			MostrarHoraActual();
		}

		private void RelojdDigital_Shown(object sender, EventArgs e)
		{
			//ajustar posicion del reloj analogico
			m_relojAnalogico.Location = new Point(this.Location.X + 250 + 10, 100);
		}

		//hacer click para generar evento tick
		private void timer1_Tick(object sender, EventArgs e)
		{
			MostrarHoraActual();
		}
		/*
		private void bt_Mostrar_Click(object sender, EventArgs e)
		{
			//Alternar visibilidad del reloj analogico
			m_relojAnalogico.Visible = !m_relojAnalogico.Visible;

			//Cambiar texto del boton segun la visibilidad del reloj analogico
			bt_Mostrar.Text = m_relojAnalogico.Visible ? "Ocultar analógico" : "Mostrar analógico";
		}
		*/

		//metodo cambiar hora
		internal void CambiarHora(int horas, int minutos, int segundos)
		{
			DateTime actual = DateTime.Now;
			DateTime hora = new DateTime(actual.Year, actual.Month, actual.Day, horas, minutos, segundos);
			m_DesfaseHorario = hora - actual;
			MostrarHoraActual();
		}

		private void bt_ColorFondo_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = ct_HoraActual.BackColor;	//muestra color actual

			//inicializacion del dialogo
			if(colorDialog.ShowDialog() == DialogResult.OK)
			{
				ct_HoraActual.BackColor = colorDialog.Color;	//cambia color de fondo
			}
		}

		private void bt_Fuente_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			fontDialog.Font = ct_HoraActual.Font;	//muestra la fuente actual

			//inicializacion del dialogo
			if(fontDialog.ShowDialog() == DialogResult.OK)
			{
				ct_HoraActual.Font = fontDialog.Font;	//cambio de la fuente
			}
		}

		private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MostrarHoraActual();
		}

		private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (ColorDialog dlg = new ColorDialog())
			{
				dlg.Color = ct_HoraActual.BackColor;
				if(dlg.ShowDialog() == DialogResult.OK)
				{
					ct_HoraActual.BackColor = dlg.Color;    //cambia color de fondo
				}
			}
		}

		private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FontDialog dlg = new FontDialog())
			{
				dlg.Font = ct_HoraActual.Font;
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					ct_HoraActual.Font = dlg.Font;    //cambia fuente 
					ct_HoraActual.ForeColor = Color.Blue;
				}
			}
		}

		private void mostrarAnalógicoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Alternar visibilidad del reloj analogico
			m_relojAnalogico.Visible = !m_relojAnalogico.Visible;

			//Cambiar texto del boton segun la visibilidad del reloj analogico
			mostrarAnalógicoToolStripMenuItem.Checked = m_relojAnalogico.Visible;
		}

		private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			mostrarAnalógicoToolStripMenuItem.Checked = m_relojAnalogico.Visible;
		}
	}
}
