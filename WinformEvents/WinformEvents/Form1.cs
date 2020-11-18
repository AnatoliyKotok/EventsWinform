using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EventPlenning eventPlenning = new EventPlenning();
        string fname = "Event.txt";

        private void btAddEvent_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("You can't sat this date");
            }
            else if (textBoxName.Text == null || comboBoxLevelImp.SelectedItem == null)
            {
                MessageBox.Show("Element of piles is not correct");
            }
            else
            {
                Event ev = new Event(textBoxName.Text, dateTimePicker1.Value, (ImportanceLevel)comboBoxLevelImp.SelectedIndex);
                listBoxEvents.Items.Add(ev);
                textBoxName.Text = null;
                dateTimePicker1.Value = DateTime.Today;
                comboBoxLevelImp.Text = null;
            }
        }

        private void btClearList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxEvents.Items.Count; i++)
            {
                listBoxEvents.Items.RemoveAt(i);
            }
        }

        private void btDelSelected_Click(object sender, EventArgs e)
        {
            
            listBoxEvents.Items.Remove(listBoxEvents.SelectedItem);
            
        }

        private void btFindEv_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < listBoxEvents.Items.Count; i++)
            {
                Event ev = (Event)listBoxEvents.Items[i];
                if (ev.Name == textBoxFName.Text)
                {
                    listBoxEvents.SetSelected(i,true);
                }
            }
            
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Event ev = (Event)listBoxEvents.SelectedItem;
            textBoxName.Text = ev.Name;
            dateTimePicker1.Value = ev.Date;
            comboBoxLevelImp.SelectedItem = ev.impLevel;
            listBoxEvents.Items.Remove(listBoxEvents.SelectedItem);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(fname, true, System.Text.Encoding.Default))
            {
                foreach ( var item in listBoxEvents.Items)
                {

                   sw.WriteLine(item);
                }
            }
           
        }
    }
}
