﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_1
{
	public partial class RelojAnalogico : Form
	{

		//campos privados a la clase RelojAnalogico
		private Point m_Centro = new Point();
		private int m_Radio;
		DateTime m_Hora;

		public RelojAnalogico()
		{
			InitializeComponent();

			//inicializar m_Hora con la hora actual
			m_Hora = DateTime.Now;

			//inicializar centro y radio
			ActualizarDimensiones();

			//Evento Resize
			this.Resize += RelojAnalogico_Resize;

			//evento Paint
			this.Paint += RelojAnalogico_Paint;

		}

		private void ActualizarDimensiones()
		{
			m_Centro.X = this.ClientSize.Width / 2;
			m_Centro.Y = this.ClientSize.Height / 2;
			m_Radio = Math.Min(m_Centro.X, m_Centro.Y);
		}

		//propiedad publica
		public DateTime Hora
		{
			set
			{
				m_Hora = value;
				Invalidate();
			}
		}

		private void RelojAnalogico_Paint(object sender, PaintEventArgs e)
		{
			if (m_Radio <= 10)
				return;
			Graphics gfx = e.Graphics;

			Pen lápizNormal = new Pen(Color.Black, 1);
			Pen lápizGordoNegro = new Pen(Color.Black, 2);
			Pen lápizGordoRojo = new Pen(Color.Red, 2);
			Pen lápizMuyGordoAzul = new Pen(Color.Blue, 4);
			HatchBrush brochaGris =
			new HatchBrush(HatchStyle.Sphere, Color.Gray, Color.Gray);
			float alfa, x, y;

			// Llevamos el origen de coordenadas al centro de la ventana
			// y hacemos que el eje "y" aumente hacia arriba
			Matrix matriz = new Matrix(1, 0, 0, -1,
			m_Centro.X, m_Centro.Y);
			gfx.Transform = matriz;
			//Esfera
			float radioEsfera = m_Radio * .95f;
			gfx.DrawEllipse(lápizNormal, -radioEsfera, -radioEsfera,
			radioEsfera * 2, radioEsfera * 2);
			// Marcas de los minutos
			for (int i = 0; i < 60; i++)
			{
				alfa = (float)(i * Math.PI * 2 / 60);
				x = (float)(Math.Sin(alfa) * m_Radio);
				y = (float)(Math.Cos(alfa) * m_Radio);
				if (i % 5 == 0)
					gfx.DrawLine(lápizGordoNegro, x * .85f, y * .85f,
					x * .95f, y * .95f);
				else
					gfx.DrawLine(lápizNormal, x * .9f, y * .9f,
					x * .95f, y * .95f);
			}
			// Manecilla de las horas
			alfa = (float)((m_Hora.Hour % 12) * Math.PI * 2 / 12);
			alfa += (float)((m_Hora.Minute) * Math.PI * 2 / 12 / 60);
			x = (float)(Math.Sin(alfa) * m_Radio);
			y = (float)(Math.Cos(alfa) * m_Radio);
			gfx.DrawLine(lápizMuyGordoAzul, 0, 0, x * .5f, y * .5f);


			// Manecilla de los minutos con lápiz negro...
			alfa = (float)((m_Hora.Minute % 60) * Math.PI * 2 / 60);
			alfa += (float)((m_Hora.Second) * Math.PI * 2 / 60 / 60);
			x = (float)(Math.Sin(alfa) * m_Radio);
			y = (float)(Math.Cos(alfa) * m_Radio);
			gfx.DrawLine(lápizGordoNegro, 0, 0, x * .75f, y * .75f);

			// Manecilla de los segundos con lápiz rojo...
			alfa = (float)((m_Hora.Second % 60) * Math.PI * 2 / 60);
			x = (float)(Math.Sin(alfa) * m_Radio);
			y = (float)(Math.Cos(alfa) * m_Radio);
			gfx.DrawLine(lápizGordoRojo, 0, 0, x * .9f, y * .9f);


			// Botón Central
			float radioBotón = m_Radio * .1f / 2;
			gfx.DrawEllipse(lápizGordoNegro, -radioBotón, -radioBotón,
			radioBotón * 2, radioBotón * 2);
			gfx.FillEllipse(brochaGris, -radioBotón, -radioBotón,
			radioBotón * 2, radioBotón * 2);
		}

		private void RelojAnalogico_Load(object sender, EventArgs e)
		{

		}

		private void relojAnalogico_FormClosing(object sender, FormClosingEventArgs e)
		{
			//comprobar si el dialogo RelojAnalogico esta enfocado
			if(this.Focused)
				//cancelar evento de cierre
					e.Cancel = true;
				
			
		}

		private void RelojAnalogico_Resize(object sender, EventArgs e)
		{
			ActualizarDimensiones();
			Invalidate();
		}

		private void RelojAnalogico_MouseDown(object sender, MouseEventArgs e)
		{
			ArrastrarAgujas(sender, e);
		}

		private void RelojAnalogico_MouseMove(object sender, MouseEventArgs e)
		{
			ArrastrarAgujas(sender, e);
		}

		private void ArrastrarAgujas(object sender, MouseEventArgs e)
		{
			bool botonDerIzq = e.Button == MouseButtons.Right || e.Button == MouseButtons.Left;
			bool pulsadoCentro = (e.X == m_Centro.X && e.Y == m_Centro.Y);
			if (m_Radio < 10 || !botonDerIzq || pulsadoCentro)
				return;

			double alfa;
			int horas = m_Hora.Hour, minutos = m_Hora.Minute;
			int minutosAntes = m_Hora.Minute;
			alfa = Math.Atan2(m_Centro.X - e.X, e.Y - m_Centro.Y);

			//si esta pulsando el boton izquierdo del raton
			if(e.Button == MouseButtons.Left)
			{
				minutos = (int)((alfa / Math.PI / 2 * 12 + 6) * 60);
				horas = (minutos / 60) % 12;
				minutos %= 60;

				//si esta pulsando la tecla ctrl, pasar de PM sumando 12 horas
				if (Control.ModifierKeys == Keys.Control)
					horas += 12;
			}

			//si esta pulsadno el boton derecho del raton
			if (e.Button == MouseButtons.Right)
			{
				//calcular segun posicion del raton
				minutos = (int)(60 * alfa / (2 * Math.PI) + 30) % 60;
			}

			//ajuste de horas minutos
			if (minutos > minutosAntes && minutos - minutosAntes > 30)
				horas--;
			else if (minutos < minutosAntes && minutos - minutosAntes > 30)
				horas++;

			//asegurar que las horas están en el rango correcto
			if (horas == -1)
				horas = 23;
			else if (horas == 24)
				horas = 0;

			//actualiza la hora del reloj digital
			RelojDigital relojD = (RelojDigital)this.Owner;
			relojD.CambiarHora(horas, minutos, m_Hora.Second);
		}
	}
}
