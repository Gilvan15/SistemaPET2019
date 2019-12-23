namespace SistemaPet
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panelTop = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.pictlogo = new System.Windows.Forms.PictureBox();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelSidebarBunifu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelSubRelatorio = new System.Windows.Forms.Panel();
            this.bunifuFlatButton19 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton14 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuRelatorio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuServicos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubValores = new System.Windows.Forms.Panel();
            this.bunifuFlatButton16 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton17 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton18 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuValores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubVendas = new System.Windows.Forms.Panel();
            this.bunifuFlatButton15 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubMenuCadastrar = new System.Windows.Forms.Panel();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuFuncao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuCadastro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuT = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelSideBarhost = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuTLog = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.panelWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictlogo)).BeginInit();
            this.panelSidebarBunifu.SuspendLayout();
            this.panelSubRelatorio.SuspendLayout();
            this.panelSubValores.SuspendLayout();
            this.panelSubVendas.SuspendLayout();
            this.panelSubMenuCadastrar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideBarhost.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(188)))), ((int)(((byte)(80)))));
            this.panelTop.Controls.Add(this.restaurar);
            this.panelTop.Controls.Add(this.minimizar);
            this.panelTop.Controls.Add(this.maximizar);
            this.panelTop.Controls.Add(this.Fechar);
            this.panelTop.Controls.Add(this.label2);
            this.bunifuTLog.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 50);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuT.SetDecoration(this.restaurar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.restaurar, BunifuAnimatorNS.DecorationType.None);
            this.restaurar.Image = ((System.Drawing.Image)(resources.GetObject("restaurar.Image")));
            this.restaurar.Location = new System.Drawing.Point(1006, 3);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(40, 40);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restaurar.TabIndex = 8;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click_1);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuT.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(960, 4);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(40, 40);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 7;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click_1);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuT.SetDecoration(this.maximizar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.maximizar, BunifuAnimatorNS.DecorationType.None);
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1006, 4);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(40, 40);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizar.TabIndex = 6;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click_1);
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuT.SetDecoration(this.Fechar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.Fechar, BunifuAnimatorNS.DecorationType.None);
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(1052, 4);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(40, 40);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fechar.TabIndex = 5;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sistema de Controle -  Pets e Pets";
            // 
            // panelWrapper
            // 
            this.panelWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWrapper.BackColor = System.Drawing.Color.Transparent;
            this.panelWrapper.Controls.Add(this.pictlogo);
            this.bunifuTLog.SetDecoration(this.panelWrapper, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelWrapper, BunifuAnimatorNS.DecorationType.None);
            this.panelWrapper.Location = new System.Drawing.Point(220, 50);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(880, 623);
            this.panelWrapper.TabIndex = 2;
            // 
            // pictlogo
            // 
            this.pictlogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuT.SetDecoration(this.pictlogo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.pictlogo, BunifuAnimatorNS.DecorationType.None);
            this.pictlogo.Image = ((System.Drawing.Image)(resources.GetObject("pictlogo.Image")));
            this.pictlogo.Location = new System.Drawing.Point(179, 28);
            this.pictlogo.Name = "pictlogo";
            this.pictlogo.Size = new System.Drawing.Size(570, 580);
            this.pictlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictlogo.TabIndex = 0;
            this.pictlogo.TabStop = false;
            this.pictlogo.Visible = false;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 15;
            this.bunifuElipse.TargetControl = this.panelSidebarBunifu;
            // 
            // panelSidebarBunifu
            // 
            this.panelSidebarBunifu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebarBunifu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSidebarBunifu.BackgroundImage")));
            this.panelSidebarBunifu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSidebarBunifu.Controls.Add(this.panelSubRelatorio);
            this.panelSidebarBunifu.Controls.Add(this.btnMenuRelatorio);
            this.panelSidebarBunifu.Controls.Add(this.btnMenuServicos);
            this.panelSidebarBunifu.Controls.Add(this.panelSubValores);
            this.panelSidebarBunifu.Controls.Add(this.btnMenuValores);
            this.panelSidebarBunifu.Controls.Add(this.panelSubVendas);
            this.panelSidebarBunifu.Controls.Add(this.bunifuFlatButton6);
            this.panelSidebarBunifu.Controls.Add(this.panelSubMenuCadastrar);
            this.panelSidebarBunifu.Controls.Add(this.btnMenuCadastro);
            this.panelSidebarBunifu.Controls.Add(this.panel1);
            this.bunifuTLog.SetDecoration(this.panelSidebarBunifu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSidebarBunifu, BunifuAnimatorNS.DecorationType.None);
            this.panelSidebarBunifu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(135)))), ((int)(((byte)(52)))));
            this.panelSidebarBunifu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(135)))), ((int)(((byte)(52)))));
            this.panelSidebarBunifu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(135)))), ((int)(((byte)(52)))));
            this.panelSidebarBunifu.GradientTopRight = System.Drawing.Color.Black;
            this.panelSidebarBunifu.Location = new System.Drawing.Point(5, 6);
            this.panelSidebarBunifu.Name = "panelSidebarBunifu";
            this.panelSidebarBunifu.Quality = 10;
            this.panelSidebarBunifu.Size = new System.Drawing.Size(210, 632);
            this.panelSidebarBunifu.TabIndex = 0;
            // 
            // panelSubRelatorio
            // 
            this.panelSubRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.panelSubRelatorio.Controls.Add(this.bunifuFlatButton19);
            this.panelSubRelatorio.Controls.Add(this.bunifuFlatButton14);
            this.panelSubRelatorio.Controls.Add(this.bunifuFlatButton13);
            this.bunifuTLog.SetDecoration(this.panelSubRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSubRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.panelSubRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubRelatorio.Location = new System.Drawing.Point(0, 707);
            this.panelSubRelatorio.Name = "panelSubRelatorio";
            this.panelSubRelatorio.Size = new System.Drawing.Size(210, 136);
            this.panelSubRelatorio.TabIndex = 14;
            this.panelSubRelatorio.Visible = false;
            // 
            // bunifuFlatButton19
            // 
            this.bunifuFlatButton19.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton19.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton19.BorderRadius = 0;
            this.bunifuFlatButton19.ButtonText = "     Valores1";
            this.bunifuFlatButton19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton19, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton19, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton19.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton19.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton19.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton19.Iconimage = null;
            this.bunifuFlatButton19.Iconimage_right = null;
            this.bunifuFlatButton19.Iconimage_right_Selected = null;
            this.bunifuFlatButton19.Iconimage_Selected = null;
            this.bunifuFlatButton19.IconMarginLeft = 0;
            this.bunifuFlatButton19.IconMarginRight = 0;
            this.bunifuFlatButton19.IconRightVisible = true;
            this.bunifuFlatButton19.IconRightZoom = 0D;
            this.bunifuFlatButton19.IconVisible = true;
            this.bunifuFlatButton19.IconZoom = 60D;
            this.bunifuFlatButton19.IsTab = false;
            this.bunifuFlatButton19.Location = new System.Drawing.Point(0, 60);
            this.bunifuFlatButton19.Name = "bunifuFlatButton19";
            this.bunifuFlatButton19.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton19.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton19.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton19.selected = false;
            this.bunifuFlatButton19.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton19.TabIndex = 6;
            this.bunifuFlatButton19.Text = "     Valores1";
            this.bunifuFlatButton19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton19.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton19.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton14
            // 
            this.bunifuFlatButton14.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton14.BorderRadius = 0;
            this.bunifuFlatButton14.ButtonText = "     Valores1";
            this.bunifuFlatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton14, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton14, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton14.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton14.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton14.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.Iconimage = null;
            this.bunifuFlatButton14.Iconimage_right = null;
            this.bunifuFlatButton14.Iconimage_right_Selected = null;
            this.bunifuFlatButton14.Iconimage_Selected = null;
            this.bunifuFlatButton14.IconMarginLeft = 0;
            this.bunifuFlatButton14.IconMarginRight = 0;
            this.bunifuFlatButton14.IconRightVisible = true;
            this.bunifuFlatButton14.IconRightZoom = 0D;
            this.bunifuFlatButton14.IconVisible = true;
            this.bunifuFlatButton14.IconZoom = 60D;
            this.bunifuFlatButton14.IsTab = false;
            this.bunifuFlatButton14.Location = new System.Drawing.Point(0, 30);
            this.bunifuFlatButton14.Name = "bunifuFlatButton14";
            this.bunifuFlatButton14.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.selected = false;
            this.bunifuFlatButton14.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton14.TabIndex = 5;
            this.bunifuFlatButton14.Text = "     Valores1";
            this.bunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton14.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton14.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton13
            // 
            this.bunifuFlatButton13.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton13.BorderRadius = 0;
            this.bunifuFlatButton13.ButtonText = "     Valores1";
            this.bunifuFlatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton13.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton13.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton13.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.Iconimage = null;
            this.bunifuFlatButton13.Iconimage_right = null;
            this.bunifuFlatButton13.Iconimage_right_Selected = null;
            this.bunifuFlatButton13.Iconimage_Selected = null;
            this.bunifuFlatButton13.IconMarginLeft = 0;
            this.bunifuFlatButton13.IconMarginRight = 0;
            this.bunifuFlatButton13.IconRightVisible = true;
            this.bunifuFlatButton13.IconRightZoom = 0D;
            this.bunifuFlatButton13.IconVisible = true;
            this.bunifuFlatButton13.IconZoom = 60D;
            this.bunifuFlatButton13.IsTab = false;
            this.bunifuFlatButton13.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton13.Name = "bunifuFlatButton13";
            this.bunifuFlatButton13.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton13.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton13.selected = false;
            this.bunifuFlatButton13.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton13.TabIndex = 4;
            this.bunifuFlatButton13.Text = "     Valores1";
            this.bunifuFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton13.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton13.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMenuRelatorio
            // 
            this.btnMenuRelatorio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuRelatorio.BorderRadius = 0;
            this.btnMenuRelatorio.ButtonText = "RELATÓRIOS";
            this.btnMenuRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuRelatorio.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuRelatorio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuRelatorio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuRelatorio.Iconimage")));
            this.btnMenuRelatorio.Iconimage_right = null;
            this.btnMenuRelatorio.Iconimage_right_Selected = null;
            this.btnMenuRelatorio.Iconimage_Selected = null;
            this.btnMenuRelatorio.IconMarginLeft = 0;
            this.btnMenuRelatorio.IconMarginRight = 0;
            this.btnMenuRelatorio.IconRightVisible = true;
            this.btnMenuRelatorio.IconRightZoom = 0D;
            this.btnMenuRelatorio.IconVisible = true;
            this.btnMenuRelatorio.IconZoom = 60D;
            this.btnMenuRelatorio.IsTab = false;
            this.btnMenuRelatorio.Location = new System.Drawing.Point(0, 659);
            this.btnMenuRelatorio.Name = "btnMenuRelatorio";
            this.btnMenuRelatorio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuRelatorio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuRelatorio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuRelatorio.selected = false;
            this.btnMenuRelatorio.Size = new System.Drawing.Size(210, 48);
            this.btnMenuRelatorio.TabIndex = 13;
            this.btnMenuRelatorio.Text = "RELATÓRIOS";
            this.btnMenuRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuRelatorio.Textcolor = System.Drawing.Color.White;
            this.btnMenuRelatorio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRelatorio.Click += new System.EventHandler(this.btnMenuRelatorio_Click);
            // 
            // btnMenuServicos
            // 
            this.btnMenuServicos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuServicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuServicos.BorderRadius = 0;
            this.btnMenuServicos.ButtonText = "SEVIÇOS";
            this.btnMenuServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuServicos, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuServicos, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuServicos.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuServicos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuServicos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuServicos.Iconimage")));
            this.btnMenuServicos.Iconimage_right = null;
            this.btnMenuServicos.Iconimage_right_Selected = null;
            this.btnMenuServicos.Iconimage_Selected = null;
            this.btnMenuServicos.IconMarginLeft = 0;
            this.btnMenuServicos.IconMarginRight = 0;
            this.btnMenuServicos.IconRightVisible = true;
            this.btnMenuServicos.IconRightZoom = 0D;
            this.btnMenuServicos.IconVisible = true;
            this.btnMenuServicos.IconZoom = 60D;
            this.btnMenuServicos.IsTab = false;
            this.btnMenuServicos.Location = new System.Drawing.Point(0, 611);
            this.btnMenuServicos.Name = "btnMenuServicos";
            this.btnMenuServicos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuServicos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuServicos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuServicos.selected = false;
            this.btnMenuServicos.Size = new System.Drawing.Size(210, 48);
            this.btnMenuServicos.TabIndex = 12;
            this.btnMenuServicos.Text = "SEVIÇOS";
            this.btnMenuServicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuServicos.Textcolor = System.Drawing.Color.White;
            this.btnMenuServicos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelSubValores
            // 
            this.panelSubValores.BackColor = System.Drawing.Color.Transparent;
            this.panelSubValores.Controls.Add(this.bunifuFlatButton16);
            this.panelSubValores.Controls.Add(this.bunifuFlatButton17);
            this.panelSubValores.Controls.Add(this.bunifuFlatButton18);
            this.bunifuTLog.SetDecoration(this.panelSubValores, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSubValores, BunifuAnimatorNS.DecorationType.None);
            this.panelSubValores.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubValores.Location = new System.Drawing.Point(0, 515);
            this.panelSubValores.Name = "panelSubValores";
            this.panelSubValores.Size = new System.Drawing.Size(210, 96);
            this.panelSubValores.TabIndex = 11;
            this.panelSubValores.Visible = false;
            // 
            // bunifuFlatButton16
            // 
            this.bunifuFlatButton16.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton16.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton16.BorderRadius = 0;
            this.bunifuFlatButton16.ButtonText = "     Comanda";
            this.bunifuFlatButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton16, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton16, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton16.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton16.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton16.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton16.Iconimage = null;
            this.bunifuFlatButton16.Iconimage_right = null;
            this.bunifuFlatButton16.Iconimage_right_Selected = null;
            this.bunifuFlatButton16.Iconimage_Selected = null;
            this.bunifuFlatButton16.IconMarginLeft = 0;
            this.bunifuFlatButton16.IconMarginRight = 0;
            this.bunifuFlatButton16.IconRightVisible = true;
            this.bunifuFlatButton16.IconRightZoom = 0D;
            this.bunifuFlatButton16.IconVisible = true;
            this.bunifuFlatButton16.IconZoom = 60D;
            this.bunifuFlatButton16.IsTab = false;
            this.bunifuFlatButton16.Location = new System.Drawing.Point(0, 60);
            this.bunifuFlatButton16.Name = "bunifuFlatButton16";
            this.bunifuFlatButton16.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton16.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton16.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton16.selected = false;
            this.bunifuFlatButton16.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton16.TabIndex = 5;
            this.bunifuFlatButton16.Text = "     Comanda";
            this.bunifuFlatButton16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton16.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton16.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton17
            // 
            this.bunifuFlatButton17.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton17.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton17.BorderRadius = 0;
            this.bunifuFlatButton17.ButtonText = "     OS";
            this.bunifuFlatButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton17, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton17, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton17.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton17.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton17.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton17.Iconimage = null;
            this.bunifuFlatButton17.Iconimage_right = null;
            this.bunifuFlatButton17.Iconimage_right_Selected = null;
            this.bunifuFlatButton17.Iconimage_Selected = null;
            this.bunifuFlatButton17.IconMarginLeft = 0;
            this.bunifuFlatButton17.IconMarginRight = 0;
            this.bunifuFlatButton17.IconRightVisible = true;
            this.bunifuFlatButton17.IconRightZoom = 0D;
            this.bunifuFlatButton17.IconVisible = true;
            this.bunifuFlatButton17.IconZoom = 60D;
            this.bunifuFlatButton17.IsTab = false;
            this.bunifuFlatButton17.Location = new System.Drawing.Point(0, 30);
            this.bunifuFlatButton17.Name = "bunifuFlatButton17";
            this.bunifuFlatButton17.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton17.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton17.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton17.selected = false;
            this.bunifuFlatButton17.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton17.TabIndex = 4;
            this.bunifuFlatButton17.Text = "     OS";
            this.bunifuFlatButton17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton17.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton17.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton18
            // 
            this.bunifuFlatButton18.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton18.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton18.BorderRadius = 0;
            this.bunifuFlatButton18.ButtonText = "     Recibo";
            this.bunifuFlatButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton18, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton18, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton18.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton18.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton18.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton18.Iconimage = null;
            this.bunifuFlatButton18.Iconimage_right = null;
            this.bunifuFlatButton18.Iconimage_right_Selected = null;
            this.bunifuFlatButton18.Iconimage_Selected = null;
            this.bunifuFlatButton18.IconMarginLeft = 0;
            this.bunifuFlatButton18.IconMarginRight = 0;
            this.bunifuFlatButton18.IconRightVisible = true;
            this.bunifuFlatButton18.IconRightZoom = 0D;
            this.bunifuFlatButton18.IconVisible = true;
            this.bunifuFlatButton18.IconZoom = 60D;
            this.bunifuFlatButton18.IsTab = false;
            this.bunifuFlatButton18.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton18.Name = "bunifuFlatButton18";
            this.bunifuFlatButton18.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton18.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton18.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton18.selected = false;
            this.bunifuFlatButton18.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton18.TabIndex = 3;
            this.bunifuFlatButton18.Text = "     Recibo";
            this.bunifuFlatButton18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton18.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton18.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton18.Click += new System.EventHandler(this.bunifuFlatButton18_Click);
            // 
            // btnMenuValores
            // 
            this.btnMenuValores.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuValores.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuValores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuValores.BorderRadius = 0;
            this.btnMenuValores.ButtonText = "VALORES";
            this.btnMenuValores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuValores, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuValores, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuValores.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuValores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuValores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuValores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuValores.Iconimage")));
            this.btnMenuValores.Iconimage_right = null;
            this.btnMenuValores.Iconimage_right_Selected = null;
            this.btnMenuValores.Iconimage_Selected = null;
            this.btnMenuValores.IconMarginLeft = 0;
            this.btnMenuValores.IconMarginRight = 0;
            this.btnMenuValores.IconRightVisible = true;
            this.btnMenuValores.IconRightZoom = 0D;
            this.btnMenuValores.IconVisible = true;
            this.btnMenuValores.IconZoom = 60D;
            this.btnMenuValores.IsTab = false;
            this.btnMenuValores.Location = new System.Drawing.Point(0, 467);
            this.btnMenuValores.Name = "btnMenuValores";
            this.btnMenuValores.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuValores.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuValores.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuValores.selected = false;
            this.btnMenuValores.Size = new System.Drawing.Size(210, 48);
            this.btnMenuValores.TabIndex = 5;
            this.btnMenuValores.Text = "VALORES";
            this.btnMenuValores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuValores.Textcolor = System.Drawing.Color.White;
            this.btnMenuValores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuValores.Click += new System.EventHandler(this.btnMenuValores_Click);
            // 
            // panelSubVendas
            // 
            this.panelSubVendas.BackColor = System.Drawing.Color.Transparent;
            this.panelSubVendas.Controls.Add(this.bunifuFlatButton15);
            this.panelSubVendas.Controls.Add(this.bunifuFlatButton10);
            this.panelSubVendas.Controls.Add(this.bunifuFlatButton11);
            this.bunifuTLog.SetDecoration(this.panelSubVendas, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSubVendas, BunifuAnimatorNS.DecorationType.None);
            this.panelSubVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubVendas.Location = new System.Drawing.Point(0, 365);
            this.panelSubVendas.Name = "panelSubVendas";
            this.panelSubVendas.Size = new System.Drawing.Size(210, 102);
            this.panelSubVendas.TabIndex = 4;
            this.panelSubVendas.Visible = false;
            // 
            // bunifuFlatButton15
            // 
            this.bunifuFlatButton15.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton15.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton15.BorderRadius = 0;
            this.bunifuFlatButton15.ButtonText = "     Venda3";
            this.bunifuFlatButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton15, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton15, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton15.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton15.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton15.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton15.Iconimage = null;
            this.bunifuFlatButton15.Iconimage_right = null;
            this.bunifuFlatButton15.Iconimage_right_Selected = null;
            this.bunifuFlatButton15.Iconimage_Selected = null;
            this.bunifuFlatButton15.IconMarginLeft = 0;
            this.bunifuFlatButton15.IconMarginRight = 0;
            this.bunifuFlatButton15.IconRightVisible = true;
            this.bunifuFlatButton15.IconRightZoom = 0D;
            this.bunifuFlatButton15.IconVisible = true;
            this.bunifuFlatButton15.IconZoom = 60D;
            this.bunifuFlatButton15.IsTab = false;
            this.bunifuFlatButton15.Location = new System.Drawing.Point(0, 60);
            this.bunifuFlatButton15.Name = "bunifuFlatButton15";
            this.bunifuFlatButton15.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton15.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton15.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton15.selected = false;
            this.bunifuFlatButton15.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton15.TabIndex = 4;
            this.bunifuFlatButton15.Text = "     Venda3";
            this.bunifuFlatButton15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton15.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton15.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "     Venda2";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = null;
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 60D;
            this.bunifuFlatButton10.IsTab = false;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(0, 30);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton10.TabIndex = 3;
            this.bunifuFlatButton10.Text = "     Venda2";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "     Venda1";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = null;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 60D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton11.TabIndex = 2;
            this.bunifuFlatButton11.Text = "     Venda1";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "VENDAS";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 60D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 317);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(210, 48);
            this.bunifuFlatButton6.TabIndex = 3;
            this.bunifuFlatButton6.Text = "VENDAS";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // panelSubMenuCadastrar
            // 
            this.panelSubMenuCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.panelSubMenuCadastrar.Controls.Add(this.bunifuFlatButton5);
            this.panelSubMenuCadastrar.Controls.Add(this.bunifuFlatButton4);
            this.panelSubMenuCadastrar.Controls.Add(this.bunifuFlatButton2);
            this.panelSubMenuCadastrar.Controls.Add(this.btnMenuUsuario);
            this.panelSubMenuCadastrar.Controls.Add(this.btnMenuFuncao);
            this.bunifuTLog.SetDecoration(this.panelSubMenuCadastrar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSubMenuCadastrar, BunifuAnimatorNS.DecorationType.None);
            this.panelSubMenuCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCadastrar.Location = new System.Drawing.Point(0, 150);
            this.panelSubMenuCadastrar.Name = "panelSubMenuCadastrar";
            this.panelSubMenuCadastrar.Size = new System.Drawing.Size(210, 167);
            this.panelSubMenuCadastrar.TabIndex = 2;
            this.panelSubMenuCadastrar.Visible = false;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "     Animal";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 60D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 120);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton5.TabIndex = 10;
            this.bunifuFlatButton5.Text = "     Animal";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click_1);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "     Cilentes";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 60D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 90);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton4.TabIndex = 9;
            this.bunifuFlatButton4.Text = "     Cilentes";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Funcionário";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 60);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "     Funcionário";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuUsuario.BorderRadius = 0;
            this.btnMenuUsuario.ButtonText = "     Usuário";
            this.btnMenuUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuUsuario, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuUsuario, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuUsuario.Iconimage = null;
            this.btnMenuUsuario.Iconimage_right = null;
            this.btnMenuUsuario.Iconimage_right_Selected = null;
            this.btnMenuUsuario.Iconimage_Selected = null;
            this.btnMenuUsuario.IconMarginLeft = 0;
            this.btnMenuUsuario.IconMarginRight = 0;
            this.btnMenuUsuario.IconRightVisible = true;
            this.btnMenuUsuario.IconRightZoom = 0D;
            this.btnMenuUsuario.IconVisible = true;
            this.btnMenuUsuario.IconZoom = 60D;
            this.btnMenuUsuario.IsTab = false;
            this.btnMenuUsuario.Location = new System.Drawing.Point(0, 30);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuUsuario.selected = false;
            this.btnMenuUsuario.Size = new System.Drawing.Size(210, 30);
            this.btnMenuUsuario.TabIndex = 7;
            this.btnMenuUsuario.Text = "     Usuário";
            this.btnMenuUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUsuario.Textcolor = System.Drawing.Color.White;
            this.btnMenuUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUsuario.Click += new System.EventHandler(this.btnMenuUsuario_Click);
            // 
            // btnMenuFuncao
            // 
            this.btnMenuFuncao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuFuncao.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuFuncao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuFuncao.BorderRadius = 0;
            this.btnMenuFuncao.ButtonText = "     Função";
            this.btnMenuFuncao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuFuncao, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuFuncao, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuFuncao.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuFuncao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuFuncao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuFuncao.Iconimage = null;
            this.btnMenuFuncao.Iconimage_right = null;
            this.btnMenuFuncao.Iconimage_right_Selected = null;
            this.btnMenuFuncao.Iconimage_Selected = null;
            this.btnMenuFuncao.IconMarginLeft = 0;
            this.btnMenuFuncao.IconMarginRight = 0;
            this.btnMenuFuncao.IconRightVisible = true;
            this.btnMenuFuncao.IconRightZoom = 0D;
            this.btnMenuFuncao.IconVisible = true;
            this.btnMenuFuncao.IconZoom = 60D;
            this.btnMenuFuncao.IsTab = false;
            this.btnMenuFuncao.Location = new System.Drawing.Point(0, 0);
            this.btnMenuFuncao.Name = "btnMenuFuncao";
            this.btnMenuFuncao.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuFuncao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuFuncao.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuFuncao.selected = false;
            this.btnMenuFuncao.Size = new System.Drawing.Size(210, 30);
            this.btnMenuFuncao.TabIndex = 4;
            this.btnMenuFuncao.Text = "     Função";
            this.btnMenuFuncao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFuncao.Textcolor = System.Drawing.Color.White;
            this.btnMenuFuncao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFuncao.Click += new System.EventHandler(this.btnMenuFuncao_Click);
            // 
            // btnMenuCadastro
            // 
            this.btnMenuCadastro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuCadastro.BorderRadius = 0;
            this.btnMenuCadastro.ButtonText = "CADASTRO";
            this.btnMenuCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuCadastro, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuCadastro, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuCadastro.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCadastro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuCadastro.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuCadastro.Iconimage")));
            this.btnMenuCadastro.Iconimage_right = null;
            this.btnMenuCadastro.Iconimage_right_Selected = null;
            this.btnMenuCadastro.Iconimage_Selected = null;
            this.btnMenuCadastro.IconMarginLeft = 0;
            this.btnMenuCadastro.IconMarginRight = 0;
            this.btnMenuCadastro.IconRightVisible = true;
            this.btnMenuCadastro.IconRightZoom = 0D;
            this.btnMenuCadastro.IconVisible = true;
            this.btnMenuCadastro.IconZoom = 60D;
            this.btnMenuCadastro.IsTab = false;
            this.btnMenuCadastro.Location = new System.Drawing.Point(0, 102);
            this.btnMenuCadastro.Name = "btnMenuCadastro";
            this.btnMenuCadastro.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuCadastro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuCadastro.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuCadastro.selected = false;
            this.btnMenuCadastro.Size = new System.Drawing.Size(210, 48);
            this.btnMenuCadastro.TabIndex = 1;
            this.btnMenuCadastro.Text = "CADASTRO";
            this.btnMenuCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuCadastro.Textcolor = System.Drawing.Color.White;
            this.btnMenuCadastro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadastro.Click += new System.EventHandler(this.btnMenuCadastro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.label1);
            this.bunifuTLog.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 102);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.bunifuT.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTLog.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 85);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(186, 10);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pets e Pets";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // bunifuT
            // 
            this.bunifuT.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuT.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuT.DefaultAnimation = animation1;
            this.bunifuT.MaxAnimationTime = 3500;
            // 
            // panelSideBarhost
            // 
            this.panelSideBarhost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.panelSideBarhost.Controls.Add(this.panelSidebarBunifu);
            this.bunifuTLog.SetDecoration(this.panelSideBarhost, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSideBarhost, BunifuAnimatorNS.DecorationType.None);
            this.panelSideBarhost.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBarhost.Location = new System.Drawing.Point(0, 50);
            this.panelSideBarhost.Name = "panelSideBarhost";
            this.panelSideBarhost.Size = new System.Drawing.Size(220, 650);
            this.panelSideBarhost.TabIndex = 1;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.bunifuT.SetDecoration(this.lblFooter, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.lblFooter, BunifuAnimatorNS.DecorationType.None);
            this.lblFooter.Location = new System.Drawing.Point(3, 3);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(0, 13);
            this.lblFooter.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(188)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.lblFooter);
            this.bunifuTLog.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(220, 673);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 27);
            this.panel2.TabIndex = 3;
            // 
            // bunifuTLog
            // 
            this.bunifuTLog.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.bunifuTLog.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTLog.DefaultAnimation = animation2;
            this.bunifuTLog.TimeStep = 0.01F;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelWrapper);
            this.Controls.Add(this.panelSideBarhost);
            this.Controls.Add(this.panelTop);
            this.bunifuTLog.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.panelWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictlogo)).EndInit();
            this.panelSidebarBunifu.ResumeLayout(false);
            this.panelSubRelatorio.ResumeLayout(false);
            this.panelSubValores.ResumeLayout(false);
            this.panelSubVendas.ResumeLayout(false);
            this.panelSubMenuCadastrar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideBarhost.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelWrapper;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private BunifuAnimatorNS.BunifuTransition bunifuT;
        private System.Windows.Forms.PictureBox pictlogo;
        private BunifuAnimatorNS.BunifuTransition bunifuTLog;
        private Bunifu.Framework.UI.BunifuGradientPanel panelSidebarBunifu;
        private System.Windows.Forms.Panel panelSubRelatorio;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton19;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton14;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton13;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuRelatorio;
        private System.Windows.Forms.Panel panelSubValores;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton16;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton17;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton18;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuValores;
        private System.Windows.Forms.Panel panelSubVendas;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton15;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton10;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton11;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private System.Windows.Forms.Panel panelSubMenuCadastrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuFuncao;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuCadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSideBarhost;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuServicos;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuUsuario;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel panel2;
    }
}

