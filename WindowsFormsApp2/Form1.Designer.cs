
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Main = new AxWMPLib.AxWindowsMediaPlayer();
            this.Advertising = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Advertising)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Enabled = true;
            this.Main.Location = new System.Drawing.Point(-1, 0);
            this.Main.Name = "Main";
            this.Main.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Main.OcxState")));
            this.Main.Size = new System.Drawing.Size(1920, 1080);
            this.Main.TabIndex = 0;
            this.Main.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Main_PlayStateChange);
            // 
            // Advertising
            // 
            this.Advertising.Enabled = true;
            this.Advertising.Location = new System.Drawing.Point(-8, -20);
            this.Advertising.Name = "Advertising";
            this.Advertising.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Advertising.OcxState")));
            this.Advertising.Size = new System.Drawing.Size(1920, 1080);
            this.Advertising.TabIndex = 1;
            this.Advertising.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Advertising_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Advertising);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1366, 0);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Advertising)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Main;
        private AxWMPLib.AxWindowsMediaPlayer Advertising;
        private System.Windows.Forms.Timer timer1;
    }
}

