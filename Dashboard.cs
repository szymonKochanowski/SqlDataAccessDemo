using SqlDataAccessDemo.Models;
using SqlDataAccessDemo;


namespace SqlDataAccessDemo
{
    public partial class Dashboard : Form
    {
        List<Person> personList = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }


        public void searchButton_Click(object sender, EventArgs e)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            personList = databaseAccess.GetPersonListByLastName(LastNameTextBox.Text);
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = personList;
            peopleFoundListBox.DisplayMember = "fullInfo";
        }
        
        private void insertButton_Click(object sender, EventArgs e)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            databaseAccess.InsertPerson(firstNameInsertTextBox.Text, lastNameInsertTexBox.Text, emailInsertTextBox.Text, genderInsertTextBox.Text);

            firstNameInsertTextBox.Text = "";
            lastNameInsertTexBox.Text = "";
            emailInsertTextBox.Text = "";
            genderInsertTextBox.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            databaseAccess.DeletePersonById(IdTextBox.Text);
            IdTextBox.Text = "";
            UpdateBinding();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            databaseAccess.UpdatePersonByEmail(firstNameInsertTextBox.Text, lastNameInsertTexBox.Text, emailInsertTextBox.Text, genderInsertTextBox.Text);

            firstNameInsertTextBox.Text = "";
            lastNameInsertTexBox.Text = "";
            emailInsertTextBox.Text = "";
            genderInsertTextBox.Text = "";
        }

    }
}