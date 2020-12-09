
namespace PokemonWin
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tvwPokemon = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRowPerPage = new System.Windows.Forms.TextBox();
            this.txtPagina = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicación para Hackaton de Pokemones";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(251, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(107, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Listar Pokemones";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tvwPokemon
            // 
            this.tvwPokemon.Location = new System.Drawing.Point(12, 36);
            this.tvwPokemon.Name = "tvwPokemon";
            this.tvwPokemon.Size = new System.Drawing.Size(509, 283);
            this.tvwPokemon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros por Página";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saltear:";
            // 
            // txtRowPerPage
            // 
            this.txtRowPerPage.Location = new System.Drawing.Point(134, 323);
            this.txtRowPerPage.Name = "txtRowPerPage";
            this.txtRowPerPage.Size = new System.Drawing.Size(100, 22);
            this.txtRowPerPage.TabIndex = 4;
            // 
            // txtPagina
            // 
            this.txtPagina.Location = new System.Drawing.Point(421, 323);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(100, 22);
            this.txtPagina.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(421, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 14);
            this.lblStatus.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 355);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPagina);
            this.Controls.Add(this.txtRowPerPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvwPokemon);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon para Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TreeView tvwPokemon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRowPerPage;
        private System.Windows.Forms.TextBox txtPagina;
        private System.Windows.Forms.Label lblStatus;
    }
}

