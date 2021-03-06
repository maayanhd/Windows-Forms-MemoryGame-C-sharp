﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex05.GameUI
{
     public class FormSettings : Form
     {
          private Label m_LabelFirstPlayerName;
          private Label m_LabelBoardSize;
          private BoardSizeButton m_ButtonBoardSizeOptions;
          private Button m_ButtonStart;
          private PlayerNameTextBox m_TextBoxFirstPlayerName;
          private Button m_ButtonAgainstSecondPlayer;
          private PlayerNameTextBox m_TextBoxSecondPlayerName;
          private ColorDialog m_ColorDialog;
          private Label m_LabelSecondPlayerName;

          public FormSettings() : base()
          {
               initializeComponent();
          }

          private void initializeComponent()
          {
               this.StartPosition = FormStartPosition.CenterScreen;

               allocateControlsOfForm();

               // m_LabelFirstPlayerName
               designLabelFirstPlayerName();
               
               // m_LabelSecondPlayerName
               designLabelSecondPlayerName();

               // m_LabelBoardSize
               designLabelBoardSize();

               // m_ButtonBoardSizeOptions
               designButtonBoardSizeOptions();

               // m_ButtonStart
               designButtonStart();

               // m_TextBoxFirstPlayerName
               designTextBoxFirstPlayerName();

               // m_ButtonAgainstaFriend
               designButtonAgainstSecondPlayer();

               // m_TextBoxSecondPlayerName
               designTextBoxSecondPlayerName();

               // FormSettings
               this.ClientSize = new System.Drawing.Size(490, 200);

               addControlsToThisForm();

               designForm();
          }

          private void allocateControlsOfForm()
          {
               this.m_LabelFirstPlayerName = new System.Windows.Forms.Label();
               this.m_LabelSecondPlayerName = new System.Windows.Forms.Label();
               this.m_LabelBoardSize = new System.Windows.Forms.Label();
               this.m_ButtonBoardSizeOptions = new BoardSizeButton();
               this.m_ButtonStart = new System.Windows.Forms.Button();
               this.m_TextBoxFirstPlayerName = new PlayerNameTextBox();
               this.m_ButtonAgainstSecondPlayer = new System.Windows.Forms.Button();
               this.m_TextBoxSecondPlayerName = new PlayerNameTextBox();
               this.m_ColorDialog = new System.Windows.Forms.ColorDialog();
               this.SuspendLayout();
          }

          private void designLabelFirstPlayerName()
          {
               this.m_LabelFirstPlayerName.AutoSize = true;
               this.m_LabelFirstPlayerName.Enabled = false;
               this.m_LabelFirstPlayerName.Location = new System.Drawing.Point(23, 17);
               this.m_LabelFirstPlayerName.Name = "m_LabelFirstPlayerName";
               this.m_LabelFirstPlayerName.Size = new System.Drawing.Size(124, 17);
               this.m_LabelFirstPlayerName.TabIndex = 0;
               this.m_LabelFirstPlayerName.Text = "First Player Name:";
          }

          private void designTextBoxFirstPlayerName()
          {
               this.m_TextBoxFirstPlayerName.Location = new System.Drawing.Point(209, 17);
               this.m_TextBoxFirstPlayerName.Name = "m_TextBoxFirstPlayerName";
               this.m_TextBoxFirstPlayerName.Size = new System.Drawing.Size(130, 22);
               this.m_TextBoxFirstPlayerName.TabIndex = 1;
          }

          private void designLabelSecondPlayerName()
          {
               this.m_LabelSecondPlayerName.AutoSize = true;
               this.m_LabelSecondPlayerName.Enabled = false;
               this.m_LabelSecondPlayerName.Location = new System.Drawing.Point(23, 51);
               this.m_LabelSecondPlayerName.Name = "m_LabelSecondPlayerName";
               this.m_LabelSecondPlayerName.Size = new System.Drawing.Size(145, 17);
               this.m_LabelSecondPlayerName.TabIndex = 2;
               this.m_LabelSecondPlayerName.Text = "Second Player Name:";
          }

          private void designTextBoxSecondPlayerName()
          {
               this.m_TextBoxSecondPlayerName.Enabled = false;
               this.m_TextBoxSecondPlayerName.Location = new System.Drawing.Point(209, 51);
               this.m_TextBoxSecondPlayerName.Name = "m_TextBoxSecondPlayerName";
               this.m_TextBoxSecondPlayerName.ReadOnly = true;
               this.m_TextBoxSecondPlayerName.Size = new System.Drawing.Size(130, 22);
               this.m_TextBoxSecondPlayerName.TabIndex = 3;
               this.m_TextBoxSecondPlayerName.Text = "- computer -";
          }

          private void designButtonAgainstSecondPlayer()
          {
               this.m_ButtonAgainstSecondPlayer.AutoSize = true;
               this.m_ButtonAgainstSecondPlayer.Location = new System.Drawing.Point(345, 49);
               this.m_ButtonAgainstSecondPlayer.Name = "m_ButtonAgainstSecondPlayer";
               this.m_ButtonAgainstSecondPlayer.Size = new System.Drawing.Size(133, 27);
               this.m_ButtonAgainstSecondPlayer.TabIndex = 4;
               this.m_ButtonAgainstSecondPlayer.Text = "Against a Friend";
               this.m_ButtonAgainstSecondPlayer.UseVisualStyleBackColor = true;
               this.m_ButtonAgainstSecondPlayer.Click += new System.EventHandler(this.m_ButtonAgainstSecondPlayer_Click);
          }

          private void designLabelBoardSize()
          {
               this.m_LabelBoardSize.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left);
               this.m_LabelBoardSize.AutoSize = true;
               this.m_LabelBoardSize.Enabled = false;
               this.m_LabelBoardSize.Location = new System.Drawing.Point(23, 85);
               this.m_LabelBoardSize.Name = "m_LabelBoardSize";
               this.m_LabelBoardSize.Size = new System.Drawing.Size(81, 17);
               this.m_LabelBoardSize.TabIndex = 5;
               this.m_LabelBoardSize.Text = "Board Size:";
          }

          private void designButtonBoardSizeOptions()
          {
               this.m_ButtonBoardSizeOptions.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left);
               this.m_ButtonBoardSizeOptions.BackColor = System.Drawing.Color.FromArgb((int)((byte)192), (int)((byte)192), (int)((byte)255));
               this.m_ButtonBoardSizeOptions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
               this.m_ButtonBoardSizeOptions.Location = new System.Drawing.Point(26, 105);
               this.m_ButtonBoardSizeOptions.Name = "m_ButtonBoardSizeOptions";
               this.m_ButtonBoardSizeOptions.Size = new System.Drawing.Size(131, 81);
               this.m_ButtonBoardSizeOptions.TabIndex = 6;
               this.m_ButtonBoardSizeOptions.Text = "4 X 4";
               this.m_ButtonBoardSizeOptions.UseVisualStyleBackColor = false;
          }

          private void designButtonStart()
          {
               this.m_ButtonStart.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left
            | System.Windows.Forms.AnchorStyles.Right);
               this.m_ButtonStart.BackColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
               this.m_ButtonStart.Location = new System.Drawing.Point(378, 156);
               this.m_ButtonStart.Name = "m_ButtonStart";
               this.m_ButtonStart.Size = new System.Drawing.Size(100, 29);
               this.m_ButtonStart.TabIndex = 7;
               this.m_ButtonStart.Text = "Start!";
               this.m_ButtonStart.UseVisualStyleBackColor = false;
               this.m_ButtonStart.Click += m_ButtonStart_Click;
          }

          private void addControlsToThisForm()
          {
               this.Controls.Add(this.m_TextBoxSecondPlayerName);
               this.Controls.Add(this.m_ButtonAgainstSecondPlayer);
               this.Controls.Add(this.m_TextBoxFirstPlayerName);
               this.Controls.Add(this.m_ButtonStart);
               this.Controls.Add(this.m_ButtonBoardSizeOptions as Button);
               this.Controls.Add(this.m_LabelBoardSize);
               this.Controls.Add(this.m_LabelSecondPlayerName);
               this.Controls.Add(this.m_LabelFirstPlayerName);
          }

          private void designForm()
          {
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "FormSettings";
               this.Text = "Memory Game - Settings";
               this.ResumeLayout(false);
               this.PerformLayout();
          }

          private void m_ButtonStart_Click(object i_Sender, EventArgs i_E)
          {
              this.Close();               
          }

          private bool arePlayerNamesValid()
          {
               bool areThePlayerNamesValid = m_TextBoxFirstPlayerName.Text != string.Empty && m_TextBoxSecondPlayerName.Text != string.Empty;
                
               if (areThePlayerNamesValid == false)
               {
                    // Notifying the user names aren't valid
                    MessageBox.Show("Name field cannot be empty", "Cannot start the game", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }

               return areThePlayerNamesValid;
          }

          private void m_ButtonAgainstSecondPlayer_Click(object i_Sender, EventArgs i_E)
          {
               setSecondPlayerTypeButton();
               updateButtonAgainstSecondPlayerStatus();
               updateSecondPlayerTextBox();
          }

          private void setSecondPlayerTypeButton()
          {
               string rivalString = IsSecondPlayerComputer() ? "Computer" : "a Friend";
               m_ButtonAgainstSecondPlayer.Text = string.Format("Against {0}", rivalString);
          }

          private void updateButtonAgainstSecondPlayerStatus()
          {
               // Enabaling textbox in case of 2 human players and disabling in case of player vs computer option
               m_TextBoxSecondPlayerName.Enabled = !m_TextBoxSecondPlayerName.Enabled;
               m_TextBoxSecondPlayerName.ReadOnly = !m_TextBoxSecondPlayerName.ReadOnly;
          }

          private void updateSecondPlayerTextBox()
          {
               if (IsSecondPlayerComputer() == false)
               {
                    m_TextBoxSecondPlayerName.Text = string.Empty;
               }
               else
               {
                    m_TextBoxSecondPlayerName.Text = "- computer -";
               }
          }

          internal bool IsSecondPlayerComputer()
          {
               // Checking whether the second text box was enabled meaning human player
               return m_TextBoxSecondPlayerName.Enabled == false && m_TextBoxSecondPlayerName.ReadOnly == true;
          }

          internal string Player1Name
          {
               get
               {
                    return m_TextBoxFirstPlayerName.Text;
               }
          }

          internal string Player2Name
          {
               get
               {
                    return m_TextBoxSecondPlayerName.Text;
               }
          }

          internal void GetBoardMeasurements(out int[] o_BoardMeasurements)
          {
               o_BoardMeasurements = new int[2];
               o_BoardMeasurements[0] = int.Parse(m_ButtonBoardSizeOptions.Text[0].ToString());
               o_BoardMeasurements[1] = int.Parse(m_ButtonBoardSizeOptions.Text[m_ButtonBoardSizeOptions.Text.Length - 1].ToString());
          }

          protected override void OnFormClosing(FormClosingEventArgs i_E)
          {
               if (arePlayerNamesValid() == false)
               {
                    i_E.Cancel = true;
               }

               base.OnFormClosing(i_E);
          }
     }
}
