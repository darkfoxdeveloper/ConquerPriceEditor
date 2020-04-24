using ConquerItemPriceEditor.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ConquerItemPriceEditor
{
    public partial class Form1 : Form
    {
        private Itemtype itemtype;
        Sounds sound = new Sounds();
        private About aboutForm = new About();

        private int CurrentSearchIndex = 0;

        public Form1()
        {
            InitializeComponent();
            List<string> excludeControls = new List<string>();
            excludeControls.Add("loadItemtype");
            excludeControls.Add("console");
            excludeControls.Add("about");
            EnableTextbox(false, excludeControls);
        }

        private void EnableTextbox(bool enable, List<string> excludeControlIDs = null)
        {
            var ControlList = this.Controls.OfType<Control>().ToList();
            foreach (Control control in ControlList)
            {
                if (excludeControlIDs!= null)
                {
                    if (!excludeControlIDs.Contains(control.Name))
                    {
                        control.Enabled = enable;
                    }
                } else
                {
                    control.Enabled = enable;
                }
            }
        }

        private void loadItemtype_Click(object sender, EventArgs e)
        {
            LoadItemTypeTask();
        }

        private void LoadItemTypeTask()
        {
            if (decryptItemtype())
            {
                List<string> excludeControls = new List<string>();
                excludeControls.Add("loadItemtype");
                EnableTextbox(true);
                console.AppendText("\nitemtype.dat decrypted succesfully.");
                console.AppendText("\nLoading Items from itemtype.dat...");
                LoadItems(listBox1);
                console.AppendText("\nItems loaded succesfully.");
                sound.PlayStream(Properties.Resources.itemsLoaded);
            }
            else
            {
                console.AppendText("\nFallo al desencryptar el itemtype.dat.");
                sound.PlayStream(Properties.Resources.error);
            }
        }

        private bool decryptItemtype()
        {
            bool success = false;
            DialogResult result = openItemtype.ShowDialog();
            if (result == DialogResult.OK)
            {
                console.AppendText("\nLoading itemtype.dat...");
                string ext = Path.GetExtension(openItemtype.FileName);
                if (ext != ".dat")
                {
                    return true;
                }
                itemtype = new Itemtype(openItemtype.FileName);
                itemtype.Decrypt();
                success = true;
            } else
            {
                success = false;
            }
            return success;
        }

        private void LoadItems(ListBox list)
        {
            itemtype.LoadItems();
            foreach (var Item in itemtype.Items)
            {
                list.Items.Add("[" + Item.Get(Item.Atribute.ID)+"] " + Item.Get(Item.Atribute.Name));
            }
        }

        private void console_TextChanged(object sender, EventArgs e)
        {
            console.SelectionStart = console.Text.Length;
            console.ScrollToCaret();
        }

        private void save_Click(object sender, EventArgs e)
        {
            itemtype.SaveItems();
            console.AppendText("\nSaved successfully.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceMoney.Text = itemtype.Items[listBox1.SelectedIndex].Get(Item.Atribute.GoldWorth).ToString();
            priceConquerPoints.Text = itemtype.Items[listBox1.SelectedIndex].Get(Item.Atribute.ConquerPointsWorth).ToString();
            string img = itemtype.GetImagePath(itemtype.Items[listBox1.SelectedIndex]);
            previewImg.ImageLocation = img;
        }

        private void priceMoney_TextChanged(object sender, EventArgs e)
        {
            itemtype.Items[listBox1.SelectedIndex].ChangePrice(0, uint.Parse(((TextBox)sender).Text));
        }

        private void priceConquerPoints_TextChanged(object sender, EventArgs e)
        {
            itemtype.Items[listBox1.SelectedIndex].ChangePrice(1, uint.Parse(((TextBox)sender).Text));
        }

        private void searchItem_TextChanged(object sender, EventArgs e)
        {
            searchItemIndex();
        }

        private void searchItemIndex()
        {
            int index = FindMyStringInList(listBox1, searchItem.Text, CurrentSearchIndex, caseSensitiveSearch.Checked);
            if (index == -1)
            {
                listBox1.SetSelected(0, true);
                CurrentSearchIndex = 0;
            }
            else
            {
                listBox1.SetSelected(index, true);
                CurrentSearchIndex = index+1;
            }
        }

        int FindMyStringInList(ListBox lb, string searchString, int startIndex, bool caseSensitive = false)
        {
            for (int i = startIndex; i < lb.Items.Count; ++i)
            {
                string lbString = lb.Items[i].ToString();
                if (!caseSensitive)
                {
                    lbString = lbString.ToLower();
                    searchString = searchString.ToLower();
                }
                if (lbString.Contains(searchString))
                    return i;
            }
            return -1;
        }

        private void searchNext_Click(object sender, EventArgs e)
        {
            searchItemIndex();
        }

        private void about_Click(object sender, EventArgs e)
        {
            aboutForm.Show();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Have a backup of your 'itemtype.dat'. Before playing with him, for safety. By using the program you are accepting that use it is at your own risk.", "ConquerItemPriceEditor - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("tmp_preview.png"))
            {
                File.Delete("tmp_preview.png");
            }
        }
    }
}
