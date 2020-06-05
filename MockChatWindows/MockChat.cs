﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockChatWindows
{
    public partial class MockChat : Form
    {


        public MockChat()
        {
            InitializeComponent();
            this.ActiveControl = textEntryBox;
        }

        private void MockButtonClick(object sender, EventArgs e)
        {
            String mocked = Mock(textEntryBox.Text);
            mockTextBox.Text = mocked.TrimEnd('\n', '\r');
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            mockTextBox.Clear();
            textEntryBox.Clear();
        }

        private void MockTextBoxClicked(object sender, EventArgs e)
        {
            mockTextBox.SelectionStart = 0;
            mockTextBox.SelectionLength = mockTextBox.Text.Length;
            Clipboard.SetText(mockTextBox.Text);
        }

        private void FileClose(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void About(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void CloseButton(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private String Mock(String mockText)
        {
            char[] mockArr = mockText.ToCharArray();
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            int randomResult;
            String upper;
            String lower;

            for (int i = 0; i < mockArr.Length; i++)
            {
                randomResult = r.Next(0, 2);

                switch (randomResult)
                {
                    case 0:
                        lower = mockArr[i].ToString();
                        lower = lower.ToLower();
                        sb.Append(lower);
                        break;
                    case 1:
                        upper = mockArr[i].ToString();
                        upper = upper.ToUpper();
                        sb.Append(upper);
                        break;
                }

            }

            return sb.ToString();
        }
    }
}
