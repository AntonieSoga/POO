using DocumentFormat.OpenXml.Spreadsheet;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using ProiectPAOO.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static ProiectPAOO.Data.SqlToExcel;
using static ProiectPAOO.Data.ExcelToMySql;
using static ProiectPAOO.Data.ExcelFileSelector;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;


namespace ProiectPAOO
{
    
    public partial class Form1 : Form
    {
        Data.Connection con = new Data.Connection();
        
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            //CreateAccount panel
            createAccountPanel.Location = new Point((this.Width - createAccountPanel.Width) / 2, (this.Height - createAccountPanel.Height) / 2);
            AddPlaceholderToTextBox(this.lastnameCreate, "Last Name");
            AddPlaceholderToTextBox(this.firstnameCreate, "First Name");
            AddPlaceholderToTextBox(this.passwordCreate, "*****");
            AddPlaceholderToTextBox(this.emailCreate, "Email");
            AddPlaceholderToTextBox(this.managerCode, "Manager Code");
            AddPlaceholderToTextBox(this.employeeCode, "Employee Code");
            //Login panel
            AddPlaceholderToTextBox(this.usernameLogin, "Email");
            AddPlaceholderToTextBox(this.passwordLogin, "*****");
            loginPanel.Location = new Point((this.Width - loginPanel.Width) / 2, (this.Height - loginPanel.Height) / 2);

            //DB
            LOGS.Visible = false;
            try
            {
                Data.Connection.dataSource();
                con.connOpen();
            }
            catch (Exception)
            {
                con.connClose();
            }

            //tableShow(dataGridView2, "nume,prenume,brand,model,pret,sex,culoare,datetime", "comenzi, clienti, produse where clienti.idClienti=comenzi.idClienti and produse.idProduse=comenzi.idProduse");
            dataGridView2.DataSource = tableShow( "nume,prenume,brand,model,pret,sex,culoare,datetime", "comenzi, clienti, produse where clienti.idClienti=comenzi.idClienti and produse.idProduse=comenzi.idProduse");
            
            GenerateChart("select distinct(brand),pret from produse","brand","pret", chart1);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createLogin_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            createAccountPanel.Visible = true;
        }

