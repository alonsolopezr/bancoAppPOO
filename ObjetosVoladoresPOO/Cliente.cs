using System;
namespace BancoApp
{
	public class Cliente
	{
		//propiedades
		private string nombre;
		private string apellido;
		private DateTime fechaDeNacimiento;
		private BancoEnum banco;

		//accesores publicos de las propiedades
		public string Nombre {
			get { return this.nombre; }
			set { this.nombre = value; }
		}
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDeNacimiento
		{
			get => fechaDeNacimiento;
			set => fechaDeNacimiento = value;
		}
        public BancoEnum Banco { get => banco; set => banco = value; }


		//constructor Default
		/// <summary>
		/// Crea un nuevo cliente
		/// </summary>
		/// <param name="nombre">Capturar todoa los nombres del cliente</param>
		/// <param name="apellido">Capturar los apellidos del cliente, incluyendo paterno y/o materno</param>
		/// <param name="fechaDeNacimiento">En formato AAAA-mm-dd</param>
		/// <param name="banco">De la seleccion de BANCOS del ENUM BancoEnum</param>
        public Cliente(string nombre, string apellido, DateTime fechaDeNacimiento, BancoEnum banco )
		{
			//inicializamos los valores del nuevo cliente en CREACION
			this.nombre = nombre;
			this.apellido = apellido;
			this.fechaDeNacimiento = fechaDeNacimiento;
			this.banco = banco;

		}

		public string rfc {
			get { return this.calculaRFCTexto(); }
		}


		private string calculaRFCTexto()
		{
			//this.apellido
			//LOPEZ ROMO = TXT del RFc = LOR              J
			//01234578910                01[idxEspBlac+1] 0
			int idxEspacioBlanco = this.apellido.IndexOf(" ");//sacamos idx de escpacio en blanco
															  //nombre esta en this.nombre
															  //JOSE ALONSO
															  //012345678910
			return  this.apellido[0].ToString()+ this.apellido[1].ToString() + this.apellido[idxEspacioBlanco + 1].ToString() + this.nombre[0]+"";
        }

		private int operacionesFecha()
		{
			DateTime res = DateTime.Now;
			int edad=(int)(DateTime.Now - this.fechaDeNacimiento).TotalDays/365;
			{
				Console.WriteLine("nacimiento en el pasado ="+edad);

			}
			return edad; 
		}

        public override string ToString()
        {
			return $"Este cliente se {this.nombre} {this.apellido}, nació el {this.fechaDeNacimiento} y su banco es {this.banco}";
        }


    }
}

