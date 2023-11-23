using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{

    public partial class Login : Form
    {
        public event EventHandler mievento;
        public event EventHandler mievento2;
        public event EventHandler mievento3;
        public event EventHandler mievento4;
        public event EventHandler mievento5;
        private String usuario; //Definir usuario
        private String clave; //Definir clave
        private String usuario2; //Definir usuario
        private String clave2; //Definir clave
        private String usuario3; //Definir usuario
        private String clave3; //Definir clave
        private int contador = 0; //Definir Contador
        public Login()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.usuario = "Admin";
            this.clave = "Admin321";

            this.usuario2 = "Horario";
            this.clave2 = "Horario23";

            this.usuario3 = "Equipos";
            this.clave3 = "Equipos23";
        }



        private void Clave_txt_TextChanged(object sender, EventArgs e)
        {
            if (Clave_txt.Text == "")//Si clave se encuentra vacio hacer:
            {
                Validar_btn.Enabled = false;//No se pueda apretar el botón aceptar
            }
            else
            {
                Validar_btn.Enabled = true;//Si hay caracteres en la casilla clave, pueda apretar aceptar
            }
        }


        private void Usuario_txt_TextChanged_1(object sender, EventArgs e)
        {
            if (Usuario_txt.Text == "")
            {
                Clave_txt.Enabled = false;
            }
            else
            {
                Clave_txt.Enabled = true;
            }
        }

        private void Validar_btn_Click_1(object sender, EventArgs e)
        {
            String usuario = Usuario_txt.Text;
            String clave = Clave_txt.Text;

            if (usuario == this.usuario && clave == this.clave || usuario == this.usuario2 && clave == this.clave2 || usuario == this.usuario3 && clave == this.clave3)
            {
                mievento5(this, null);
                this.Close();

                if (usuario == this.usuario)
                {
                    mievento2(this, null);
                    this.Close();
                }
                if (usuario == this.usuario2)
                {
                    mievento3(this, null);
                    this.Close();
                }
                if (usuario == this.usuario3)
                {
                    mievento4(this, null);
                    this.Close();
                }
            }
            else
            {
                contador = contador + 1;
                MessageBox.Show("Usuario y/o clave incorrecta, quedan " + (3 - contador) + " intentos");
            }

            if (contador == 3)
            { //Si hace 3 intentos erroneos haga lo siguente: 
                MessageBox.Show("Demasiados intentos");//Mensaje que diga que no tiene mas intentos
                this.Close(); //Se cierra el programa
            }

        }

        private void Cancelar_btn_Click_1(object sender, EventArgs e)
        {
            mievento(this, null); //null = enviar algún parametro // 
            this.Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Clave_txt_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es la tecla deseada (por ejemplo, la tecla Enter)
            if (e.KeyCode == Keys.Enter)
            {
                // Realizar la acción asociada al botón (por ejemplo, llamar al método btnDevolucion_Click)
                Validar_btn_Click_1(sender, e);
            }
        }

        private void Usuario_txt_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es la tecla deseada (por ejemplo, la tecla Enter)
            if (e.KeyCode == Keys.Enter)
            {
                // Realizar la acción asociada al botón (por ejemplo, llamar al método btnDevolucion_Click)
                Validar_btn_Click_1(sender, e);
            }
        }
    }
}