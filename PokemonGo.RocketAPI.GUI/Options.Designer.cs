namespace PokemonGo.RocketAPI.GUI
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.lbDelayPokestops = new System.Windows.Forms.Label();
            this.tbDelayPokestops = new System.Windows.Forms.TextBox();
            this.tbDelayPokemons = new System.Windows.Forms.TextBox();
            this.lbDelayPokemons = new System.Windows.Forms.Label();
            this.Lbdescdelay = new System.Windows.Forms.Label();
            this.btnsavesettings = new System.Windows.Forms.Button();
            this.tbCpKeepPokemon = new System.Windows.Forms.TextBox();
            this.lbCPkeepPokemon = new System.Windows.Forms.Label();
            this.tbIvKeepPokemon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMinBerry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWalkingSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDelayPokestops
            // 
            this.lbDelayPokestops.AutoSize = true;
            this.lbDelayPokestops.Location = new System.Drawing.Point(12, 15);
            this.lbDelayPokestops.Name = "lbDelayPokestops";
            this.lbDelayPokestops.Size = new System.Drawing.Size(139, 13);
            this.lbDelayPokestops.TabIndex = 0;
            this.lbDelayPokestops.Text = "Delay between pokestops ?";
            // 
            // tbDelayPokestops
            // 
            this.tbDelayPokestops.Location = new System.Drawing.Point(181, 12);
            this.tbDelayPokestops.Name = "tbDelayPokestops";
            this.tbDelayPokestops.Size = new System.Drawing.Size(100, 20);
            this.tbDelayPokestops.TabIndex = 1;
            // 
            // tbDelayPokemons
            // 
            this.tbDelayPokemons.Location = new System.Drawing.Point(181, 38);
            this.tbDelayPokemons.Name = "tbDelayPokemons";
            this.tbDelayPokemons.Size = new System.Drawing.Size(100, 20);
            this.tbDelayPokemons.TabIndex = 2;
            // 
            // lbDelayPokemons
            // 
            this.lbDelayPokemons.AutoSize = true;
            this.lbDelayPokemons.Location = new System.Drawing.Point(12, 41);
            this.lbDelayPokemons.Name = "lbDelayPokemons";
            this.lbDelayPokemons.Size = new System.Drawing.Size(139, 13);
            this.lbDelayPokemons.TabIndex = 3;
            this.lbDelayPokemons.Text = "Delay between pokemons ?";
            // 
            // Lbdescdelay
            // 
            this.Lbdescdelay.AutoSize = true;
            this.Lbdescdelay.ForeColor = System.Drawing.Color.Red;
            this.Lbdescdelay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Lbdescdelay.Location = new System.Drawing.Point(43, 61);
            this.Lbdescdelay.Name = "Lbdescdelay";
            this.Lbdescdelay.Size = new System.Drawing.Size(208, 39);
            this.Lbdescdelay.TabIndex = 4;
            this.Lbdescdelay.Text = "The delay must be specified in SECONDS.\r\nKeep in mind that lower delays will give" +
    "\r\nyou more ran away pokemons";
            this.Lbdescdelay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnsavesettings
            // 
            this.btnsavesettings.Location = new System.Drawing.Point(206, 444);
            this.btnsavesettings.Name = "btnsavesettings";
            this.btnsavesettings.Size = new System.Drawing.Size(75, 23);
            this.btnsavesettings.TabIndex = 5;
            this.btnsavesettings.Text = "Save Settings";
            this.btnsavesettings.UseVisualStyleBackColor = true;
            this.btnsavesettings.Click += new System.EventHandler(this.btnsavesettings_Click);
            // 
            // tbCpKeepPokemon
            // 
            this.tbCpKeepPokemon.Location = new System.Drawing.Point(181, 118);
            this.tbCpKeepPokemon.Name = "tbCpKeepPokemon";
            this.tbCpKeepPokemon.Size = new System.Drawing.Size(100, 20);
            this.tbCpKeepPokemon.TabIndex = 7;
            // 
            // lbCPkeepPokemon
            // 
            this.lbCPkeepPokemon.AutoSize = true;
            this.lbCPkeepPokemon.Location = new System.Drawing.Point(12, 121);
            this.lbCPkeepPokemon.Name = "lbCPkeepPokemon";
            this.lbCPkeepPokemon.Size = new System.Drawing.Size(161, 13);
            this.lbCPkeepPokemon.TabIndex = 6;
            this.lbCPkeepPokemon.Text = "Minimum CP to keep Pokemon ?";
            // 
            // tbIvKeepPokemon
            // 
            this.tbIvKeepPokemon.Location = new System.Drawing.Point(181, 144);
            this.tbIvKeepPokemon.Name = "tbIvKeepPokemon";
            this.tbIvKeepPokemon.Size = new System.Drawing.Size(100, 20);
            this.tbIvKeepPokemon.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Minimum IV to keep Pokemon ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(48, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minimum CP and IV affects which\r\npokemons are automatically transfered.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbMinBerry
            // 
            this.tbMinBerry.Location = new System.Drawing.Point(181, 214);
            this.tbMinBerry.Name = "tbMinBerry";
            this.tbMinBerry.Size = new System.Drawing.Size(100, 20);
            this.tbMinBerry.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Use Berry if Pokemon catch\r\npercentage is below ?";
            // 
            // lbWalkingSpeed
            // 
            this.lbWalkingSpeed.Location = new System.Drawing.Point(181, 264);
            this.lbWalkingSpeed.Name = "lbWalkingSpeed";
            this.lbWalkingSpeed.Size = new System.Drawing.Size(100, 20);
            this.lbWalkingSpeed.TabIndex = 14;
            this.lbWalkingSpeed.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Walking speed ? (KM)";
            this.label4.Visible = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 479);
            this.Controls.Add(this.lbWalkingSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMinBerry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIvKeepPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCpKeepPokemon);
            this.Controls.Add(this.lbCPkeepPokemon);
            this.Controls.Add(this.btnsavesettings);
            this.Controls.Add(this.Lbdescdelay);
            this.Controls.Add(this.lbDelayPokemons);
            this.Controls.Add(this.tbDelayPokemons);
            this.Controls.Add(this.tbDelayPokestops);
            this.Controls.Add(this.lbDelayPokestops);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(309, 518);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(309, 518);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDelayPokestops;
        private System.Windows.Forms.TextBox tbDelayPokestops;
        private System.Windows.Forms.TextBox tbDelayPokemons;
        private System.Windows.Forms.Label lbDelayPokemons;
        private System.Windows.Forms.Label Lbdescdelay;
        private System.Windows.Forms.Button btnsavesettings;
        private System.Windows.Forms.TextBox tbCpKeepPokemon;
        private System.Windows.Forms.Label lbCPkeepPokemon;
        private System.Windows.Forms.TextBox tbIvKeepPokemon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMinBerry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lbWalkingSpeed;
        private System.Windows.Forms.Label label4;
    }
}