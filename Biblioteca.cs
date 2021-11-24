using System;
using System.Windows.Forms;

namespace ProyecFinal
{
    public partial class Biblioteca : Form
    {
        // declaracion de variables
        private string[,] libros;
        private string[] nombreLibro;
        private string nombreLibr;
        private string[,] autor;
        private string[] nombreAutor;
        private string nombreAut;
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {
            // Simula una base de datos

            libros = new string[10, 2];
            nombreLibro = new string[10];
            nombreAutor = new string[10];

            //__ARCHIVO LIBRO__________________________________

            nombreLibro[0] = "harry potter";
            nombreLibro[1] = "divina comedia";
            nombreLibro[2] = "crimen y castigo";
            nombreLibro[3] = "entender el arte";
            nombreLibro[4] = "sobre la fotografia";
            nombreLibro[5] = "novaceno";
            nombreLibro[6] = "la magia de los numeros";
            nombreLibro[7] = "cero";
            nombreLibro[8] = "el dominio mundial";
            nombreLibro[9] = "polvo en el viento";

            //____ARCHIVO AUTOR___________________________________________________

            nombreAutor[0] = "rowling";
            nombreAutor[1] = "dante";
            nombreAutor[2] = "fiodor dosto";
            nombreAutor[3] = "dana arnold";
            nombreAutor[4] = "susan sont";
            nombreAutor[5] = "james lovelock";
            nombreAutor[6] = "joaquin navarro";
            nombreAutor[7] = "charles seifel";
            nombreAutor[8] = "pedro banos";
            nombreAutor[9] = "hugo coya";
          

            libros[0, 0] = "seccion de fantasia";
            libros[0, 1] = "4";
            
            libros[1, 0] = "seccion de literatura";
            libros[1, 1] = "2";

            libros[2, 0] = "seccion de literatura";
            libros[2, 1] = "6";

            libros[3, 0] = "seccion de arte";
            libros[3, 1] = "5";

            libros[4, 0] = "seccion de arte";
            libros[4, 1] = "3";

            libros[5, 0] = "seccion de tecnologia";
            libros[5, 1] = "1";

            libros[6, 0] = "seccion de matematicas";
            libros[6, 1] = "7";

            libros[7, 0] = "seccion de matematicas";
            libros[7, 1] = "3";

            libros[8, 0] = "seccion de geografia";
            libros[8, 1] = "2";

            libros[9, 0] = "seccion de geografia";
            libros[9, 1] = "4";

        }

        private void btnbuscarlibro_Click(object sender, EventArgs e)
        {
            
            if (txtbuscarlibro.Text != "") // permite que salga error o no encontrado 
            {
                nombreLibr = txtbuscarlibro.Text;
                nombreLibr.ToLower(); // pone el texto en minusculas

                for (int i = 0; i < nombreLibro.Length; i++)
                {
                    if (nombreLibro[i] == nombreLibr)
                    {
                        txtnombrelibro.Text = nombreLibr;
                        txtautor.Text = nombreAutor[i];
                    }
                }

                for (int f = 0; f < nombreLibro.GetLength(0); f++)
                {
                    for (int c = 0; c < libros.GetLength(1); c++)
                    {
                        if (nombreLibro[f] == nombreLibr)
                        {

                            if (c == 0)
                            {
                                txtubicacion.Text = libros[f, c];
                            }

                            if (c == 1)
                            {
                                txtcantlibros.Text = libros[f, c];
                            }
                        }

                    }
                }


            }
            else
            {
                MessageBox.Show("NO ENCONTRADO");
            }
        }

        private void btnbuscarautor_Click(object sender, EventArgs e)
        {
            nombreAut = txtbuscarautor.Text;
            nombreAut.ToLower(); // pone el texto en minusculas

            if (txtbuscarautor.Text != "")
            {


                for (int i = 0; i < nombreAutor.Length; i++)
                {
                    if (nombreAutor[i] == nombreAut)
                    {
                        txtnombrelibro.Text = nombreLibro[i];
                        txtautor.Text = nombreAut;
                    }
                }

                for (int f = 0; f < nombreAutor.GetLength(0); f++)
                {
                    for (int c = 0; c < libros.GetLength(1); c++)
                    {
                        if (nombreAutor[f] == nombreAut)
                        {

                            if (c == 0)
                            {
                                txtubicacion.Text = libros[f, c];
                            }

                            if (c == 1)
                            {
                                txtcantlibros.Text = libros[f, c];
                            }
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("NO ENCONTRADO");
            }
        }
    }
}
