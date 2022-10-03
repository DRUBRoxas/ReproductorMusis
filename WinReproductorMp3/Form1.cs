using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;
using System.Collections.Generic;
using System.Linq;
//using Microsoft.DirectX.AudioVideoPlayback;

namespace WinReproductorMp3
{
    public partial class Form1 : Form
    {
        private readonly int vol = 1;   //Volumen inicial al cargar el programa
        public string[] ArchivosMP3 = new string[100000];    //Lista de canciones
        public string[] ArchivosMP3Copia = new string[100000];
        public string[] RutasArchivos = new string[100000];   //Ruta de la canción
        public bool Bucle = false;      //Variable que controla el bucle de la musica
        public bool Aleatorio = false;  //Variable que controla el aleatorio del la música
        private string tag_Artist = "", tag_Title = "", title = "", tag_Album = "", Album = "";
        private Image tag_Imagen;
        public List<string> favoritos = new List<string>();
        public List<string> lista_Canciones = new List<string>();
        private readonly MediaPlayer Reproductor = new MediaPlayer();   //Objeto encargado de reproducir el archivo mp3
        private static TimeSpan tm; //Objeto encargado de guardar el tiempo transcurrido de la canción (Se inicia a 0)

        //private Video video;
        internal static class NativeMethods
        {
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            internal static extern void ReleaseCapture();

            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            internal static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse); // width of ellipse)

        public Form1()
        {
            InitializeComponent();
        }
        /**
         * Función con la cual se despliega el menu para añadir una nueva canción a la lista de reproducción.
         * Permite añadir mas de un archivo a la vez.
         */
        public void AbrirArchivo()
        {
            string path;
            path = Path.GetFullPath("C:/Users/erafa/OneDrive/Escritorio/ReproductorMultimedia/WinReproductorMp3/Musica");
            var BuscarArchivosMP3 = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Archivo mp3|*.mp3|Archivo wav|*.wav|Archivo mp4|*.mp4|Todos los Archivos|*.*",
                
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                FilterIndex = 1
            };
            if (BuscarArchivosMP3.ShowDialog() == DialogResult.OK)
            {
                ArchivosMP3 = BuscarArchivosMP3.SafeFileNames;
                ArchivosMP3Copia = BuscarArchivosMP3.SafeFileNames;
                RutasArchivos = BuscarArchivosMP3.FileNames;
                foreach (var ArchivoMP3 in ArchivosMP3)
                {
                    Lista_Canciones.Items.Add(ArchivoMP3);
                    lista_Canciones.Add(ArchivoMP3);
                }
                Lista_Canciones.SelectedIndex = 0;
                
            }

        }

