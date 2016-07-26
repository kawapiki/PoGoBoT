namespace PokemonGo.RocketAPI.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKeepPkToEvolve = new System.Windows.Forms.CheckBox();
            this.btnRecycleItems = new System.Windows.Forms.Button();
            this.btnTransferDuplicates = new System.Windows.Forms.Button();
            this.btnEvolvePokemons = new System.Windows.Forms.Button();
            this.btnStopFarming = new System.Windows.Forms.Button();
            this.btnStartFarming = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPkmnCaptured = new System.Windows.Forms.Label();
            this.lbPkmnHr = new System.Windows.Forms.Label();
            this.lbExpHour = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbItemsInventory = new System.Windows.Forms.Label();
            this.lbPokemonsInventory = new System.Windows.Forms.Label();
            this.lbExperience = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.loggingBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxPokestopCount = new System.Windows.Forms.TextBox();
            this.boxPokestopInit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxPokestopName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.boxPokemonName = new System.Windows.Forms.TextBox();
            this.boxPokemonCaughtProb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuckyEgg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuckyEgg);
            this.groupBox1.Controls.Add(this.cbKeepPkToEvolve);
            this.groupBox1.Controls.Add(this.btnRecycleItems);
            this.groupBox1.Controls.Add(this.btnTransferDuplicates);
            this.groupBox1.Controls.Add(this.btnEvolvePokemons);
            this.groupBox1.Controls.Add(this.btnStopFarming);
            this.groupBox1.Controls.Add(this.btnStartFarming);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // cbKeepPkToEvolve
            // 
            this.cbKeepPkToEvolve.AutoSize = true;
            this.cbKeepPkToEvolve.Checked = true;
            this.cbKeepPkToEvolve.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKeepPkToEvolve.Enabled = false;
            this.cbKeepPkToEvolve.Location = new System.Drawing.Point(6, 269);
            this.cbKeepPkToEvolve.Name = "cbKeepPkToEvolve";
            this.cbKeepPkToEvolve.Size = new System.Drawing.Size(181, 17);
            this.cbKeepPkToEvolve.TabIndex = 5;
            this.cbKeepPkToEvolve.Text = "Keep Pokemons that can evolve";
            this.cbKeepPkToEvolve.UseVisualStyleBackColor = true;
            // 
            // btnRecycleItems
            // 
            this.btnRecycleItems.Enabled = false;
            this.btnRecycleItems.Location = new System.Drawing.Point(6, 292);
            this.btnRecycleItems.Name = "btnRecycleItems";
            this.btnRecycleItems.Size = new System.Drawing.Size(187, 46);
            this.btnRecycleItems.TabIndex = 4;
            this.btnRecycleItems.Text = "Recycle Items";
            this.btnRecycleItems.UseVisualStyleBackColor = true;
            this.btnRecycleItems.Click += new System.EventHandler(this.btnRecycleItems_Click);
            // 
            // btnTransferDuplicates
            // 
            this.btnTransferDuplicates.Enabled = false;
            this.btnTransferDuplicates.Location = new System.Drawing.Point(6, 217);
            this.btnTransferDuplicates.Name = "btnTransferDuplicates";
            this.btnTransferDuplicates.Size = new System.Drawing.Size(187, 46);
            this.btnTransferDuplicates.TabIndex = 3;
            this.btnTransferDuplicates.Text = "Transfer Duplicate Pokemons";
            this.btnTransferDuplicates.UseVisualStyleBackColor = true;
            this.btnTransferDuplicates.Click += new System.EventHandler(this.btnTransferDuplicates_Click);
            // 
            // btnEvolvePokemons
            // 
            this.btnEvolvePokemons.Enabled = false;
            this.btnEvolvePokemons.Location = new System.Drawing.Point(6, 165);
            this.btnEvolvePokemons.Name = "btnEvolvePokemons";
            this.btnEvolvePokemons.Size = new System.Drawing.Size(187, 46);
            this.btnEvolvePokemons.TabIndex = 2;
            this.btnEvolvePokemons.Text = "Evolve Pokemons w/Candy";
            this.btnEvolvePokemons.UseVisualStyleBackColor = true;
            this.btnEvolvePokemons.Click += new System.EventHandler(this.btnEvolvePokemons_Click);
            // 
            // btnStopFarming
            // 
            this.btnStopFarming.Enabled = false;
            this.btnStopFarming.Location = new System.Drawing.Point(6, 48);
            this.btnStopFarming.Name = "btnStopFarming";
            this.btnStopFarming.Size = new System.Drawing.Size(187, 23);
            this.btnStopFarming.TabIndex = 1;
            this.btnStopFarming.Text = "Stop Farming";
            this.btnStopFarming.UseVisualStyleBackColor = true;
            this.btnStopFarming.Click += new System.EventHandler(this.btnStopFarming_Click);
            // 
            // btnStartFarming
            // 
            this.btnStartFarming.Enabled = false;
            this.btnStartFarming.Location = new System.Drawing.Point(6, 19);
            this.btnStartFarming.Name = "btnStartFarming";
            this.btnStartFarming.Size = new System.Drawing.Size(187, 23);
            this.btnStartFarming.TabIndex = 0;
            this.btnStartFarming.Text = "Start Farming";
            this.btnStartFarming.UseVisualStyleBackColor = true;
            this.btnStartFarming.Click += new System.EventHandler(this.btnStartFarming_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPkmnCaptured);
            this.groupBox3.Controls.Add(this.lbPkmnHr);
            this.groupBox3.Controls.Add(this.lbExpHour);
            this.groupBox3.Location = new System.Drawing.Point(12, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 74);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stats";
            // 
            // lbPkmnCaptured
            // 
            this.lbPkmnCaptured.AutoSize = true;
            this.lbPkmnCaptured.Location = new System.Drawing.Point(6, 51);
            this.lbPkmnCaptured.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbPkmnCaptured.Name = "lbPkmnCaptured";
            this.lbPkmnCaptured.Size = new System.Drawing.Size(85, 13);
            this.lbPkmnCaptured.TabIndex = 3;
            this.lbPkmnCaptured.Text = "lbPkmnCaptured";
            // 
            // lbPkmnHr
            // 
            this.lbPkmnHr.AutoSize = true;
            this.lbPkmnHr.Location = new System.Drawing.Point(6, 35);
            this.lbPkmnHr.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbPkmnHr.Name = "lbPkmnHr";
            this.lbPkmnHr.Size = new System.Drawing.Size(53, 13);
            this.lbPkmnHr.TabIndex = 1;
            this.lbPkmnHr.Text = "lbPkmnHr";
            // 
            // lbExpHour
            // 
            this.lbExpHour.AutoSize = true;
            this.lbExpHour.Location = new System.Drawing.Point(6, 19);
            this.lbExpHour.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbExpHour.Name = "lbExpHour";
            this.lbExpHour.Size = new System.Drawing.Size(56, 13);
            this.lbExpHour.TabIndex = 0;
            this.lbExpHour.Text = "lbExpHour";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbItemsInventory);
            this.groupBox4.Controls.Add(this.lbPokemonsInventory);
            this.groupBox4.Controls.Add(this.lbExperience);
            this.groupBox4.Controls.Add(this.lbLevel);
            this.groupBox4.Controls.Add(this.lbName);
            this.groupBox4.Location = new System.Drawing.Point(12, 495);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 103);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information";
            // 
            // lbItemsInventory
            // 
            this.lbItemsInventory.AutoSize = true;
            this.lbItemsInventory.Location = new System.Drawing.Point(6, 83);
            this.lbItemsInventory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbItemsInventory.Name = "lbItemsInventory";
            this.lbItemsInventory.Size = new System.Drawing.Size(84, 13);
            this.lbItemsInventory.TabIndex = 4;
            this.lbItemsInventory.Text = "lbItemsInventory";
            // 
            // lbPokemonsInventory
            // 
            this.lbPokemonsInventory.AutoSize = true;
            this.lbPokemonsInventory.Location = new System.Drawing.Point(6, 67);
            this.lbPokemonsInventory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbPokemonsInventory.Name = "lbPokemonsInventory";
            this.lbPokemonsInventory.Size = new System.Drawing.Size(65, 13);
            this.lbPokemonsInventory.TabIndex = 3;
            this.lbPokemonsInventory.Text = "lbPokemons";
            // 
            // lbExperience
            // 
            this.lbExperience.AutoSize = true;
            this.lbExperience.Location = new System.Drawing.Point(6, 51);
            this.lbExperience.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbExperience.Name = "lbExperience";
            this.lbExperience.Size = new System.Drawing.Size(68, 13);
            this.lbExperience.TabIndex = 2;
            this.lbExperience.Text = "lbExperience";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(6, 35);
            this.lbLevel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(41, 13);
            this.lbLevel.TabIndex = 1;
            this.lbLevel.Text = "lbLevel";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 19);
            this.lbName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "lbName";
            // 
            // loggingBox
            // 
            this.loggingBox.Enabled = false;
            this.loggingBox.Location = new System.Drawing.Point(217, 91);
            this.loggingBox.Multiline = true;
            this.loggingBox.Name = "loggingBox";
            this.loggingBox.Size = new System.Drawing.Size(415, 507);
            this.loggingBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.boxPokestopCount);
            this.groupBox2.Controls.Add(this.boxPokestopInit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.boxPokestopName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(217, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Pokestop";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "of";
            // 
            // boxPokestopCount
            // 
            this.boxPokestopCount.Enabled = false;
            this.boxPokestopCount.Location = new System.Drawing.Point(148, 45);
            this.boxPokestopCount.Name = "boxPokestopCount";
            this.boxPokestopCount.Size = new System.Drawing.Size(61, 20);
            this.boxPokestopCount.TabIndex = 8;
            this.boxPokestopCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxPokestopInit
            // 
            this.boxPokestopInit.Enabled = false;
            this.boxPokestopInit.Location = new System.Drawing.Point(57, 45);
            this.boxPokestopInit.Name = "boxPokestopInit";
            this.boxPokestopInit.Size = new System.Drawing.Size(63, 20);
            this.boxPokestopInit.TabIndex = 3;
            this.boxPokestopInit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Count";
            // 
            // boxPokestopName
            // 
            this.boxPokestopName.Enabled = false;
            this.boxPokestopName.Location = new System.Drawing.Point(57, 19);
            this.boxPokestopName.Name = "boxPokestopName";
            this.boxPokestopName.Size = new System.Drawing.Size(152, 20);
            this.boxPokestopName.TabIndex = 1;
            this.boxPokestopName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.boxPokemonName);
            this.groupBox5.Controls.Add(this.boxPokemonCaughtProb);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(438, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 73);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fighting Pokemon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Capture %";
            // 
            // boxPokemonName
            // 
            this.boxPokemonName.Enabled = false;
            this.boxPokemonName.Location = new System.Drawing.Point(67, 19);
            this.boxPokemonName.Name = "boxPokemonName";
            this.boxPokemonName.Size = new System.Drawing.Size(118, 20);
            this.boxPokemonName.TabIndex = 11;
            this.boxPokemonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxPokemonCaughtProb
            // 
            this.boxPokemonCaughtProb.Enabled = false;
            this.boxPokemonCaughtProb.Location = new System.Drawing.Point(67, 45);
            this.boxPokemonCaughtProb.Name = "boxPokemonCaughtProb";
            this.boxPokemonCaughtProb.Size = new System.Drawing.Size(118, 20);
            this.boxPokemonCaughtProb.TabIndex = 18;
            this.boxPokemonCaughtProb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 610);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "https://github.com/WooAf/PoGoBoT";
            // 
            // btnLuckyEgg
            // 
            this.btnLuckyEgg.Enabled = false;
            this.btnLuckyEgg.Location = new System.Drawing.Point(6, 77);
            this.btnLuckyEgg.Name = "btnLuckyEgg";
            this.btnLuckyEgg.Size = new System.Drawing.Size(187, 23);
            this.btnLuckyEgg.TabIndex = 8;
            this.btnLuckyEgg.Text = "Use Lucky egg";
            this.btnLuckyEgg.UseVisualStyleBackColor = true;
            this.btnLuckyEgg.Visible = false;
            this.btnLuckyEgg.Click += new System.EventHandler(this.btnLuckyEgg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.loggingBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 671);
            this.MinimumSize = new System.Drawing.Size(660, 671);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoGoBoT - GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStopFarming;
        private System.Windows.Forms.Button btnStartFarming;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbPkmnCaptured;
        private System.Windows.Forms.Label lbPkmnHr;
        private System.Windows.Forms.Label lbExpHour;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox loggingBox;
        private System.Windows.Forms.Button btnRecycleItems;
        private System.Windows.Forms.Button btnTransferDuplicates;
        private System.Windows.Forms.Button btnEvolvePokemons;
        private System.Windows.Forms.CheckBox cbKeepPkToEvolve;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxPokestopCount;
        private System.Windows.Forms.TextBox boxPokestopInit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxPokestopName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxPokemonName;
        private System.Windows.Forms.TextBox boxPokemonCaughtProb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbExperience;
        private System.Windows.Forms.Label lbItemsInventory;
        private System.Windows.Forms.Label lbPokemonsInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuckyEgg;
    }
}

