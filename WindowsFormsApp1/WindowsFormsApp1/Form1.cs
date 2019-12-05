using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection();
        DataTable theData = new DataTable();
        string connectionString = "";
        string dbs = "contactlist"; 
        string uid = "dbremoteuser"; 
           // "dbsAdmin";
        string pas = "password";
        int row = 0;
        int maxCount = 0;

        private string BuildConnectionSring(string database, string uid, string pword)
        {
            string serverIP = "";
            try
            {
                using (StreamReader sr = new StreamReader("C:\\VFW\\connect.txt")) { serverIP = sr.ReadToEnd(); }
                string prt = "3306";
                return "server=" + serverIP + ";uid=" + uid + ";pwd=" + pword + ";database=" + database + ";port=" + prt + ";SslMode=none";
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); return "ERROR"; }
        }

        private void Connect(string myConnectionString, string database)
        {
            try { conn.ConnectionString = myConnectionString; conn.Open(); }
            catch (MySqlException e)
            {
                string msg = "";
                switch (e.Number)
                {
                    case 0: { msg = e.ToString(); break; }
                    case 1042: { msg = "Can't Resolve Host Address.\n" + myConnectionString; break; }
                    case 1045: { msg = "Invalid Username or Password"; break; }
                    default: { msg = e.ToString() + "\n" + myConnectionString; break; }
                }
                MessageBox.Show(msg);
            }
        }

        public Form1()
        {
            InitializeComponent();
            HandleClientWindowSize();
            connectionString = BuildConnectionSring(dbs, uid, pas);
            Connect(connectionString, dbs);
            LoadList();
            RelationComboBox.Text = "Buisness";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string FirstName = "", LastName = "", PhoneNumber = "", Email = "", Relation = "", sqlString = "";
            FirstName = FirstNameTextBox.Text;
            LastName = LastNameTextBox.Text;
            PhoneNumber = PhoneNumberNUP.Value.ToString();
            Email = EmailTextBox.Text;
            Relation = RelationComboBox.Text;
            if (beforeAdd(Email))
            {
                sqlString = "INSERT INTO mycontacts (FirstName, LastName, PhoneNumber, Email, Relation) VALUES (\"" +
                    FirstName + "\", \"" + LastName + "\", \"" + PhoneNumber + "\", \"" + Email + "\", \"" + Relation + "\" ) ";
                WriteToDatabase(sqlString, FirstName, LastName, PhoneNumber, Email, Relation);
                LoadList();
            }
        }

        public void LoadList()
        {
            ContactListView.Clear();
            theData.Clear();
            string sqlString = "SELECT FirstName, LastName, PhoneNumber, Email, Relation FROM mycontacts";
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlString, conn);
            adr.SelectCommand.CommandType = CommandType.Text;
            adr.Fill(theData);
            int numberOfRecords = theData.Select().Length;
            maxCount = numberOfRecords;
            rowLabel.Text = (row + 1) + " of " + maxCount;
            for (int i = 0; i < theData.Rows.Count; i++)
            {
                DataRow theRow = theData.Rows[i];
                ListViewItem lvi = new ListViewItem(theRow["FirstName"].ToString());
                lvi.SubItems.Add(theRow["LastName"].ToString());
                lvi.SubItems.Add(theRow["PhoneNumber"].ToString());
                lvi.SubItems.Add(theRow["Email"].ToString());
                lvi.SubItems.Add(theRow["Relation"].ToString());
                switch (theRow["Relation"].ToString())
                {
                    case "Family":
                        lvi.ImageIndex = 0;
                        break;

                    case "Friend":
                        lvi.ImageIndex = 1;
                        break;

                    case "Buisness":
                        lvi.ImageIndex = 2;
                        break;

                    case "Other":
                        lvi.ImageIndex = 3;
                        break;
                }
                
                ContactListView.Items.Add(lvi);
            }
        }

        public void WriteToDatabase(string sqlString, string FirstName, string LastName, string PhoneNumber, string Email, string Relation)
        {
            if (conn.State == ConnectionState.Open) { conn.Close(); }
            Connect(connectionString, dbs);
            try
            {
                using (MySqlCommand comm = new MySqlCommand(sqlString, conn))
                {
                    comm.Parameters.AddWithValue("@FirstName", FirstName);
                    comm.Parameters.AddWithValue("@LastName", LastName);
                    comm.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    comm.Parameters.AddWithValue("@Email", Email);
                    comm.Parameters.AddWithValue("@Relation", Relation);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch { MessageBox.Show("ERROR ADDING CONTACT TO DATABASE!"); }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string FirstName = "", LastName = "", PhoneNumber = "", Email = "", Relation = "", sqlString = "";
            if (ContactListView.SelectedItems.Count >= 0)
            {
                int i = 0;
                i = ContactListView.Items.IndexOf(ContactListView.SelectedItems[0]);
                FirstName = FirstNameTextBox.Text;
                LastName = LastNameTextBox.Text;
                PhoneNumber = PhoneNumberNUP.Value.ToString();
                Email = EmailTextBox.Text;
                Relation = RelationComboBox.Text;
                theData.Rows[i]["FirstName"] = FirstName;
                theData.Rows[i]["LastName"] = LastName;
                theData.Rows[i]["PhoneNumber"] = PhoneNumber;
                theData.Rows[i]["Email"] = Email;
                theData.Rows[i]["Relation"] = Relation;
                sqlString = "update mycontacts set FirstName = '" + FirstName
                    +"', LastName = '" + LastName
                    +"', PhoneNumber = '" + PhoneNumber
                    +"', Email = '" + Email
                    +"', relation = '" + Relation
                    +"' where ID = " + (i + 1) +"";
                WriteToDatabase(sqlString, FirstName, LastName, PhoneNumber, Email, Relation);
                LoadList();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = ContactListView.Items.IndexOf(ContactListView.SelectedItems[0]);
            string sqlString = "DELETE FROM mycontacts WHERE ID = " + (i + 1);
            theData.Rows[i].Delete();
            if (conn.State == ConnectionState.Open) { conn.Close(); }
            Connect(connectionString, dbs);
            try
            {
                using (MySqlCommand comm = new MySqlCommand(sqlString, conn))
                {
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch { MessageBox.Show("ERROR ADDING CONTACT TO DATABASE!"); }
            ResetCount();
            LoadList();
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void ResetCount()
        {
            string sqlString = "ALTER TABLE mycontacts DROP ID";
            string sqlString2 = "ALTER TABLE mycontacts AUTO_INCREMENT = 1";
            string sqlString3 = "alter table mycontacts add id int unsigned not null auto_increment primary key first";

            if (conn.State == ConnectionState.Open) { conn.Close(); }
            Connect(connectionString, dbs);
            try
            {
                using (MySqlCommand comm = new MySqlCommand(sqlString, conn))
                {
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch { MessageBox.Show("ERROR ADDING CONTACT TO DATABASE!"); }


            if (conn.State == ConnectionState.Open) { conn.Close(); }
            Connect(connectionString, dbs);
            try
            {
                using (MySqlCommand comm = new MySqlCommand(sqlString2, conn))
                {
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch { MessageBox.Show("ERROR ADDING CONTACT TO DATABASE!"); }


            if (conn.State == ConnectionState.Open) { conn.Close(); }
            Connect(connectionString, dbs);
            try
            {
                using (MySqlCommand comm = new MySqlCommand(sqlString3, conn))
                {
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch { MessageBox.Show("ERROR ADDING CONTACT TO DATABASE!"); }
        }

        private void exitCtrlQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContactListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactListView.SelectedItems.Count != 0)
            {
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;

                int i = 0;
                i = ContactListView.Items.IndexOf(ContactListView.SelectedItems[0]);
                FirstNameTextBox.Text = theData.Rows[i]["FirstName"].ToString();
                LastNameTextBox.Text = theData.Rows[i]["LastName"].ToString();
                decimal PN = 0;
                decimal.TryParse(theData.Rows[i]["PhoneNumber"].ToString(), out PN);
                PhoneNumberNUP.Value = PN;
                EmailTextBox.Text = theData.Rows[i]["Email"].ToString();
                RelationComboBox.Text = theData.Rows[i]["Relation"].ToString();
            }

            else
            {
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (row + 1 < theData.Select().Length)
            {
                row++;
                FirstNameTextBox.Text = theData.Rows[row]["FirstName"].ToString();
                LastNameTextBox.Text = theData.Rows[row]["LastName"].ToString();
                decimal PN = 0;
                decimal.TryParse(theData.Rows[row]["PhoneNumber"].ToString(), out PN);
                PhoneNumberNUP.Value = PN;
                EmailTextBox.Text = theData.Rows[row]["Email"].ToString();
                RelationComboBox.Text = theData.Rows[row]["Relation"].ToString();
                rowLabel.Text = (row + 1) + " of " + maxCount;
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (row > 0)
            {
                row--;
                FirstNameTextBox.Text = theData.Rows[row]["FirstName"].ToString();
                LastNameTextBox.Text = theData.Rows[row]["LastName"].ToString();
                decimal PN = 0;
                decimal.TryParse(theData.Rows[row]["PhoneNumber"].ToString(), out PN);
                PhoneNumberNUP.Value = PN;
                EmailTextBox.Text = theData.Rows[row]["Email"].ToString();
                RelationComboBox.Text = theData.Rows[row]["Relation"].ToString();
                rowLabel.Text = (row + 1) + " of " + maxCount;
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            bool match = true;
            if (match = FirstNameTextBox.Text.IndexOfAny("0123456789".ToCharArray()) != -1)
            {
                MessageBox.Show("No Numbers allowed!");
                FirstNameTextBox.Text = "John";
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            bool match = true;
            if (match = LastNameTextBox.Text.IndexOfAny("0123456789".ToCharArray()) != -1)
            {
                MessageBox.Show("No Numbers allowed!");
                LastNameTextBox.Text = "Wick";
            }
        }

        private void PhoneNumberNUP_ValueChanged(object sender, EventArgs e)
        {
            if (PhoneNumberNUP.Value < 10000000000 || PhoneNumberNUP.Value > 19999999999)
            {
                MessageBox.Show("Please Enter A Valid Phone Number starting with 1");
                PhoneNumberNUP.Value = 1234678901;
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }

            catch { return false; }
        }

        public bool beforeAdd(string email)
        {
            if (IsValidEmail(email))
            {
                string[] emailSplit = email.Split('@');
                if (emailSplit[1].Contains('.'))
                {
                    string[] domainSplit = emailSplit[1].Split('.');
                    if (domainSplit[1] == "com" || domainSplit[1] == "org" || domainSplit[1] == "net" ||
                        domainSplit[1] == "int" || domainSplit[1] == "edu" || domainSplit[1] == "gov" ||
                        domainSplit[1] == "mil")
                    {
                        return true;
                    }

                    else
                    {
                        MessageBox.Show("Incorrect Email Type");
                        EmailTextBox.Text = "TheBoogieMan@gmail.com";
                        return false;
                    }
                }

                else
                {
                    MessageBox.Show("Incorrect Email Type");
                    EmailTextBox.Text = "TheBoogieMan@gmail.com";
                    return false;
                }
            }

            else
            {
                MessageBox.Show("Incorrect Email Type");
                EmailTextBox.Text = "TheBoogieMan@gmail.com";
                return false;
            }

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextBox.Text.Length > 50)
            {
                MessageBox.Show("Email is to long!");
                EmailTextBox.Text = "TheBoogieMan@gmail.com";
            }
        }

        private void saveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream nStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((nStream = saveFileDialog.OpenFile()) != null)
                {
                    using (StreamWriter output = new StreamWriter(nStream))
                    {
                        for (int i = 0; i < theData.Select().Length; i++)
                        {
                            output.Write((i + 1) + ") " + theData.Rows[i]["FirstName"].ToString() + ", ");
                            output.Write(theData.Rows[i]["LastName"].ToString() + ", ");
                            output.Write(theData.Rows[i]["PhoneNumber"].ToString() + ", ");
                            output.Write(theData.Rows[i]["Email"].ToString() + ", ");
                            output.Write(theData.Rows[i]["Relation"].ToString() + "\n");
                        }
                        output.Close();
                        nStream.Close();
                    }
                }
            }
        }

        void HandleClientWindowSize()
        {
            //Modify ONLY these float values
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE
            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
            //this.Size = new Size(376, 720);
        }
    }
}