        private void AplicarTagCancion()
        {
            //Tag del título de la canción
            TagLib.File cancion_Tag = TagLib.File.Create(RutasArchivos[Lista_Canciones.SelectedIndex]);

            if (cancion_Tag.Tag.Title != null && cancion_Tag.Tag.Title.Length > 1)
            {
                title = cancion_Tag.Tag.Title;
                LblCancion.Text = title;
            }
            else
            {
                cancion_Tag.Tag.Title = "Título No Disponible";
            }
            //Tag del album al que pertenece la canción
            //Se toman los dos casos en el que no tenga Album o en el que si tenga
            if (cancion_Tag.Tag.Album == null)
            {
                Album = "Album Desconocido";
            }
            else
            {
                Album = cancion_Tag.Tag.Album;
            }
            //Tag de la Imagen de la Canción.
            if (cancion_Tag.Tag.Pictures.Length != 0)
            {
                MemoryStream pic = new MemoryStream(cancion_Tag.Tag.Pictures[0].Data.Data);
                tag_Imagen = Image.FromStream(pic);
                ImagenSong.BackgroundImage = tag_Imagen; 
                
            } else 
            {
                ImagenSong.BackgroundImage = Properties.Resources.song_PX;
            }
            //Tag Artista de la cancion
            if (cancion_Tag.Tag.Performers.Length == 0)
            {
                tag_Artist = "Autor Desconocido";
                foreach (string str in cancion_Tag.Tag.Performers)
                {
                    tag_Artist += str;
                    tag_Artist += "; ";
                }
                tag_Artist = tag_Artist.Substring(0, tag_Artist.Length);
                LblAutor.Text = tag_Artist;
            }
            else
            {
                string[] performers = cancion_Tag.Tag.Performers;
                if (title.Length > 2 && Album != null && performers[0].Length > 1)
                {
                    tag_Title = title;
                    tag_Artist = performers[0].ToString();
                    tag_Album = Album;
                    LblAutor.Text = tag_Artist;//ARTISTA
                    LblCancion.Text = tag_Title;//TITULO
                    LblAlbum.Text = tag_Album;//ALBUM
                }
            }
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }
        /**
         * Boton para pasar a la siguinte canción
         */
        private void SiguienteCancion(object sender, EventArgs e)
        {
            FavBoton.Enabled = true;
            if (Reproductor.HasAudio)
            {
                if (Lista_Canciones.SelectedIndex < Lista_Canciones.Items.Count - 1)
                {
                    if (Aleatorio == true)//Solo se haria en caso de que este activado el boton aleatorio (Saltaria a una cancion aleatoriamente de la playlist).
                    {
                        Random r = new Random();
                        int it = r.Next(0, Lista_Canciones.Items.Count);
                        Lista_Canciones.SelectedIndex = it;
;                   } else
                    {
                        Lista_Canciones.SelectedIndex += 1;
                    }
                    AplicarTagCancion();
                    Reproductor.Open(new Uri(RutasArchivos[Lista_Canciones.SelectedIndex].ToString()));// Ruta del archivo
                    Lista_Canciones.Update();//Actualizar la lista de Canciones
                }
                else ///Esto es si la cancion que quieras pasar es la última
                {
                    
                    if (Bucle == true)
                    {
                        Lista_Canciones.SelectedIndex = 0;
                        AplicarTagCancion();
                        Reproductor.Open(new Uri(RutasArchivos[Lista_Canciones.SelectedIndex].ToString()));
                        Lista_Canciones.Update();
                        
                    }
                    else
                    {
                        LblTiempoTranscurrido.Text = "--:--";// Tiempo pasa a 0
                        TmTiempo.Stop();//Se de tiene el timer
                        tm = TimeSpan.Zero;
                        Reproductor.Stop();//Se detiene el reproductor de música
                        TmTiempo.Enabled = false;
                        Reproductor.Stop();
                    } 
                }
            }
        }
        /**
         * Boton para pasar a la canción anterior.
         */
        private void CancionAnterior(object sender, EventArgs e)
        {
            FavBoton.Enabled = true;
            if (Lista_Canciones.SelectedIndex != 0)
            {
                if (Aleatorio == true) //Esto se haria solamente si el boton de Aleatorio se encuentra activado (Salta a una cancion aleatoria de la playlist).
                {
                    Random r = new Random();
                    int it = r.Next(0, Lista_Canciones.Items.Count);
                    Lista_Canciones.SelectedIndex = it;
                    
                }
                else
                {
                    Lista_Canciones.SelectedIndex -= 1;
                }
                AplicarTagCancion();
                Reproductor.Open(new Uri(RutasArchivos[Lista_Canciones.SelectedIndex].ToString()));// Ruta del archivo
                Lista_Canciones.Update();//Actualizar la lista de Canciones
                
            }
            else
            {
                if (Bucle == true)
                {
                    Lista_Canciones.SelectedIndex = Lista_Canciones.Items.Count - 1;
                    AplicarTagCancion();
                    Reproductor.Open(new Uri(RutasArchivos[Lista_Canciones.SelectedIndex].ToString()));
                    Lista_Canciones.Update();
                }
                else 
                {
                    Lista_Canciones.SelectedIndex = 0;
                    Lista_Canciones.Update();
                    //Cuando sea la primera canción inicie la canción desde el principio.
                    Reproductor.Position = TimeSpan.Zero;
                    Reproductor.Play();
                }
                
            }
        }
        /**
         * Función que actualiza el tiempo de las canciones
         * Es un evento.
         */
        private void EvtActualizarTiempo(object sender, EventArgs e)
        {
            tm = Reproductor.Position;//Posicion del timespan del reproductor
            LblTiempoTranscurrido.Text = tm.ToString(@"mm\:ss");//Tiempo transcurrido de la canción se muestra en el label.
            
            if (Reproductor.NaturalDuration.HasTimeSpan == true)
            {
                MtStatus.Maximum = (int)Reproductor.NaturalDuration.TimeSpan.TotalSeconds;//LO QUE DURA LA CANCION
                MtStatus.Value = (int)Reproductor.Position.TotalSeconds;//POSICION EN MILISEGUNDOS
                LblFinal.Text = Reproductor.NaturalDuration.TimeSpan.ToString(@"mm\:ss");// MUESTRA LA DURACION TOTAL DE LA CANCION ACTUAL
                
            }
            else
            {
                MtStatus.Value = 0;
                LblFinal.Text = "--:--";// CERO
            }
        }
        /**
         * Boton para detener la repodución de la música.
         */
        private void BotonDetener_Click(object sender, EventArgs e)
        {
            LblTiempoTranscurrido.Text = "--:--";
            LblFinal.Text = "--:--";
            MtStatus.Value = 0;// La barra de estado se ubica al inicio
            BotonPausa.Visible = false;//Desaparece el boton de pausa y aparece el boton de play.
            TmTiempo.Stop();//Se detendrá eñ timer
            TmTiempo.Enabled = false;//Desbailitar el temporizador.
            tm = TimeSpan.Zero;//TimeSpan = 0
            Reproductor.Stop();
        }
        /**
         * Boton que hará la funcion de pausar la reprodución de una canción
         */
        private void BotonPausa_Click(object sender, EventArgs e)
        {
            BotonPausa.Visible = false; 
            tm = Reproductor.Position;//Desaparece el boton de pausa y aparece el boton de play.
            Reproductor.Pause();
        }
        /**
         * Boton que hará la funcion de reproducir la canción
         */
        private void BotonPlay_Click(object sender, EventArgs e)
        {
            if (Lista_Canciones.Items.Count != 0)//Lista de canciones no esta vacia
            {
                BotonPausa.Visible = true;    // Boton de pausa se hace visible
                LblCancion.Text = Path.GetFileNameWithoutExtension(ArchivosMP3[Lista_Canciones.SelectedIndex]);
                TmTiempo.Enabled = true;
                TmTiempo.Start();
                Reproductor.Open(new Uri(RutasArchivos[Lista_Canciones.SelectedIndex]));
                Reproductor.Position = tm;//Empieza la cancion por la posicion en la que se quedó
                Reproductor.Play();//Reproduce la canción que se encuentra seleccionada en el momento en el que se quedó
                if (Lista_Canciones.SelectedItem.ToString() == "*.mp4")
                {
                    ImagenSong.Visible = false;
                    /*video = new Video(Lista_Canciones.SelectedItem.ToString(), false);
                    video.Owner = Video;
                    video.Play();*/
                }
                Reproductor.MediaEnded += SiguienteCancion;//Avanza a la siguiente canción en la lista si la actual se ha terminado.
            }
            else
            {
                if (Bucle == true)
                {
                    Lista_Canciones.SelectedIndex = 0;
                    AplicarTagCancion();
                    Reproductor.Open(new Uri(RutasArchivos[Lista_Canciones.SelectedIndex].ToString()));
                    Lista_Canciones.Update();
                }
                else
                {
                    LblTiempoTranscurrido.Text = "--:--";// Tiempo pasa a 0
                    TmTiempo.Stop();//Se de tiene el timer
                    tm = TimeSpan.Zero;
                    Reproductor.Stop();//Se detiene el reproductor de música
                    TmTiempo.Enabled = false;
                    Reproductor.Stop();
                }
            }
        }
        /**
         * Esta función te reproduce una canción de la lista si le haces click encima.
         */
        private void Lista_Canciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            FavBoton.Enabled = true;
            TmTiempo.Stop();
            //Reíniciamos el valor de tiempo que lleva transcurrido la canción actual
            tm = TimeSpan.Zero;
            AplicarTagCancion();
            LblCancion.Text = Path.GetFileNameWithoutExtension(ArchivosMP3[Lista_Canciones.SelectedIndex]);
            BotonPlay.PerformClick();//Se reproduce la canción que selecciones
        }
        /**
         * Funcion para avancar o retroceder la cancion en el TrackBar
         */
        private void MtStatus_Scroll(object sender, EventArgs e)
        {
            Reproductor.Position = TimeSpan.FromSeconds(MtStatus.Value);
        }
        /** MtVolumen_ValueChanged.
         * Funcion para cambiar el estado de la barra de sonido, el numero del volumen y la imagen del altavoz
         * Se tienen distintos condicionales para la modificacion de la imagen.
         */
        private void MtVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.Volume = MtVolumen.Value / 100.0f;
            LblVol.Text = Reproductor.Volume.ToString();//Muestra el valor en la barra
            BtnVolumen.BackgroundImage = Properties.Resources.low_volume10;
            LblVolumen.Text = "VOLUMEN";

            if (Reproductor.Volume > 0.65)
            {
                BtnVolumen.BackgroundImage = Properties.Resources.audio_100px;
            }
            else if (Reproductor.Volume > 0.36)
            {
                BtnVolumen.BackgroundImage = Properties.Resources.voice100;
            }
            else if (Reproductor.Volume == 0)
            {
                BtnVolumen.BackgroundImage = Properties.Resources.mute_100;
                LblVolumen.Text = "SILENCIO";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LblVol.Text = (MtVolumen.Value = (int)(Reproductor.Volume = vol)).ToString();
            BtnVolumen.BackgroundImage = Properties.Resources.low_volume10;
        }

        private void PanelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCapture();
            NativeMethods.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void PanelTagLib_MouseMove(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCapture();
            NativeMethods.SendMessage(Handle, 0x112, 0xf012, 0);
        }


        private void MtVolumen_Scroll(object sender, EventArgs e)
        {
            Reproductor.Volume = MtVolumen.Value / 100.0f;
            LblVol.Text = Reproductor.Volume.ToString();
        }

        /**
         * Boton bucle descativado, pulsar para activar.
         * Cuando se pulsa este boton se activa el bucle en el reproductor.
         */
        private void Boton_Bucle_Click(object sender, EventArgs e)
        {
            BotonBucleOn.Visible = true;
            BotonBucleOff.Visible = false;
            Bucle = true;
        }

        /**
         * Boton bucle activado, pulsar para desactivar.
         * Cuando se pulsa este boton se desactiva el bucle en el reproductor.
         */
        private void Boton_Bucle_On_Click(object sender, EventArgs e)
        {
            BotonBucleOn.Visible = false;
            BotonBucleOff.Visible = true;
            Bucle = false;
        }

        /**
         * Boton aleatorio descativado, pulsar para activar.
         * Cuando se pulsa este boton se activa el aleatorio en el reproductor.
         */
        private void Boton_Aleatorio_Click(object sender, EventArgs e)
        {

            Aleatorio = true;
            BotonAleatorioOn.Visible = true;
            BotonAleatorioOff.Visible = false;

        }

        /**
         * Boton aleatorio activado, pulsar para desactivar.
         * Cuando se pulsa este boton se desactiva el aleatorio en el reproductor.
         */
        private void BotonAleatorioOn_Click(object sender, EventArgs e)
        {
            Aleatorio = false;
            BotonAleatorioOn.Visible = false;
            BotonAleatorioOff.Visible = true;
        }

        /**BotonSalir_MouseEnter. Funcion de cambio de imagen 
         * al poner el ratón encima del botón.
         * 
         */
        private void BotonSalir_MouseEnter(object sender, EventArgs e)
        {
            BotonSalir.BackgroundImage = Properties.Resources.closewindow_hover;
        }

        /**BotonSalir_MouseLeave. Funcion de cambio de imagen
         * al retirar el ratón del botón de salir se cambiaría de nuevo a la imagen original.
         * 
         */
        private void BotonSalir_MouseLeave(object sender, EventArgs e)
        {
            BotonSalir.BackgroundImage = Properties.Resources.closewindow_click;
        }

        /**BtnVerFavoritos.
         * Se encarga de añadir la lista de favoritos al fichero Favorite.txt
         */
        private void BtnVerFavoritos_Click(object sender, EventArgs e)
        {
            using (StreamReader read = new StreamReader(@"C:\Users\erafa\OneDrive\Escritorio\ReproductorMultimedia\WinReproductorMp3\Storage\Favorite.txt"))
            {
                string line;
                while ((line = read.ReadLine() )!= null)
                {
                    Lista_Favoritos.Items.Add(line);
                }
            }
        }

        /**Fav_MouseEnter.
         * Al entrar el ratón en el botón de Favoritos (La estrella en la interfaz) se pondría de color amarillo (Cambio de imagen)
         */
        private void Fav_MouseEnter(object sender, EventArgs e)
        {
            FavBoton.BackgroundImage = Properties.Resources.FavActivar;
        }

        /**Fav_MouseLeave.
         * Al salir del botón de Favoritos se volveria a poner la imagen original en el recuadro.
         */
        private void FavBoton_MouseLeave(object sender, EventArgs e)
        {
            FavBoton.BackgroundImage = Properties.Resources.Fav;
        }

        /**FavBoton_Click.
         * Funcion: al pulsar el boton de Favoritos la canción que se encuetra seleccionada en la Lista_Canciones (Lista de reproducción),
         * se añade a la lista de favoritos.
         */
        private void FavBoton_Click(object sender, EventArgs e)
        {
            FavBoton.Enabled = false; //Esto impide que la misma canción se puede añadir 2 veces a la vez. Ya que bloquea el Boton de Favoritos
            Lista_Favoritos.Items.Add(Lista_Canciones.SelectedItem.ToString());
            favoritos.Add(Lista_Canciones.SelectedItem.ToString()); 
        }

        /**GuardarListas_Click.
         * Al pulsar el botón de Guardar Listas. Se crea un .geo en la caparpeta "..\ReproductorMultimedia\WinReproductorMp3\bin\Debug" donde estan guardados
         * todos los archivos de .geo para luego el uso de esas playlist.
         */
        private void GuardarListas_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, 10000);
            string l = "lista" + rand;
            FileStream archivo = new FileStream(l + ".geo", FileMode.Append, FileAccess.Write);
            //Empieza a escribir en el achivo con nombre "listaN.geo" en el que N es un numero aleatorio.
            StreamWriter Escribir = new StreamWriter(archivo); 
            String[] matriz = new String[Lista_Canciones.Items.Count];
            //Se guardan todas las rutas de los archivos que quieres guardar como imágenes.
            for (int i = 0; i < Lista_Canciones.Items.Count; i++)
            {
                matriz[i] = RutasArchivos[i].ToString();
                Escribir.WriteLine(matriz[i]);
            }
            Escribir.Close(); //Finaliza la escritura

        }

        /** BotonCargarLista_Click
         * En esta función al darle click al boton "Cargar Lista" se abre un menu para buscar el archivo que deseas cargar.
         */
        private void botonCargarLista_Click(object sender, EventArgs e)
        {
            string archivo = "";
            //Se abre el menú 
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.FileName = "Seleccione una lista";
            abrir.Filter = "Lista de Reproduccion|*.geo";
            // La dirección incial en la que se abre el menú es en la carpeta de Documentos.
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            abrir.FilterIndex = 1;
            TmTiempo.Enabled = true;
            TmTiempo.Start();
            Lista_Canciones.Items.Clear();
            Reproductor.Stop();
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                archivo = abrir.FileName;
                FileStream lista = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader LeerArchivo = new StreamReader(lista);
                string linea;
                //Aquí empezaría a leer el archivo que has seleccionado para cargar.
                while ((linea = LeerArchivo.ReadLine()) != null)
                {
                    string[] cadena = linea.Split(';');
                    foreach (string subcadena in cadena)
                    {
                        //Se añaden las cadenas a la Lista de Reproducción
                        Lista_Canciones.Items.Add(subcadena);
                    }
                }
                //cierro la lectura de archivo
                LeerArchivo.Close();
                //Aqui se recorreria la lista de canciones, para añadir las rutas y los archivos que estan en la Lista de Reproducción.
                for (int i = 0; i < Lista_Canciones.Items.Count; i++)
                {
                    RutasArchivos[i] = Lista_Canciones.Items[i].ToString();
                    lista_Canciones.Add(Lista_Canciones.Items[i].ToString());
                }
                Lista_Canciones.SelectedIndex = 0;
                Reproductor.Play();
            }
        }
        /**Lista_Favoritos_SelectedIndexChanged.
         * En esta función se realiza que cuando se selecciona una cancion de la lista de favoritos te lo añade al final de la 
         * Lista de Reproducción.
         */
        private void Lista_Favoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lista_Canciones.Items.Add(Lista_Favoritos.SelectedItems[0].ToString());
        }
        /** GuardarFavoritos_Click.
         * Su funcion es, que cuando se pulsa el boton "Guardar Lista" te saldrá un mensaje y se guardará en la ruta seleccionada en el archivo
         * "Favoritos.txt" se guardaran las canciones que se encuentran en favoritos.
         */
        private void GuardarFavoritos_Click(object sender, EventArgs e)
        {
            StreamWriter Save = new StreamWriter(@"C:\Users\erafa\OneDrive\Escritorio\ReproductorMultimedia\WinReproductorMp3\Storage\Favorite.txt");
            foreach (var item in Lista_Favoritos.Items)
            {
                Save.WriteLine(item.ToString());
                this.Refresh();
            }
            MessageBox.Show("Lista de favoritos guardada");
            Save.Close();
            Lista_Favoritos.Items.Clear();
        }
        /** ChkVolumen_CheckedChanged.
         * Esta funcion cambia el estado del volumen si se da una vez se silenciaria la musica
         * Si cuando está silenciada se pulsa se vuelve a escuchar con un valor de volume de 0.35, el predeterminado que se ha asignado
         */
        private void ChkVolumen_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVolumen.Checked == true) //Si se encuentra marcado
            {
                Reproductor.Volume = 0; //Cambiar Volumen a 0
                MtVolumen.Value = 0; 
                BtnVolumen.BackgroundImage = Properties.Resources.mute_100; //Cambiar la imagen.
                LblVolumen.Text = "SILENCIO"; //Mensaje de que se encuentra silenciado el reproductor.
            }
            else
            {
                //Si no está marcado
                Reproductor.Volume = 0.35f; //Cambiar el volumen a 0.35
                MtVolumen.Value = 35;
                BtnVolumen.BackgroundImage = Properties.Resources.low_volume10; //Cambia la imagen.
                LblVolumen.Text = "VOLUMEN"; //Mensaje que no se encuentra silenciado el reproductor.
            }
        }
        /** BtnVolumen_Click
         * Boton para cambiar entre silenciar y no silenciar el reproductor.
         */
        private void BtnVolumen_Click(object sender, EventArgs e)
        {
            if (ChkVolumen.CheckState == CheckState.Unchecked)
            {
                ChkVolumen.Checked = true;
            }
            else
            {
                ChkVolumen.Checked = false;
            }
        }
        /** MtBalance_ValueChanged
         * Boton para cambiar el Balace del sonido.
         */
        private void MtBalance_ValueChanged(object sender, decimal value)
        {
            Reproductor.Balance = MtBalance.Value;
        }
        /** BotonLimpiar_Click
         * Botón para eliminar toda la Lista de reproducción que haya.
         * Te elimina la lista y se detiene el reproductor.
         * Te mostraria con anterioridad una ventana con un mensaje de si deseas borrar la listado para que no le des sin querer.
         */
        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            //Si no hay canciones te muestra este mensaje.
            if (Lista_Canciones.Items.Count == 0)
            {
                MessageBox.Show("No hay canciones en el listado", "Reproductor MP3");
            }
            else if (MessageBox.Show("¿Está seguro que desea quitar este listado?", "Reproductor MP3", //Te muestra este mensaje cuando hay canciones.
              MessageBoxButtons.YesNo, 
              MessageBoxIcon.Question) == DialogResult.Yes)
              //Decides tu si darle a YES para eliminar toda la lista
            {
                //Aqui se elimina toda la lista y inicia los metadatos por defecto.
                LblCancion.Text = "Título de la Canción";
                LblAutor.Text = "Autor/Cantante";
                LblAlbum.Text = "Album";
                ImagenSong.BackgroundImage = Properties.Resources.song_PX;
                MtVolumen.Value = 1;
                lista_Canciones.Clear();
                Lista_Canciones.Items.Clear();
            }
            Reproductor.Pause();
            Reproductor.Stop();//Detiene el Reproductor.
        }
    }
}