        private void cancelCreate_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            createAccountPanel.Visible = false;
            AddPlaceholderToTextBox(this.lastnameCreate, "Last Name");
            AddPlaceholderToTextBox(this.firstnameCreate, "First Name");
            AddPlaceholderToTextBox(this.passwordCreate, "*****");
            AddPlaceholderToTextBox(this.emailCreate, "Email");
            AddPlaceholderToTextBox(this.managerCode, "Manager Code");
            AddPlaceholderToTextBox(this.employeeCode, "Employee Code");

        }

        private Boolean validateCreate(string table, Boolean emp) 
        {
            string query;

            if (emp)
            {
                query = "SELECT email,cod_angajat FROM " + table;
            }
            else
            {
                query = "SELECT email FROM " + table;
            }    
            string[,] output = new string[0, 0];
            try
            {
                output = con.ExecuteAndPrintQuery(query);
            }
            catch (Exception)
            {
                con.connClose();
            }

            if (output != null)
            {
                for (int i = 0; i < output.GetLength(0); i++)
                {
                    for (int j = 0; j < output.GetLength(1); j++)
                    {
                        if (j == 0)
                        {
                            if (output[i, j].ToString() == emailCreate.Text)
                            {
                                return false;

                            }
                        }
                        else if (j == 1)
                        {
                            if (output[i, j].ToString() == employeeCode.Text)
                            {
                                return false;

                            }
                        }                     
                    }
                }
            }
            return true;
        }

        private void createCreate_Click(object sender, EventArgs e)
        {
            //TO-DO
            //validation
            //if(not valid)
            //
            //else
            if(accountTypeCreate.SelectedIndex == -1)
            {
                ShowPopup("please select account type");
            }

            string table = accountTypeCreate.Text;
            Boolean emp = (table == "angajati") ? true : false;
            if (validateCreate(table,emp))
            {
                if(accountTypeCreate.SelectedIndex == 0)
                if (firstnameCreate.Text != "First Name" && lastnameCreate.Text != "Last Name" && passwordCreate.Text != "*****" && emailCreate.Text != "Email")
                {

                        try
                        {


                                con.connOpen();
                                string query = $"INSERT INTO CLIENTI (nume, prenume, email, password) VALUES ('{firstnameCreate.Text}', '{lastnameCreate.Text}','{emailCreate.Text}', '{passwordCreate.Text}')";
                                con.ExecuteNonQuery(query);


                        }
                        catch (Exception ex)
                        {
                            con.connClose();
                            Console.WriteLine("Error: " + ex.Message);
                        }

                        loginPanel.Visible = true;
                        createAccountPanel.Visible = false;
                        ShowPopup("succes!");

                    }
                    else 
                    {
                        ShowPopup("fill all the blanks correctly!");
                    }
            }

           
        }

        private void ShowPopup(string message)
        {
            Form popup = new Form();
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.CenterScreen;
           // popup.TopMost = true;
            popup.MaximumSize = new Size(200, 60);
            //popup.Location = new Point((mainPanel.Width - mainPanel.Width) / 2, (popup.Height - popup.Height) / 2);
            // Add a text box to the popup window
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.ReadOnly = true;
            textBox.Enabled = false;
            textBox.Size = new Size(200, 30); 
         
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = popup.BackColor;
            textBox.Text = message;
            textBox.Dock = DockStyle.Top;
            popup.Controls.Add(textBox);

            // Add a close button to the popup window
            Button closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Dock = DockStyle.Bottom;
            closeButton.Click += (sender, args) => popup.Close();
            popup.Controls.Add(closeButton);

            // Set the size of the popup window to fit its contents
            popup.AutoSize = true;

            popup.ShowDialog();
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private Boolean validateLogin(string table) {
            string query = "SELECT email,password FROM " + table;
            string[,] output = new string[0, 0];
            try
            {
                output = con.ExecuteAndPrintQuery(query);
            }
            catch (Exception)
            {
                con.connClose();
            }

            int ok = 0;
            if (output != null)
            {
                for (int i = 0; i < output.GetLength(0); i++)
                {
                    for (int j = 0; j < output.GetLength(1); j++)
                    {
                        if (j == 0)
                        {
                            if (output[i, j].ToString() == usernameLogin.Text)
                            {
                                 ok = 1;

                            }
                        }
                        else
                        {
                            if (output[i, j].ToString() == passwordLogin.Text && ok ==1)
                            {
                                return true;

                            }
                            else
                            {
                                ok = 0; break;
                            }
                        }
                    }
                    
                }
            }
            ShowPopup("bad login!!!!!!");
            return false;
        }
        string customer= "1";
        private void login_Click(object sender, EventArgs e)
        {

           
          
            int ok = 0;
            if(accountTypeLogin.SelectedIndex == -1)
            {
                ShowPopup("plase select the desired account type");
            }

            if (passwordLogin.Text != "*****" && usernameLogin.Text != "Username")
            {                             
                if (accountTypeLogin.SelectedIndex == 0 && validateLogin("clienti"))
                {
                    hidePanel.Visible = true;
                    loginPanel.Visible = false;
                    mainPanel.Visible = true;
                    ok = 1;

                    aux = con.ExecuteAndPrintQuery($"select idClienti from clienti where email='{usernameLogin.Text}'");
                    customer = aux[0, 0].ToString();
                }
                if (accountTypeLogin.SelectedIndex == 2 && validateLogin("manageri"))
                {
                    hidePanel.Visible = false;
                    employeeHidden1.Visible = true;
                    loginPanel.Visible = false;
                    mainPanel.Visible = true;
                    ok = 1;
                }
                if (accountTypeLogin.SelectedIndex == 1 && validateLogin("angajati"))
                {
                    hidePanel.Visible = false;
                    employeeHidden1.Visible = false;
                    loginPanel.Visible = false;
                    mainPanel.Visible = true;
                    ok = 1;
                }
               
            }
            else {
                ShowPopup("invalid username/password");
            }

           

          /*  hidePanel.Visible = false;
            employeeHidden1.Visible = false;
            employeeHidden2.Visible = false;
            loginPanel.Visible = false;
            mainPanel.Visible = true;
            int ok=1;*/
            if (ok == 1)
            {
                dataGridView1.DataSource = tableShow( "brand,model,pret,sex,culoare","produse");
                SetComboBox();
            }
        }

        private DataTable tableShow( string columns,string table)
        {
            // create a new DataTable to hold the data
            DataTable dataTable = new DataTable();

            // execute the select query and fill the DataTable with the results
            using (MySqlConnection conn = new MySqlConnection(con.conString()))
            {
                conn.Open();

                string query = "SELECT " + columns +  " FROM " + table;
                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            // bind the DataTable to the DataGridView
            //dataGridView.DataSource = dataTable;
            return dataTable;
           

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            trackBarMax.Value = 2000;
            trackBarMin.Value = 0;
            comboBox1.SelectedIndex = 0;
            comboBoxColor.SelectedIndex = 0;
            comboBoxSex.SelectedIndex = 0;
            comboBoxBrand.SelectedIndex = 0;
            dataGridView1.DataSource=tableShow("brand,model,pret,sex,culoare", "produse");
            SetComboBox();

            logging("filter reset " + usernameLogin.Text);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int tableIndex = comboBox6.SelectedIndex;
            string table="";
            int operation = comboBox7.SelectedIndex;

            if (tableIndex == 0)
                table = "angajati";
            else if (tableIndex == 1)
                table = "clienti";
            else if (tableIndex == 2)
                table = "comenzi";
            else if (tableIndex == 3)
                table = "manageri";
            else if (tableIndex == 4)
                table = "produse";
            else if (tableIndex == -1)            
                ShowPopup("select the table!!");
            

            DataTable dataTable = new DataTable();

            if(operation==0)
            {
                //export
                SqlToExcel q2e = new SqlToExcel();
                string filePath = "";
                dataTable = tableShow("*",table);
                ExcelFileSelector efs = new ExcelFileSelector();
                filePath = efs.SelectExcelFile();
                if (!string.IsNullOrEmpty(filePath))
                { 
                    q2e.ExportToExcel(dataTable, filePath);
                    ShowPopup("Imported succesfully");
                    logging("exported to excel " + usernameLogin.Text);
                }
                else
                    ShowPopup("file not found");
            }
            else if(operation == 1)
            {
                //import
                //import
                /* string conectionString = "";
                 MySqlConnection connection = new MySqlConnection(con.conString());*/
                ExcelToMySql e2q = new ExcelToMySql();
                ExcelFileSelector efs = new ExcelFileSelector();
                string filePath = efs.SelectExcelFile();
                if (!string.IsNullOrEmpty(filePath))
                { 
                    e2q.ImportData(filePath, con.conString(), table);
                    ShowPopup("Imported succesfully");
                    logging("imported from excel " + usernameLogin.Text);
                }
            else
                    ShowPopup("file not found");
            }
            else if (operation == -1)   
                ShowPopup("select the operation!!");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tabControl.TabPages.Add(tabPageManager);
            logging("log in "+ usernameLogin.Text);
            mainPanel.Visible = false;
            loginPanel.Visible = true;

        }

    private void logging(string text)
        {
            log.Text += text + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n"; 
           
        }

    private void accountTypeCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(accountTypeCreate.SelectedIndex == 0)
            {
                managerCode.Enabled = false;
                employeeCode.Enabled = false;
            }
            else
            {
                managerCode.Enabled = true;
                employeeCode.Enabled = true;
            }
        }

        private void SetComboBox()
        {
            // Get the unique colors from the "culoare" column of the DataGridView
            var colors = new List<string> { "Color" };
            colors.AddRange(dataGridView1.Rows.Cast<DataGridViewRow>()
                           .Select(r => r.Cells["culoare"]?.Value?.ToString())
                           .Where(c => !string.IsNullOrEmpty(c))
                           .Distinct()
                           .ToList());

            var sex = new List<string> { "Sex" };
            sex.AddRange(dataGridView1.Rows.Cast<DataGridViewRow>()
                           .Select(r => r.Cells["sex"]?.Value?.ToString())
                           .Where(c => !string.IsNullOrEmpty(c))
                           .Distinct()
                           .ToList());

            var brand = new List<string> { "Brand" };
            brand.AddRange(dataGridView1.Rows.Cast<DataGridViewRow>()
                           .Select(r => r.Cells["brand"]?.Value?.ToString())
                           .Where(c => !string.IsNullOrEmpty(c))
                           .Distinct()
                           .ToList());

            // Add the colors to the ComboBox

            comboBoxColor.DataSource = colors;
            comboBoxSex.DataSource = sex;
            comboBoxBrand.DataSource = brand;
        }


        private void findBtn_Click(object sender, EventArgs e)
        {
            string searchString = findTextBox.Text.Trim(); // get the search string from a TextBox
            
            // loop through the DataGridView rows and search for the string in each cell
            dataGridView1.CurrentCell = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchString))
                        {
                            row.Visible = true;
                            break;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
            SetComboBox();
            logging("used [find]  " + usernameLogin.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the current column being sorted (if any)
            DataGridViewColumn column = dataGridView1.SortedColumn;

            // Set the SortMode property of the column to Programmatic
            if (column != null)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            // Determine the sort order based on the ComboBox's SelectedIndex
            ListSortDirection sortOrder = comboBox1.SelectedIndex == 0 ?
                ListSortDirection.Ascending : ListSortDirection.Descending;

            // Sort the data in the DataGridView
            dataGridView1.Sort(dataGridView1.Columns["Pret"], sortOrder);

            // Set the SortMode property of the sorted column back to Automatic
            if (column != null)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            logging("filtered " + usernameLogin.Text);

        }

        private void filter()
        {
  
               
            string color="", sex="", brand="";
            if(comboBoxColor.SelectedIndex != 0)
                color = comboBoxColor.SelectedItem.ToString();
            if (comboBoxSex.SelectedIndex != 0)
                sex = comboBoxSex.SelectedItem.ToString();
            if (comboBoxBrand.SelectedIndex != 0)
                brand = comboBoxBrand.SelectedItem.ToString();

            ApplyFilters(color,sex,brand);
            
        }
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();

        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void ApplyFilters(string selectedColor,string selectedSex, string selectedBrand)
        {
            // Get the selected values from all three ComboBoxes
           
            // Build the filter expression based on the selected values
            string filterExpression = "";
            if (!string.IsNullOrEmpty(selectedColor))
            {
                filterExpression += $"culoare = '{selectedColor}'";
            }
            else
            {
                filterExpression += "culoare like '%'";
            }
            if (!string.IsNullOrEmpty(selectedSex))
            {
               
                filterExpression += " AND ";
                filterExpression += $"sex = '{selectedSex}'";
            }
            else
            {
                filterExpression += " AND ";
                filterExpression += "sex like '%'";
            }
            if (!string.IsNullOrEmpty(selectedBrand))
            {
                filterExpression += " AND ";
                filterExpression += $"brand = '{selectedBrand}'";
            }
            else
            {
                filterExpression += " AND ";
                filterExpression += "brand like '%'";
            }

            // Apply the filter expression to the DefaultView of the DataGridView's DataSource
            if (dataGridView1.DataSource != null)
            {
                int maxi = trackBarMax.Value;
                int mini = trackBarMin.Value;
                if (maxi < mini)
                {
                    int aux = mini;
                    mini = maxi;
                    maxi = aux;
                }

                priceLabel.Text = mini.ToString() + " - " + maxi.ToString();
                filterExpression = filterExpression + "AND pret > " + mini.ToString()+ " and pret < " + maxi.ToString();
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
            }
            logging("filtered " + usernameLogin.Text);
        }

       

  

        private void trackBarMin_Scroll(object sender, EventArgs e)
        {
            
            filter();

        }

        private void trackBarMax_Scroll(object sender, EventArgs e)
        {
            filter();
        }

        
        string[] cart= new string[0];
        string[,] aux = new string[0, 0];
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the button column was clicked
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.RowIndex<dataGridView1.Rows.Count-1) // Ensure that a valid row was clicked
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Get the cell value of the button column for the selected row
                string brand = selectedRow.Cells["brand"].Value.ToString();
                string model = selectedRow.Cells["model"].Value.ToString();
                string color = selectedRow.Cells["culoare"].Value.ToString();
                string sex = selectedRow.Cells["sex"].Value.ToString();

                // Do something with the cell value...
                ShowPopup(brand + "   " + model + "   " + sex + "   " +color+"\n a fost daugat in cos!");
                logging(brand + "   " + model + "   " + sex + "   " + color + "\n a fost daugat in cos!   " + usernameLogin.Text);

                aux =con.ExecuteAndPrintQuery($"select idProduse from produse where model='{model}' and brand='{brand}' and sex='{sex}' and culoare='{color}'");
                //cart = cart+ aux[0,0].ToString() + ",";
                int cartLength = cart.Length; // get the current length of the array
                Array.Resize(ref cart, cartLength + 1); // increase the size of the array by 1
                cart[cartLength] = aux[0,0];

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (cart.Length > 0)
            {
                
                for(int i=0;i< cart.Length;i++)
                    con.ExecuteNonQuery($"insert into comenzi(idProduse,idCLienti) VALUES ({cart[i]},{customer})");
               
                ShowPopup("purchased successfully!");
               
            }
            else {
                ShowPopup("The Cart is EMPTY!");
            }
            cart = new string[0];
            //button3.PerformClick();
            logging("purchased " + usernameLogin.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cart = new string[0];
            ShowPopup("The Cart is now EMPTY!");
            logging("empty cart " + usernameLogin.Text);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if(comboBox8.SelectedIndex == -1)
            {
                ShowPopup("Select the table you want to add info into");
            }
            else if(comboBox8.SelectedIndex == 0)
            {
                AddPlaceholderToTextBox(textBoxAdd1, "Last Name"); textBoxAdd1.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd2, "First Name"); textBoxAdd2.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd3, "Email"); textBoxAdd3.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd4, "Password"); textBoxAdd4.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd5, "CODE"); textBoxAdd5.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd6, "Manager"); textBoxAdd6.Enabled = true;

            }
            else if(comboBox8.SelectedIndex == 1)
            {
                AddPlaceholderToTextBox(textBoxAdd1, "Last Name"); textBoxAdd1.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd2, "First Name"); textBoxAdd2.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd3, "Email"); textBoxAdd3.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd4, "Password"); textBoxAdd4.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd5, ""); textBoxAdd5.Enabled = false;
                AddPlaceholderToTextBox(textBoxAdd6, ""); textBoxAdd6.Enabled = false;

            }
            else if (comboBox8.SelectedIndex == 2)
            {
                AddPlaceholderToTextBox(textBoxAdd1, "Brand"); textBoxAdd1.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd2, "Model"); textBoxAdd2.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd3, "Price"); textBoxAdd3.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd4, "Sex"); textBoxAdd4.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd5, "Color"); textBoxAdd5.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd6, ""); textBoxAdd6.Enabled = false;

            }
            else if (comboBox8.SelectedIndex == 3)
            {
                AddPlaceholderToTextBox(textBoxAdd1, "Last Name"); textBoxAdd1.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd2, "First Name"); textBoxAdd2.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd3, "Email"); textBoxAdd3.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd4, "Password"); textBoxAdd4.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd5, ""); textBoxAdd5.Enabled = false;
                AddPlaceholderToTextBox(textBoxAdd6, ""); textBoxAdd6.Enabled = false;

            }
            else if (comboBox8.SelectedIndex == 4)
            {
                AddPlaceholderToTextBox(textBoxAdd1, "Product ID"); textBoxAdd1.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd2, "Customer ID"); textBoxAdd2.Enabled = true;
                AddPlaceholderToTextBox(textBoxAdd3, ""); textBoxAdd3.Enabled = false;
                AddPlaceholderToTextBox(textBoxAdd4, ""); textBoxAdd4.Enabled = false;
                AddPlaceholderToTextBox(textBoxAdd5, ""); textBoxAdd5.Enabled = false;
                AddPlaceholderToTextBox(textBoxAdd6, ""); textBoxAdd6.Enabled = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(comboBox8.SelectedIndex == -1)
                add.Enabled = false;
            else if(comboBox8.SelectedIndex == 0)
            {
                con.ExecuteNonQuery($"insert into angajati(nume,prenume,email,password,cod_angajat,manager) VALUES('{textBoxAdd1.Text}','{textBoxAdd2.Text}','{textBoxAdd3.Text}','{textBoxAdd4.Text}','{textBoxAdd5.Text}','{textBoxAdd6.Text}')");
            }
            else if (comboBox8.SelectedIndex == 1)
            {
                con.ExecuteNonQuery($"insert into manageri(nume,prenume,email,password) VALUES('{textBoxAdd1.Text}','{textBoxAdd2.Text}','{textBoxAdd3.Text}','{textBoxAdd4.Text}')");
            }
            else if (comboBox8.SelectedIndex == 2)
            {
                con.ExecuteNonQuery($"insert into produse(brand,model,pret,sex,culoare) VALUES('{textBoxAdd1.Text}','{textBoxAdd2.Text}','{textBoxAdd3.Text}','{textBoxAdd4.Text}','{textBoxAdd5.Text}')");
            }
            else if (comboBox8.SelectedIndex == 3)
            {
                con.ExecuteNonQuery($"insert into clienti(nume,prenume,email,password) VALUES('{textBoxAdd1.Text}','{textBoxAdd2.Text}','{textBoxAdd3.Text}','{textBoxAdd4.Text}')");
            }
            else if (comboBox8.SelectedIndex == 4)
            {
                con.ExecuteNonQuery($"insert into comenzi(idProduse,idClienti) VALUES('{textBoxAdd1.Text}','{textBoxAdd2.Text}')");
            }
            logging("inserted row " + usernameLogin.Text + " into " + (comboBox8.SelectedIndex.ToString()));
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == -1)
            {
                ShowPopup("Select the table you want to remove info from");
            }
            else if (comboBox9.SelectedIndex == 0)
            {
                AddPlaceholderToTextBox(textBoxRemove1, "email"); textBoxRemove1.Enabled = true;
                AddPlaceholderToTextBox(textBoxRemove2, ""); textBoxRemove2.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove3, ""); textBoxRemove3.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove4, ""); textBoxRemove4.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove5, ""); textBoxRemove5.Enabled = false;

            }
            else if (comboBox9.SelectedIndex == 1)
            {
                AddPlaceholderToTextBox(textBoxRemove1, "email"); textBoxRemove1.Enabled = true;
                AddPlaceholderToTextBox(textBoxRemove2, ""); textBoxRemove2.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove3, ""); textBoxRemove3.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove4, ""); textBoxRemove4.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove5, ""); textBoxRemove5.Enabled = false;
                

            }
            else if (comboBox9.SelectedIndex == 2)
            {
                AddPlaceholderToTextBox(textBoxRemove1, "Brand"); textBoxRemove1.Enabled = true;
                AddPlaceholderToTextBox(textBoxRemove2, "Model"); textBoxRemove2.Enabled = true;
                AddPlaceholderToTextBox(textBoxRemove3, "Sex"); textBoxRemove3.Enabled = true;
                AddPlaceholderToTextBox(textBoxRemove4, "Color"); textBoxRemove4.Enabled = true;
                AddPlaceholderToTextBox(textBoxRemove5, ""); textBoxRemove5.Enabled = false;

            }
            else if (comboBox9.SelectedIndex == 3)
            {
                AddPlaceholderToTextBox(textBoxRemove1, "email"); textBoxRemove1.Enabled = true;
                AddPlaceholderToTextBox(textBoxRemove2, ""); textBoxRemove2.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove3, ""); textBoxRemove3.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove4, ""); textBoxRemove4.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove5, ""); textBoxRemove5.Enabled = false;

            }
            else if (comboBox9.SelectedIndex == 4)
            {
                AddPlaceholderToTextBox(textBoxRemove1, "Product ID"); textBoxRemove1.Enabled = true;
                AddPlaceholderToTextBox(textBoxRemove2, "Customer ID"); textBoxRemove2.Enabled = true;
                AddPlaceholderToTextBox(textBoxRemove3, ""); textBoxRemove3.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove4, ""); textBoxRemove4.Enabled = false;
                AddPlaceholderToTextBox(textBoxRemove5, ""); textBoxRemove5.Enabled = false;
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == -1)
            {
                ShowPopup("Select the table you want to remove info from");
            }
            else if (comboBox9.SelectedIndex == 0)
            {
                con.ExecuteNonQuery($"delete from angajati where email='{textBoxRemove1.Text}'");
            }
            else if (comboBox9.SelectedIndex == 1)
            {
                con.ExecuteNonQuery($"delete from manageri where email='{textBoxRemove1.Text}'");
            }
            else if (comboBox9.SelectedIndex == 2)
            {
                con.ExecuteNonQuery($"delete from produse where brand='{textBoxRemove1.Text}' and model ='{textBoxRemove2.Text}' and sex ='{textBoxRemove3.Text}' and culoare='{textBoxRemove4.Text}'");
            }
            else if (comboBox9.SelectedIndex == 3)
            {
                con.ExecuteNonQuery($"delete from clienti where email='{textBoxRemove1.Text}'");
            }
            else if (comboBox9.SelectedIndex == 4)
            {
                con.ExecuteNonQuery($"delete from comenzi where idProduse='{textBoxRemove1.Text}' and idClienti='{textBoxRemove2.Text}'");
            }
            logging("removed " + usernameLogin.Text + " from " + comboBox9.SelectedIndex.ToString());
        }

        public void GenerateChart(string query, string xColumn, string yColumn, Chart chart)
        {
            // Clear any existing data from the chart
            chart.Series.Clear();

            // Create a new series for the chart
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;

            // Connect to the database and execute the query
            MySqlConnection connection = new MySqlConnection(con.conString());
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();

            // Add data to the chart series
            foreach (DataRow row in data.Rows)
            {
                string xValue = row[xColumn].ToString();
                double yValue = double.Parse(row[yColumn].ToString());
                series.Points.AddXY(xValue, yValue);
            }

            // Add the series to the chart and set the chart title
            chart.Series.Add(series);
            chart.Titles.Clear();
            chart.Titles.Add("Price gap between brands");

            // Refresh the chart
            chart.Invalidate();
        }

        private void btnLOG_Click(object sender, EventArgs e)
        {
            if(LOGS.Visible==true)
            {
                LOGS.Visible = false;
            }
            else
            {
                LOGS.Visible = true;
            }
        }

        private void printPDF_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            int tableIndex = comboBox6.SelectedIndex;
            string table = "";

            if (tableIndex == 0)
                table = "angajati";
            else if (tableIndex == 1)
                table = "clienti";
            else if (tableIndex == 2)
                table = "comenzi";
            else if (tableIndex == 3)
                table = "manageri";
            else if (tableIndex == 4)
                table = "produse";
            else if (tableIndex == -1)
                ShowPopup("select the table!!");

            if (!string.IsNullOrEmpty(table))
            {
                dataTable = tableShow("*", table);
                // File path
                string pdfPath1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test.pdf");

                // Create a new PDF document
                Document document = new Document();

                // Create a new PDF writer
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfPath1, FileMode.Create));

                // Open the PDF document
                document.Open();

                // Add a new paragraph to the document
                document.Add(new Paragraph("Table:"+table));

                // Close the PDF document
                document.Close();

                // Close the PDF writer
                writer.Close();

                DataTableToPdf dataTableToPdf = new DataTableToPdf();

                // Create a SaveFileDialog and set its filters to accept .pdf files
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = true;

                // Show the SaveFileDialog and check if the user clicked OK
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path from the SaveFileDialog
                    string pdfPath = saveFileDialog.FileName;

                    // Export the DataTable to the selected PDF file
                    dataTableToPdf.Export(dataTable, pdfPath);
                    logging("printed to PDF " + usernameLogin.Text);
                }
            }

        }
    }

}
