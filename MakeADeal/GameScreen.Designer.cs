namespace MakeADeal
{
    partial class GameScreen
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
            this.mainCanvas = new System.Windows.Forms.Panel();
            this.youWonOrLostLabel = new System.Windows.Forms.Label();
            this.resetToReplay = new System.Windows.Forms.Label();
            this.selectDoorLabel = new System.Windows.Forms.Label();
            this.RevealButton = new System.Windows.Forms.Button();
            this.switchDoorButton = new System.Windows.Forms.Button();
            this.door_3 = new System.Windows.Forms.Panel();
            this.panelDoor_3 = new System.Windows.Forms.Panel();
            this.door_2 = new System.Windows.Forms.Panel();
            this.panelDoor_2 = new System.Windows.Forms.Panel();
            this.door_1 = new System.Windows.Forms.Panel();
            this.panelDoor_1 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalGames = new System.Windows.Forms.Label();
            this.gamesWon = new System.Windows.Forms.Label();
            this.gamesLost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainCanvas.SuspendLayout();
            this.door_3.SuspendLayout();
            this.door_2.SuspendLayout();
            this.door_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.Transparent;
            this.mainCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainCanvas.Controls.Add(this.youWonOrLostLabel);
            this.mainCanvas.Controls.Add(this.resetToReplay);
            this.mainCanvas.Controls.Add(this.selectDoorLabel);
            this.mainCanvas.Controls.Add(this.RevealButton);
            this.mainCanvas.Controls.Add(this.switchDoorButton);
            this.mainCanvas.Controls.Add(this.door_3);
            this.mainCanvas.Controls.Add(this.door_2);
            this.mainCanvas.Controls.Add(this.door_1);
            this.mainCanvas.Location = new System.Drawing.Point(0, 0);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(500, 461);
            this.mainCanvas.TabIndex = 0;
            // 
            // youWonOrLostLabel
            // 
            this.youWonOrLostLabel.AutoSize = true;
            this.youWonOrLostLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youWonOrLostLabel.Location = new System.Drawing.Point(170, 296);
            this.youWonOrLostLabel.Name = "youWonOrLostLabel";
            this.youWonOrLostLabel.Size = new System.Drawing.Size(81, 29);
            this.youWonOrLostLabel.TabIndex = 6;
            this.youWonOrLostLabel.Text = "Status";
            // 
            // resetToReplay
            // 
            this.resetToReplay.AutoSize = true;
            this.resetToReplay.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetToReplay.Location = new System.Drawing.Point(87, 365);
            this.resetToReplay.Name = "resetToReplay";
            this.resetToReplay.Size = new System.Drawing.Size(276, 29);
            this.resetToReplay.TabIndex = 5;
            this.resetToReplay.Text = "Click Replay to play again";
            // 
            // selectDoorLabel
            // 
            this.selectDoorLabel.AutoSize = true;
            this.selectDoorLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDoorLabel.Location = new System.Drawing.Point(170, 262);
            this.selectDoorLabel.Name = "selectDoorLabel";
            this.selectDoorLabel.Size = new System.Drawing.Size(153, 29);
            this.selectDoorLabel.TabIndex = 4;
            this.selectDoorLabel.Text = "Select a door";
            // 
            // RevealButton
            // 
            this.RevealButton.Location = new System.Drawing.Point(138, 397);
            this.RevealButton.Name = "RevealButton";
            this.RevealButton.Size = new System.Drawing.Size(220, 40);
            this.RevealButton.TabIndex = 3;
            this.RevealButton.Text = "Reveal Selected Door";
            this.RevealButton.UseVisualStyleBackColor = true;
            this.RevealButton.Click += new System.EventHandler(this.RevealButton_Click);
            // 
            // switchDoorButton
            // 
            this.switchDoorButton.Location = new System.Drawing.Point(138, 328);
            this.switchDoorButton.Name = "switchDoorButton";
            this.switchDoorButton.Size = new System.Drawing.Size(220, 44);
            this.switchDoorButton.TabIndex = 2;
            this.switchDoorButton.Text = "Switch Door";
            this.switchDoorButton.UseVisualStyleBackColor = true;
            this.switchDoorButton.Click += new System.EventHandler(this.switchDoorButton_Click);
            // 
            // door_3
            // 
            this.door_3.BackColor = System.Drawing.Color.Transparent;
            this.door_3.BackgroundImage = global::MakeADeal.Properties.Resources.door;
            this.door_3.Controls.Add(this.panelDoor_3);
            this.door_3.Location = new System.Drawing.Point(355, 50);
            this.door_3.Name = "door_3";
            this.door_3.Size = new System.Drawing.Size(120, 160);
            this.door_3.TabIndex = 1;
            this.door_3.Click += new System.EventHandler(this.door_3_Click);
            // 
            // panelDoor_3
            // 
            this.panelDoor_3.Location = new System.Drawing.Point(3, 6);
            this.panelDoor_3.Name = "panelDoor_3";
            this.panelDoor_3.Size = new System.Drawing.Size(114, 151);
            this.panelDoor_3.TabIndex = 2;
            this.panelDoor_3.Visible = false;
            // 
            // door_2
            // 
            this.door_2.BackColor = System.Drawing.Color.Transparent;
            this.door_2.BackgroundImage = global::MakeADeal.Properties.Resources.door;
            this.door_2.Controls.Add(this.panelDoor_2);
            this.door_2.Location = new System.Drawing.Point(185, 50);
            this.door_2.Name = "door_2";
            this.door_2.Size = new System.Drawing.Size(120, 160);
            this.door_2.TabIndex = 1;
            this.door_2.Click += new System.EventHandler(this.door_2_Click);
            // 
            // panelDoor_2
            // 
            this.panelDoor_2.Location = new System.Drawing.Point(3, 6);
            this.panelDoor_2.Name = "panelDoor_2";
            this.panelDoor_2.Size = new System.Drawing.Size(114, 151);
            this.panelDoor_2.TabIndex = 1;
            this.panelDoor_2.Visible = false;
            // 
            // door_1
            // 
            this.door_1.BackColor = System.Drawing.Color.Transparent;
            this.door_1.BackgroundImage = global::MakeADeal.Properties.Resources.door;
            this.door_1.Controls.Add(this.panelDoor_1);
            this.door_1.Location = new System.Drawing.Point(19, 50);
            this.door_1.Name = "door_1";
            this.door_1.Size = new System.Drawing.Size(120, 160);
            this.door_1.TabIndex = 0;
            this.door_1.Click += new System.EventHandler(this.door_1_Click);
            // 
            // panelDoor_1
            // 
            this.panelDoor_1.Location = new System.Drawing.Point(6, 6);
            this.panelDoor_1.Name = "panelDoor_1";
            this.panelDoor_1.Size = new System.Drawing.Size(111, 151);
            this.panelDoor_1.TabIndex = 0;
            this.panelDoor_1.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(543, 330);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(151, 44);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Replay";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(543, 399);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(151, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Game Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalGames
            // 
            this.totalGames.AutoSize = true;
            this.totalGames.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalGames.Location = new System.Drawing.Point(639, 84);
            this.totalGames.Name = "totalGames";
            this.totalGames.Size = new System.Drawing.Size(20, 23);
            this.totalGames.TabIndex = 3;
            this.totalGames.Text = "0";
            // 
            // gamesWon
            // 
            this.gamesWon.AutoSize = true;
            this.gamesWon.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesWon.Location = new System.Drawing.Point(595, 140);
            this.gamesWon.Name = "gamesWon";
            this.gamesWon.Size = new System.Drawing.Size(24, 27);
            this.gamesWon.TabIndex = 4;
            this.gamesWon.Text = "0";
            // 
            // gamesLost
            // 
            this.gamesLost.AutoSize = true;
            this.gamesLost.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesLost.Location = new System.Drawing.Point(595, 182);
            this.gamesLost.Name = "gamesLost";
            this.gamesLost.Size = new System.Drawing.Size(24, 27);
            this.gamesLost.TabIndex = 5;
            this.gamesLost.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Games  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Won :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lost :";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamesLost);
            this.Controls.Add(this.gamesWon);
            this.Controls.Add(this.totalGames);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.mainCanvas);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.mainCanvas.ResumeLayout(false);
            this.mainCanvas.PerformLayout();
            this.door_3.ResumeLayout(false);
            this.door_2.ResumeLayout(false);
            this.door_1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainCanvas;
        private System.Windows.Forms.Panel door_1;
        private System.Windows.Forms.Panel door_3;
        private System.Windows.Forms.Panel door_2;
        private System.Windows.Forms.Panel panelDoor_3;
        private System.Windows.Forms.Panel panelDoor_2;
        private System.Windows.Forms.Panel panelDoor_1;
        private System.Windows.Forms.Button RevealButton;
        private System.Windows.Forms.Button switchDoorButton;
        private System.Windows.Forms.Label selectDoorLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalGames;
        private System.Windows.Forms.Label gamesWon;
        private System.Windows.Forms.Label gamesLost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resetToReplay;
        private System.Windows.Forms.Label youWonOrLostLabel;
    }
}