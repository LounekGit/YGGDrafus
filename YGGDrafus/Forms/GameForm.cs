﻿using AxShockwaveFlashObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;


namespace YGGDrafus
{
    public partial class GameForm : Form
    {
        private readonly List<string> packets;
        private readonly string gamePath;

        public GameForm(String gamePath)
        {
            InitializeComponent();
            packets = new List<string>();
            this.gamePath = gamePath;
        }

        #region Initialization
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitGame();
            InitText();
        }

        private void InitGame()
        {
            // Launch the game
            gameAxShockwaveFlash.Movie = gamePath;

            // Communicate with Flash
            gameAxShockwaveFlash.FlashCall += new _IShockwaveFlashEvents_FlashCallEventHandler(GameAxShockwaveFlash_FlashCall);
        }

        private void InitText()
        {
            indexLabel.Text = (GetIndex() + 1).ToString();
        }

        #endregion

        #region Flash Communication

        private static XmlDocument ReadFlashCall(string request)
        {
            XmlDocument document = new XmlDocument() { XmlResolver = null };
            StringReader stringReader = new StringReader(request);
            XmlReader xmlReader = null;
            try
            {
                xmlReader = XmlReader.Create(input: stringReader, settings: new XmlReaderSettings() { XmlResolver = null });
                document.Load(xmlReader);
            }
            finally
            {
                if (xmlReader != null)
                    xmlReader.Close();
                else
                    document = null;
            }
            return document;
        }

        private void GameAxShockwaveFlash_FlashCall(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
        {

            XmlDocument document = ReadFlashCall(e.request);

            if (document != null)
            {
                String nameFunction = document.DocumentElement.GetAttribute("name");
                document.ToString();
                //Set all arg into an ArrayList
                ArrayList args = new ArrayList();
                foreach (XmlNode arg in document.GetElementsByTagName("arguments")[0].ChildNodes)
                {
                    if (String.Equals(arg.Name, "false", StringComparison.Ordinal) || String.Equals(arg.Name, "true", StringComparison.Ordinal))
                        args.Add(Boolean.Parse(arg.Name));
                    else
                        args.Add(arg.InnerText);
                }
                
                switch (nameFunction)
                {
                    case "userLog":
                        break;
                    case "debugRequest":
                        DebugRequest(args);
                        break;
                    case "makeNotification":
                        MakeNotification((String)args[0]);
                        break;
                    case "setLoginDiscordActivity":
                        SetLoginDiscordActivity();
                        break;
                    case "setIngameDiscordActivity":
                        SetIngameDiscordActivity(args);
                        break;
                    case "changeTitle":
                        break;
                }
            }
        }
        
        private void DebugRequest(ArrayList args)
        {
            String data, playerName, currentServer, arrow, message;

            if(String.IsNullOrEmpty(args[0].ToString()))
                arrow = "<-->";
            else
            {
                arrow = (bool)args[0] ? "-->" : "<--";
            } 
            data = String.IsNullOrEmpty(args[2].ToString()) ? null : args[2].ToString();
            playerName = String.IsNullOrEmpty(args[3].ToString()) ? null : args[3].ToString();
            currentServer = String.IsNullOrEmpty(args[4].ToString()) ? null : args[4].ToString();
            
            if (playerName == null)
                message = arrow + " " + data;
            else
                message = "(" + playerName + ", " + currentServer + ") " + arrow + " " + data;

            packets.Insert(0, message);
            if (packets.Count > 100)
                packets.RemoveAt(100);
        }

        private void MakeNotification(String message)
        {
            message = message.Replace("\r\n","");
            if (message.Length > 100)
                message = message.Substring(0, 100) + "...";

            ((MainForm)MdiParent).MakeNotification((String)((MainForm)MdiParent).GameListToolStripComboBox.Items[GetIndex()], message);

        }

        private void SetLoginDiscordActivity()
        {

            pictureBoxLogo.ImageLocation = @"img\login.png";
            ((MainForm)MdiParent).GameListToolStripComboBox.Items[GetIndex()] = (GetIndex() + 1) + " - Connexion";
        }

        private void SetIngameDiscordActivity(ArrayList args)
        {
            String playerPseudo = (String)args[2];
            int classId = Convert.ToInt16(args[5], NumberFormatInfo.InvariantInfo);
            int sexeId = Convert.ToByte(args[6], NumberFormatInfo.InvariantInfo);
            String logo = @"img\login.png";
            switch(classId)
            {
                case 1: //Feca
                    if (sexeId == 1)
                        logo = @"img\fecaF.png";
                    else
                        logo = @"img\fecaM.png";
                    break;
                case 2: //Osamodas
                    if (sexeId == 1)
                        logo = @"img\osaF.png";
                    else
                        logo = @"img\osaM.png";
                    break;
                case 3: //Enutrof
                    if (sexeId == 1)
                        logo = @"img\enuF.png";
                    else
                        logo = @"img\enuM.png";
                    break;
                case 4: //Sram
                    if (sexeId == 1)
                        logo = @"img\sramF.png";
                    else
                        logo = @"img\sramM.png";
                    break;
                case 5: //Xelor
                    if (sexeId == 1)
                        logo = @"img\xelF.png";
                    else
                        logo = @"img\xelM.png";
                    break;
                case 6: //Ecaflip
                    if (sexeId == 1)
                        logo = @"img\ecaF.png";
                    else
                        logo = @"img\ecaM.png";
                    break;
                case 7: //Eniripsa
                    if (sexeId == 1)
                        logo = @"img\eniF.png";
                    else
                        logo = @"img\eniM.png";
                    break;
                case 8: //Iop
                    if (sexeId == 1)
                        logo = @"img\iopF.png";
                    else
                        logo = @"img\iopM.png";
                    break;
                case 9: //Cra
                    if (sexeId == 1)
                        logo = @"img\craF.png";
                    else
                        logo = @"img\craM.png";
                    break;
                case 10: //Sadida
                    if (sexeId == 1)
                        logo = @"img\sadiF.png";
                    else
                        logo = @"img\sadiM.png";
                    break;
                case 11: //Sacrieur
                    if (sexeId == 1)
                        logo = @"img\sacriF.png";
                    else
                        logo = @"img\sacriM.png";
                    break;
                case 12: //Pandawa
                    if (sexeId == 1)
                        logo = @"img\pandaF.png";
                    else
                        logo = @"img\pandaM.png";
                    break;
            }
            ((MainForm)MdiParent).GameListToolStripComboBox.Items[GetIndex()] = (GetIndex() + 1) + " - " + playerPseudo;
            pictureBoxLogo.ImageLocation = logo;
        }

        #endregion

        private int GetIndex()
        {
            int index = 0;

            foreach (Form child in ((MainForm)MdiParent).Children)
            {
                if (child.Equals(this))
                    break;
                index++;
            }
            return index;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            CloseGame();
        }

        public void CloseGame()
        {
            ToolStripComboBox cb = ((MainForm)MdiParent).GameListToolStripComboBox;
            int index = GetIndex();

            cb.Items.RemoveAt(index);
            ((MainForm)MdiParent).Children.RemoveAt(index);

            if (cb.Items.Count < 8)
                ((MainForm)MdiParent).NewToolStripMenuItem.Enabled = true;

            if (index < cb.Items.Count)
                cb.SelectedIndex = index;
            else if (cb.Items.Count != 0)
                cb.SelectedIndex = 0;
            else
                cb.Text = "";

            ((MainForm)MdiParent).ReorganizeGameListText();

            Close();
        }
    }
}
