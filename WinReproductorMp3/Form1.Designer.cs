
namespace WinReproductorMp3
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
            this.components = new System.ComponentModel.Container();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.GuardarFavoritos = new WinReproductorMp3.Controles.Botones();
            this.botones1 = new WinReproductorMp3.Controles.Botones();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.GuardarListas = new WinReproductorMp3.Controles.Botones();
            this.BtnAgregar = new WinReproductorMp3.Controles.Botones();
            this.BtnLimpiar = new WinReproductorMp3.Controles.Botones();
            this.BtnVerFavoritos = new WinReproductorMp3.Controles.Botones();
            this.PanelTagLib = new System.Windows.Forms.Panel();
            this.ImagenSong = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblAlbum = new System.Windows.Forms.Label();
            this.LblAutora = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblTituloa = new System.Windows.Forms.Label();
            this.LblCancion = new System.Windows.Forms.Label();
            this.TmTiempo = new System.Windows.Forms.Timer(this.components);
            this.TtMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.Lista_Canciones = new System.Windows.Forms.ListBox();
            this.MtStatus = new XComponent.SliderBar.MACTrackBar();
            this.MtVolumen = new XComponent.SliderBar.MACTrackBar();
            this.MtBalance = new XComponent.SliderBar.MACTrackBar();
            this.FavBoton = new WinReproductorMp3.Controles.Botones();
            this.BotonAleatorioOff = new WinReproductorMp3.Controles.Botones();
            this.BotonBucleOff = new WinReproductorMp3.Controles.Botones();
            this.BotonPausa = new WinReproductorMp3.Controles.Botones();
            this.BotonSiguiente = new WinReproductorMp3.Controles.Botones();
            this.BotonAnterior = new WinReproductorMp3.Controles.Botones();
            this.BotonPlay = new WinReproductorMp3.Controles.Botones();
            this.BotonBucleOn = new WinReproductorMp3.Controles.Botones();
            this.BotonAleatorioOn = new WinReproductorMp3.Controles.Botones();
            this.PanelReproductor = new System.Windows.Forms.Panel();
            this.Lista_Favoritos = new System.Windows.Forms.ListBox();
            this.LblVolumen = new System.Windows.Forms.Label();
            this.LblVol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.LblFinal = new System.Windows.Forms.Label();
            this.ChkVolumen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.BtnVolumen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BotonSalir = new System.Windows.Forms.PictureBox();
            this.MinimiWindow = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelTagLib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenSong)).BeginInit();
            this.PanelReproductor.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimiWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenu.Controls.Add(this.GuardarFavoritos);
            this.PanelMenu.Controls.Add(this.botones1);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Controls.Add(this.GuardarListas);
            this.PanelMenu.Controls.Add(this.BtnAgregar);
            this.PanelMenu.Controls.Add(this.BtnLimpiar);
            this.PanelMenu.Controls.Add(this.BtnVerFavoritos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 42);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(252, 637);
            this.PanelMenu.TabIndex = 1;
            this.PanelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseMove);
            // 
            // GuardarFavoritos
            // 
            this.GuardarFavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GuardarFavoritos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GuardarFavoritos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GuardarFavoritos.BorderRadius = 10;
            this.GuardarFavoritos.BorderSize = 1;
            this.GuardarFavoritos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarFavoritos.FlatAppearance.BorderSize = 0;
            this.GuardarFavoritos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GuardarFavoritos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GuardarFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarFavoritos.ForeColor = System.Drawing.Color.White;
            this.GuardarFavoritos.Location = new System.Drawing.Point(12, 405);
            this.GuardarFavoritos.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarFavoritos.Name = "GuardarFavoritos";
            this.GuardarFavoritos.Size = new System.Drawing.Size(208, 62);
            this.GuardarFavoritos.TabIndex = 78;
            this.GuardarFavoritos.Text = "GUARDAR FAVORITOS";
            this.GuardarFavoritos.TextColor = System.Drawing.Color.White;
            this.GuardarFavoritos.UseVisualStyleBackColor = false;
            this.GuardarFavoritos.Click += new System.EventHandler(this.GuardarFavoritos_Click);
            // 
            // botones1
            // 
            this.botones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botones1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botones1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botones1.BorderRadius = 10;
            this.botones1.BorderSize = 1;
            this.botones1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botones1.FlatAppearance.BorderSize = 0;
            this.botones1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botones1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones1.ForeColor = System.Drawing.Color.White;
            this.botones1.Location = new System.Drawing.Point(12, 265);
            this.botones1.Margin = new System.Windows.Forms.Padding(4);
            this.botones1.Name = "botones1";
            this.botones1.Size = new System.Drawing.Size(208, 62);
            this.botones1.TabIndex = 77;
            this.botones1.Text = "CARGAR LISTAS";
            this.botones1.TextColor = System.Drawing.Color.White;
            this.botones1.UseVisualStyleBackColor = false;
            this.botones1.Click += new System.EventHandler(this.botonCargarLista_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::WinReproductorMp3.Properties.Resources.Logo2;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(25, 7);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(186, 107);
            this.Logo.TabIndex = 76;
            this.Logo.TabStop = false;
            // 
            // GuardarListas
            // 
            this.GuardarListas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GuardarListas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GuardarListas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GuardarListas.BorderRadius = 10;
            this.GuardarListas.BorderSize = 1;
            this.GuardarListas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarListas.FlatAppearance.BorderSize = 0;
            this.GuardarListas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GuardarListas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GuardarListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarListas.ForeColor = System.Drawing.Color.White;
            this.GuardarListas.Location = new System.Drawing.Point(12, 191);
            this.GuardarListas.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarListas.Name = "GuardarListas";
            this.GuardarListas.Size = new System.Drawing.Size(208, 62);
            this.GuardarListas.TabIndex = 75;
            this.GuardarListas.Text = "GUARDAR LISTA";
            this.GuardarListas.TextColor = System.Drawing.Color.White;
            this.GuardarListas.UseVisualStyleBackColor = false;
            this.GuardarListas.Click += new System.EventHandler(this.GuardarListas_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregar.BorderRadius = 10;
            this.BtnAgregar.BorderSize = 1;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(12, 121);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(208, 62);
            this.BtnAgregar.TabIndex = 74;
            this.BtnAgregar.Text = "ARGREGAR ARCHIVOS";
            this.BtnAgregar.TextColor = System.Drawing.Color.White;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLimpiar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiar.BorderRadius = 10;
            this.BtnLimpiar.BorderSize = 1;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(16, 544);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(204, 62);
            this.BtnLimpiar.TabIndex = 73;
            this.BtnLimpiar.Text = "LIMPIAR LISTADO";
            this.BtnLimpiar.TextColor = System.Drawing.Color.White;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // BtnVerFavoritos
            // 
            this.BtnVerFavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVerFavoritos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVerFavoritos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnVerFavoritos.BorderRadius = 10;
            this.BtnVerFavoritos.BorderSize = 1;
            this.BtnVerFavoritos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerFavoritos.FlatAppearance.BorderSize = 0;
            this.BtnVerFavoritos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnVerFavoritos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnVerFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerFavoritos.ForeColor = System.Drawing.Color.White;
            this.BtnVerFavoritos.Location = new System.Drawing.Point(12, 335);
            this.BtnVerFavoritos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVerFavoritos.Name = "BtnVerFavoritos";
            this.BtnVerFavoritos.Size = new System.Drawing.Size(208, 62);
            this.BtnVerFavoritos.TabIndex = 72;
            this.BtnVerFavoritos.Text = "FAVORITOS";
            this.BtnVerFavoritos.TextColor = System.Drawing.Color.White;
            this.BtnVerFavoritos.UseVisualStyleBackColor = false;
            this.BtnVerFavoritos.Click += new System.EventHandler(this.BtnVerFavoritos_Click);
            // 
            // PanelTagLib
            // 
            this.PanelTagLib.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelTagLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTagLib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTagLib.Controls.Add(this.ImagenSong);
            this.PanelTagLib.Controls.Add(this.label8);
            this.PanelTagLib.Controls.Add(this.LblAlbum);
            this.PanelTagLib.Controls.Add(this.LblAutora);
            this.PanelTagLib.Controls.Add(this.LblAutor);
            this.PanelTagLib.Controls.Add(this.LblTituloa);
            this.PanelTagLib.Controls.Add(this.LblCancion);
            this.PanelTagLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTagLib.Location = new System.Drawing.Point(252, 42);
            this.PanelTagLib.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTagLib.Name = "PanelTagLib";
            this.PanelTagLib.Size = new System.Drawing.Size(1064, 121);
            this.PanelTagLib.TabIndex = 4;
            this.PanelTagLib.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTagLib_MouseMove);
            // 
            // ImagenSong
            // 
            this.ImagenSong.BackgroundImage = global::WinReproductorMp3.Properties.Resources.song_PX;
            this.ImagenSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagenSong.Location = new System.Drawing.Point(888, -1);
            this.ImagenSong.Name = "ImagenSong";
            this.ImagenSong.Size = new System.Drawing.Size(175, 121);
            this.ImagenSong.TabIndex = 0;
            this.ImagenSong.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(149, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 69;
            this.label8.Text = "Album: ";
            // 
            // LblAlbum
            // 
            this.LblAlbum.AutoSize = true;
            this.LblAlbum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlbum.ForeColor = System.Drawing.Color.Cyan;
            this.LblAlbum.Location = new System.Drawing.Point(237, 89);
            this.LblAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAlbum.Name = "LblAlbum";
            this.LblAlbum.Size = new System.Drawing.Size(54, 19);
            this.LblAlbum.TabIndex = 70;
            this.LblAlbum.Text = "Album";
            // 
            // LblAutora
            // 
            this.LblAutora.AutoSize = true;
            this.LblAutora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutora.ForeColor = System.Drawing.Color.White;
            this.LblAutora.Location = new System.Drawing.Point(71, 50);
            this.LblAutora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAutora.Name = "LblAutora";
            this.LblAutora.Size = new System.Drawing.Size(154, 23);
            this.LblAutora.TabIndex = 67;
            this.LblAutora.Text = "Autor/Cantante: ";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.ForeColor = System.Drawing.Color.Cyan;
            this.LblAutor.Location = new System.Drawing.Point(239, 53);
            this.LblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(118, 19);
            this.LblAutor.TabIndex = 68;
            this.LblAutor.Text = "Autor/Cantante";
            // 
            // LblTituloa
            // 
            this.LblTituloa.AutoSize = true;
            this.LblTituloa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloa.ForeColor = System.Drawing.Color.White;
            this.LblTituloa.Location = new System.Drawing.Point(28, 16);
            this.LblTituloa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTituloa.Name = "LblTituloa";
            this.LblTituloa.Size = new System.Drawing.Size(193, 23);
            this.LblTituloa.TabIndex = 64;
            this.LblTituloa.Text = "Titulo de la Canción: ";
            // 
            // LblCancion
            // 
            this.LblCancion.AutoSize = true;
            this.LblCancion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCancion.ForeColor = System.Drawing.Color.Cyan;
            this.LblCancion.Location = new System.Drawing.Point(239, 18);
            this.LblCancion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCancion.Name = "LblCancion";
            this.LblCancion.Size = new System.Drawing.Size(154, 19);
            this.LblCancion.TabIndex = 63;
            this.LblCancion.Text = "Título de la Canción";
            // 
            // TmTiempo
            // 
            this.TmTiempo.Tick += new System.EventHandler(this.EvtActualizarTiempo);
            // 
            // Lista_Canciones
            // 
            this.Lista_Canciones.BackColor = System.Drawing.Color.Gray;
            this.Lista_Canciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lista_Canciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_Canciones.ForeColor = System.Drawing.Color.Lime;
            this.Lista_Canciones.FormattingEnabled = true;
            this.Lista_Canciones.ItemHeight = 18;
            this.Lista_Canciones.Location = new System.Drawing.Point(554, 0);
            this.Lista_Canciones.Margin = new System.Windows.Forms.Padding(4);
            this.Lista_Canciones.Name = "Lista_Canciones";
            this.Lista_Canciones.Size = new System.Drawing.Size(509, 344);
            this.Lista_Canciones.TabIndex = 0;
            this.TtMensaje.SetToolTip(this.Lista_Canciones, "LISTA DE REPRODUCCIÓN");
            this.Lista_Canciones.SelectedIndexChanged += new System.EventHandler(this.Lista_Canciones_SelectedIndexChanged);
            // 
            // MtStatus
            // 
            this.MtStatus.BackColor = System.Drawing.Color.Transparent;
            this.MtStatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.MtStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MtStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.MtStatus.IndentHeight = 6;
            this.MtStatus.Location = new System.Drawing.Point(202, 13);
            this.MtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.MtStatus.Maximum = 100;
            this.MtStatus.Minimum = 0;
            this.MtStatus.Name = "MtStatus";
            this.MtStatus.Size = new System.Drawing.Size(467, 22);
            this.MtStatus.TabIndex = 5;
            this.MtStatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtStatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.MtStatus.TickHeight = 4;
            this.MtStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TtMensaje.SetToolTip(this.MtStatus, "BARRA DE ESTADO");
            this.MtStatus.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.MtStatus.TrackerSize = new System.Drawing.Size(10, 10);
            this.MtStatus.TrackLineColor = System.Drawing.Color.White;
            this.MtStatus.TrackLineHeight = 3;
            this.MtStatus.TrackLineSelectedColor = System.Drawing.Color.Teal;
            this.MtStatus.Value = 0;
            this.MtStatus.Scroll += new System.EventHandler(this.MtStatus_Scroll);
            // 
            // MtVolumen
            // 
            this.MtVolumen.BackColor = System.Drawing.Color.Transparent;
            this.MtVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.MtVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MtVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.MtVolumen.IndentHeight = 6;
            this.MtVolumen.Location = new System.Drawing.Point(831, 23);
            this.MtVolumen.Margin = new System.Windows.Forms.Padding(4);
            this.MtVolumen.Maximum = 100;
            this.MtVolumen.Minimum = 0;
            this.MtVolumen.Name = "MtVolumen";
            this.MtVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MtVolumen.Size = new System.Drawing.Size(22, 113);
            this.MtVolumen.TabIndex = 6;
            this.MtVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.MtVolumen.TickHeight = 4;
            this.MtVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TtMensaje.SetToolTip(this.MtVolumen, "VOLUMEN");
            this.MtVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.MtVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.MtVolumen.TrackLineColor = System.Drawing.Color.White;
            this.MtVolumen.TrackLineHeight = 3;
            this.MtVolumen.TrackLineSelectedColor = System.Drawing.Color.Teal;
            this.MtVolumen.Value = 0;
            this.MtVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtVolumen_ValueChanged);
            this.MtVolumen.Scroll += new System.EventHandler(this.MtVolumen_Scroll);
            // 
            // MtBalance
            // 
            this.MtBalance.BackColor = System.Drawing.Color.Transparent;
            this.MtBalance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.MtBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MtBalance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.MtBalance.IndentHeight = 6;
            this.MtBalance.Location = new System.Drawing.Point(930, 108);
            this.MtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.MtBalance.Maximum = 100;
            this.MtBalance.Minimum = -100;
            this.MtBalance.Name = "MtBalance";
            this.MtBalance.Size = new System.Drawing.Size(109, 22);
            this.MtBalance.TabIndex = 9;
            this.MtBalance.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtBalance.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.MtBalance.TickHeight = 4;
            this.MtBalance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TtMensaje.SetToolTip(this.MtBalance, "BALANCE");
            this.MtBalance.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.MtBalance.TrackerSize = new System.Drawing.Size(10, 10);
            this.MtBalance.TrackLineColor = System.Drawing.Color.White;
            this.MtBalance.TrackLineHeight = 3;
            this.MtBalance.TrackLineSelectedColor = System.Drawing.Color.Teal;
            this.MtBalance.Value = 0;
            this.MtBalance.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtBalance_ValueChanged);
            // 
            // FavBoton
            // 
            this.FavBoton.BackColor = System.Drawing.Color.Transparent;
            this.FavBoton.BackgroundColor = System.Drawing.Color.Transparent;
            this.FavBoton.BackgroundImage = global::WinReproductorMp3.Properties.Resources.Fav;
            this.FavBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FavBoton.BorderColor = System.Drawing.Color.White;
            this.FavBoton.BorderRadius = 10;
            this.FavBoton.BorderSize = 1;
            this.FavBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavBoton.FlatAppearance.BorderSize = 0;
            this.FavBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FavBoton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FavBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavBoton.ForeColor = System.Drawing.Color.White;
            this.FavBoton.Location = new System.Drawing.Point(107, 90);
            this.FavBoton.Margin = new System.Windows.Forms.Padding(4);
            this.FavBoton.Name = "FavBoton";
            this.FavBoton.Size = new System.Drawing.Size(45, 46);
            this.FavBoton.TabIndex = 111;
            this.FavBoton.TextColor = System.Drawing.Color.White;
            this.TtMensaje.SetToolTip(this.FavBoton, "BucleOFF");
            this.FavBoton.UseVisualStyleBackColor = false;
            this.FavBoton.Click += new System.EventHandler(this.FavBoton_Click);
            this.FavBoton.MouseEnter += new System.EventHandler(this.Fav_MouseEnter);
            this.FavBoton.MouseLeave += new System.EventHandler(this.FavBoton_MouseLeave);
            // 
            // BotonAleatorioOff
            // 
            this.BotonAleatorioOff.BackColor = System.Drawing.Color.Transparent;
            this.BotonAleatorioOff.BackgroundColor = System.Drawing.Color.Transparent;
            this.BotonAleatorioOff.BackgroundImage = global::WinReproductorMp3.Properties.Resources.Aleatorio;
            this.BotonAleatorioOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonAleatorioOff.BorderColor = System.Drawing.Color.White;
            this.BotonAleatorioOff.BorderRadius = 10;
            this.BotonAleatorioOff.BorderSize = 1;
            this.BotonAleatorioOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAleatorioOff.FlatAppearance.BorderSize = 0;
            this.BotonAleatorioOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonAleatorioOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonAleatorioOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAleatorioOff.ForeColor = System.Drawing.Color.White;
            this.BotonAleatorioOff.Location = new System.Drawing.Point(604, 90);
            this.BotonAleatorioOff.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAleatorioOff.Name = "BotonAleatorioOff";
            this.BotonAleatorioOff.Size = new System.Drawing.Size(37, 38);
            this.BotonAleatorioOff.TabIndex = 108;
            this.BotonAleatorioOff.TextColor = System.Drawing.Color.White;
            this.TtMensaje.SetToolTip(this.BotonAleatorioOff, "AleatorioOFF");
            this.BotonAleatorioOff.UseVisualStyleBackColor = false;
            this.BotonAleatorioOff.Click += new System.EventHandler(this.Boton_Aleatorio_Click);
            // 
            // BotonBucleOff
            // 
            this.BotonBucleOff.BackColor = System.Drawing.Color.Transparent;
            this.BotonBucleOff.BackgroundColor = System.Drawing.Color.Transparent;
            this.BotonBucleOff.BackgroundImage = global::WinReproductorMp3.Properties.Resources.Bucle;
            this.BotonBucleOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonBucleOff.BorderColor = System.Drawing.Color.White;
            this.BotonBucleOff.BorderRadius = 10;
            this.BotonBucleOff.BorderSize = 1;
            this.BotonBucleOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonBucleOff.FlatAppearance.BorderSize = 0;
            this.BotonBucleOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonBucleOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonBucleOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBucleOff.ForeColor = System.Drawing.Color.White;
            this.BotonBucleOff.Location = new System.Drawing.Point(215, 92);
            this.BotonBucleOff.Margin = new System.Windows.Forms.Padding(4);
            this.BotonBucleOff.Name = "BotonBucleOff";
            this.BotonBucleOff.Size = new System.Drawing.Size(37, 38);
            this.BotonBucleOff.TabIndex = 107;
            this.BotonBucleOff.TextColor = System.Drawing.Color.White;
            this.TtMensaje.SetToolTip(this.BotonBucleOff, "BucleOFF");
            this.BotonBucleOff.UseVisualStyleBackColor = false;
            this.BotonBucleOff.Click += new System.EventHandler(this.Boton_Bucle_Click);
            // 
            // BotonPausa
            // 
            this.BotonPausa.BackColor = System.Drawing.Color.Transparent;
            this.BotonPausa.BackgroundColor = System.Drawing.Color.Transparent;
            this.BotonPausa.BackgroundImage = global::WinReproductorMp3.Properties.Resources.pause100;
            this.BotonPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonPausa.BorderColor = System.Drawing.Color.White;
            this.BotonPausa.BorderRadius = 10;
            this.BotonPausa.BorderSize = 1;
            this.BotonPausa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonPausa.FlatAppearance.BorderSize = 0;
            this.BotonPausa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonPausa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPausa.ForeColor = System.Drawing.Color.White;
            this.BotonPausa.Location = new System.Drawing.Point(383, 74);
            this.BotonPausa.Margin = new System.Windows.Forms.Padding(4);
            this.BotonPausa.Name = "BotonPausa";
            this.BotonPausa.Size = new System.Drawing.Size(88, 73);
            this.BotonPausa.TabIndex = 104;
            this.BotonPausa.TextColor = System.Drawing.Color.White;
            this.TtMensaje.SetToolTip(this.BotonPausa, "PAUSA");
            this.BotonPausa.UseVisualStyleBackColor = false;
            this.BotonPausa.Visible = false;
            this.BotonPausa.Click += new System.EventHandler(this.BotonPausa_Click);
            // 
            // BotonSiguiente
            // 
            this.BotonSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.BotonSiguiente.BackgroundColor = System.Drawing.Color.Transparent;
            this.BotonSiguiente.BackgroundImage = global::WinReproductorMp3.Properties.Resources.end1001;
            this.BotonSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonSiguiente.BorderColor = System.Drawing.Color.White;
            this.BotonSiguiente.BorderRadius = 10;
            this.BotonSiguiente.BorderSize = 1;
            this.BotonSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonSiguiente.FlatAppearance.BorderSize = 0;
            this.BotonSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSiguiente.ForeColor = System.Drawing.Color.White;
            this.BotonSiguiente.Location = new System.Drawing.Point(493, 77);
            this.BotonSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.BotonSiguiente.Name = "BotonSiguiente";
            this.BotonSiguiente.Size = new System.Drawing.Size(87, 69);
            this.BotonSiguiente.TabIndex = 103;
            this.BotonSiguiente.TextColor = System.Drawing.Color.White;
            this.TtMensaje.SetToolTip(this.BotonSiguiente, "SIGUIENTE");
            this.BotonSiguiente.UseVisualStyleBackColor = false;
            this.BotonSiguiente.Click += new System.EventHandler(this.SiguienteCancion);
            // 
            // BotonAnterior
            // 
            this.BotonAnterior.BackColor = System.Drawing.Color.Transparent;
            this.BotonAnterior.BackgroundColor = System.Drawing.Color.Transparent;
            this.BotonAnterior.BackgroundImage = global::WinReproductorMp3.Properties.Resources.skip_to_start;
            this.BotonAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonAnterior.BorderColor = System.Drawing.Color.White;
            this.BotonAnterior.BorderRadius = 10;
            this.BotonAnterior.BorderSize = 1;
            this.BotonAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAnterior.FlatAppearance.BorderSize = 0;
            this.BotonAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAnterior.ForeColor = System.Drawing.Color.White;
            this.BotonAnterior.Location = new System.Drawing.Point(273, 76);
            this.BotonAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAnterior.Name = "BotonAnterior";
            this.BotonAnterior.Size = new System.Drawing.Size(87, 69);
            this.BotonAnterior.TabIndex = 102;
            this.BotonAnterior.TextColor = System.Drawing.Color.White;
            this.TtMensaje.SetToolTip(this.BotonAnterior, "ANTERIOR");
            this.BotonAnterior.UseVisualStyleBackColor = false;
            this.BotonAnterior.Click += new System.EventHandler(this.CancionAnterior);
            // 
            // BotonPlay
            // 
            this.BotonPlay.BackColor = System.Drawing.Color.Transparent;
            this.BotonPlay.BackgroundColor = System.Drawing.Color.Transparent;
            this.BotonPlay.BackgroundImage = global::WinReproductorMp3.Properties.Resources.play;
            this.BotonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonPlay.BorderColor = System.Drawing.Color.White;
            this.BotonPlay.BorderRadius = 10;
            this.BotonPlay.BorderSize = 1;
            this.BotonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonPlay.FlatAppearance.BorderSize = 0;
            this.BotonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPlay.ForeColor = System.Drawing.Color.White;
            this.BotonPlay.Location = new System.Drawing.Point(383, 73);
            this.BotonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.BotonPlay.Name = "BotonPlay";
            this.BotonPlay.Size = new System.Drawing.Size(88, 73);
            this.BotonPlay.TabIndex = 105;
            this.BotonPlay.TextColor = System.Drawing.Color.White;
            this.TtMensaje.SetToolTip(this.BotonPlay, "REPRODUCIR");
            this.BotonPlay.UseVisualStyleBackColor = false;
            this.BotonPlay.Click += new System.EventHandler(this.BotonPlay_Click);
            // 
            // BotonBucleOn
            // 
            this.BotonBucleOn.BackColor = System.Drawing.Color.Transparent;
            this.BotonBucleOn.BackgroundColor = System.Drawing.Color.Transparent;
            this.BotonBucleOn.BackgroundImage = global::WinReproductorMp3.Properties.Resources.Bucle_ON;
            this.BotonBucleOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonBucleOn.BorderColor = System.Drawing.Color.White;
            this.BotonBucleOn.BorderRadius = 10;
            this.BotonBucleOn.BorderSize = 1;
            this.BotonBucleOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonBucleOn.FlatAppearance.BorderSize = 0;
            this.BotonBucleOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonBucleOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonBucleOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBucleOn.ForeColor = System.Drawing.Color.White;
            this.BotonBucleOn.Location = new System.Drawing.Point(215, 92);
            this.BotonBucleOn.Margin = new System.Windows.Forms.Padding(4);
            this.BotonBucleOn.Name = "BotonBucleOn";
            this.BotonBucleOn.Size = new System.Drawing.Size(37, 38);
            this.BotonBucleOn.TabIndex = 109;
            this.BotonBucleOn.TextColor = System.Drawing.Color.White;
            this.TtMensaje.SetToolTip(this.BotonBucleOn, "BucleON");
            this.BotonBucleOn.UseVisualStyleBackColor = false;
            this.BotonBucleOn.Click += new System.EventHandler(this.Boton_Bucle_On_Click);
            // 
            // BotonAleatorioOn
            // 
            this.BotonAleatorioOn.BackColor = System.Drawing.Color.Transparent;
            this.BotonAleatorioOn.BackgroundColor = System.Drawing.Color.Transparent;
            this.BotonAleatorioOn.BackgroundImage = global::WinReproductorMp3.Properties.Resources.Aleatorio_ON;
            this.BotonAleatorioOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonAleatorioOn.BorderColor = System.Drawing.Color.White;
            this.BotonAleatorioOn.BorderRadius = 10;
            this.BotonAleatorioOn.BorderSize = 1;
            this.BotonAleatorioOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAleatorioOn.FlatAppearance.BorderSize = 0;
            this.BotonAleatorioOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonAleatorioOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BotonAleatorioOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAleatorioOn.ForeColor = System.Drawing.Color.White;
            this.BotonAleatorioOn.Location = new System.Drawing.Point(604, 90);
            this.BotonAleatorioOn.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAleatorioOn.Name = "BotonAleatorioOn";
            this.BotonAleatorioOn.Size = new System.Drawing.Size(37, 38);
            this.BotonAleatorioOn.TabIndex = 110;
            this.BotonAleatorioOn.TextColor = System.Drawing.Color.White;
            this.TtMensaje.SetToolTip(this.BotonAleatorioOn, "AleatorioON");
            this.BotonAleatorioOn.UseVisualStyleBackColor = false;
            this.BotonAleatorioOn.Click += new System.EventHandler(this.BotonAleatorioOn_Click);
            // 
            // PanelReproductor
            // 
            this.PanelReproductor.BackColor = System.Drawing.Color.Gray;
            this.PanelReproductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelReproductor.Controls.Add(this.Lista_Favoritos);
            this.PanelReproductor.Controls.Add(this.Lista_Canciones);
            this.PanelReproductor.Location = new System.Drawing.Point(252, 163);
            this.PanelReproductor.Margin = new System.Windows.Forms.Padding(4);
            this.PanelReproductor.Name = "PanelReproductor";
            this.PanelReproductor.Size = new System.Drawing.Size(1064, 327);
            this.PanelReproductor.TabIndex = 5;
            // 
            // Lista_Favoritos
            // 
            this.Lista_Favoritos.BackColor = System.Drawing.Color.Gray;
            this.Lista_Favoritos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lista_Favoritos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_Favoritos.ForeColor = System.Drawing.Color.Red;
            this.Lista_Favoritos.FormattingEnabled = true;
            this.Lista_Favoritos.ItemHeight = 17;
            this.Lista_Favoritos.Location = new System.Drawing.Point(-1, -2);
            this.Lista_Favoritos.Name = "Lista_Favoritos";
            this.Lista_Favoritos.Size = new System.Drawing.Size(556, 325);
            this.Lista_Favoritos.TabIndex = 1;
            this.Lista_Favoritos.SelectedIndexChanged += new System.EventHandler(this.Lista_Favoritos_SelectedIndexChanged);
            // 
            // LblVolumen
            // 
            this.LblVolumen.AutoSize = true;
            this.LblVolumen.ForeColor = System.Drawing.Color.White;
            this.LblVolumen.Location = new System.Drawing.Point(809, 139);
            this.LblVolumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVolumen.Name = "LblVolumen";
            this.LblVolumen.Size = new System.Drawing.Size(73, 16);
            this.LblVolumen.TabIndex = 7;
            this.LblVolumen.Text = "VOLUMEN";
            // 
            // LblVol
            // 
            this.LblVol.AutoSize = true;
            this.LblVol.ForeColor = System.Drawing.Color.White;
            this.LblVol.Location = new System.Drawing.Point(865, 114);
            this.LblVol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVol.Name = "LblVol";
            this.LblVol.Size = new System.Drawing.Size(14, 16);
            this.LblVol.TabIndex = 8;
            this.LblVol.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(950, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "BALANCE";
            // 
            // LblTiempoTranscurrido
            // 
            this.LblTiempoTranscurrido.AutoSize = true;
            this.LblTiempoTranscurrido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiempoTranscurrido.ForeColor = System.Drawing.Color.Lime;
            this.LblTiempoTranscurrido.Location = new System.Drawing.Point(211, 38);
            this.LblTiempoTranscurrido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTiempoTranscurrido.Name = "LblTiempoTranscurrido";
            this.LblTiempoTranscurrido.Size = new System.Drawing.Size(38, 19);
            this.LblTiempoTranscurrido.TabIndex = 95;
            this.LblTiempoTranscurrido.Text = "--:--";
            // 
            // LblFinal
            // 
            this.LblFinal.AutoSize = true;
            this.LblFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinal.ForeColor = System.Drawing.Color.Lime;
            this.LblFinal.Location = new System.Drawing.Point(619, 37);
            this.LblFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFinal.Name = "LblFinal";
            this.LblFinal.Size = new System.Drawing.Size(38, 19);
            this.LblFinal.TabIndex = 96;
            this.LblFinal.Text = "--:--";
            // 
            // ChkVolumen
            // 
            this.ChkVolumen.AutoSize = true;
            this.ChkVolumen.Location = new System.Drawing.Point(781, 139);
            this.ChkVolumen.Margin = new System.Windows.Forms.Padding(4);
            this.ChkVolumen.Name = "ChkVolumen";
            this.ChkVolumen.Size = new System.Drawing.Size(18, 17);
            this.ChkVolumen.TabIndex = 98;
            this.ChkVolumen.UseVisualStyleBackColor = true;
            this.ChkVolumen.Visible = false;
            this.ChkVolumen.CheckedChanged += new System.EventHandler(this.ChkVolumen_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1017, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(927, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 100;
            this.label7.Text = "L";
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBotones.Controls.Add(this.FavBoton);
            this.PanelBotones.Controls.Add(this.BotonAleatorioOff);
            this.PanelBotones.Controls.Add(this.BotonBucleOff);
            this.PanelBotones.Controls.Add(this.BotonPausa);
            this.PanelBotones.Controls.Add(this.BotonSiguiente);
            this.PanelBotones.Controls.Add(this.BotonAnterior);
            this.PanelBotones.Controls.Add(this.label7);
            this.PanelBotones.Controls.Add(this.label2);
            this.PanelBotones.Controls.Add(this.ChkVolumen);
            this.PanelBotones.Controls.Add(this.BtnVolumen);
            this.PanelBotones.Controls.Add(this.LblFinal);
            this.PanelBotones.Controls.Add(this.LblTiempoTranscurrido);
            this.PanelBotones.Controls.Add(this.label3);
            this.PanelBotones.Controls.Add(this.MtBalance);
            this.PanelBotones.Controls.Add(this.LblVol);
            this.PanelBotones.Controls.Add(this.LblVolumen);
            this.PanelBotones.Controls.Add(this.MtVolumen);
            this.PanelBotones.Controls.Add(this.MtStatus);
            this.PanelBotones.Controls.Add(this.BotonPlay);
            this.PanelBotones.Controls.Add(this.BotonBucleOn);
            this.PanelBotones.Controls.Add(this.BotonAleatorioOn);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotones.Location = new System.Drawing.Point(252, 486);
            this.PanelBotones.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(1064, 193);
            this.PanelBotones.TabIndex = 2;
            // 
            // BtnVolumen
            // 
            this.BtnVolumen.BackgroundImage = global::WinReproductorMp3.Properties.Resources.low_volume10;
            this.BtnVolumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVolumen.FlatAppearance.BorderSize = 0;
            this.BtnVolumen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnVolumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolumen.Location = new System.Drawing.Point(777, 100);
            this.BtnVolumen.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVolumen.Name = "BtnVolumen";
            this.BtnVolumen.Size = new System.Drawing.Size(45, 32);
            this.BtnVolumen.TabIndex = 97;
            this.BtnVolumen.UseVisualStyleBackColor = true;
            this.BtnVolumen.Click += new System.EventHandler(this.BtnVolumen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1316, 42);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(528, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 16);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "MUSIS REPRODUCTOR";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BotonSalir
            // 
            this.BotonSalir.BackColor = System.Drawing.Color.Black;
            this.BotonSalir.BackgroundImage = global::WinReproductorMp3.Properties.Resources.closewindow_click;
            this.BotonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonSalir.Location = new System.Drawing.Point(1273, 4);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(31, 31);
            this.BotonSalir.TabIndex = 7;
            this.BotonSalir.TabStop = false;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            this.BotonSalir.MouseEnter += new System.EventHandler(this.BotonSalir_MouseEnter);
            this.BotonSalir.MouseLeave += new System.EventHandler(this.BotonSalir_MouseLeave);
            // 
            // MinimiWindow
            // 
            this.MinimiWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimiWindow.BackgroundImage = global::WinReproductorMp3.Properties.Resources.MinimizarWindowBoton_click;
            this.MinimiWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimiWindow.Location = new System.Drawing.Point(1163, 5);
            this.MinimiWindow.Name = "MinimiWindow";
            this.MinimiWindow.Size = new System.Drawing.Size(31, 31);
            this.MinimiWindow.TabIndex = 72;
            this.MinimiWindow.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 679);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.PanelReproductor);
            this.Controls.Add(this.PanelTagLib);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MinimiWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelTagLib.ResumeLayout(false);
            this.PanelTagLib.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenSong)).EndInit();
            this.PanelReproductor.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            this.PanelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimiWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelTagLib;
        private System.Windows.Forms.Timer TmTiempo;
        private System.Windows.Forms.Label LblTituloa;
        private System.Windows.Forms.Label LblCancion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblAlbum;
        private System.Windows.Forms.Label LblAutora;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.ToolTip TtMensaje;
        private Controles.Botones BtnLimpiar;
        private Controles.Botones BtnVerFavoritos;
        private Controles.Botones BtnAgregar;
        private System.Windows.Forms.ListBox Lista_Canciones;
        private System.Windows.Forms.Panel PanelReproductor;
        private XComponent.SliderBar.MACTrackBar MtStatus;
        private XComponent.SliderBar.MACTrackBar MtVolumen;
        private System.Windows.Forms.Label LblVolumen;
        private System.Windows.Forms.Label LblVol;
        private XComponent.SliderBar.MACTrackBar MtBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTiempoTranscurrido;
        private System.Windows.Forms.Label LblFinal;
        private System.Windows.Forms.Button BtnVolumen;
        private System.Windows.Forms.CheckBox ChkVolumen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Controles.Botones BotonAnterior;
        private Controles.Botones BotonSiguiente;
        private Controles.Botones BotonBucleOff;
        private Controles.Botones BotonAleatorioOff;
        private Controles.Botones BotonPausa;
        private System.Windows.Forms.Panel PanelBotones;
        private Controles.Botones BotonPlay;
        private Controles.Botones BotonBucleOn;
        private Controles.Botones BotonAleatorioOn;
        private System.Windows.Forms.PictureBox ImagenSong;
        private Controles.Botones FavBoton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox BotonSalir;
        private Controles.Botones GuardarListas;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox MinimiWindow;
        private System.Windows.Forms.TextBox textBox1;
        private Controles.Botones botones1;
        private System.Windows.Forms.ListBox Lista_Favoritos;
        private Controles.Botones GuardarFavoritos;
    }
}

