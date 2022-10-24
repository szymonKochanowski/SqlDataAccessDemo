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

        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = personList;
            peopleFoundListBox.DisplayMember = "fullInfo";
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            DatabaseAccess databaseAccess = new DatabaseAccess();
            personList = databaseAccess.GetPersonListByLastName(LastNameTextBox.Text);
            UpdateBinding();
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

        //todo - add query to upadate and delete and maybe somethig more
    }
}