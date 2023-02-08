using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicServiceCNamespace;

namespace ClinicDesctop
{
    public partial class MainForm : Form
    {
        static int vary = 0;
        public MainForm()
        {
            InitializeComponent();
            hideElems(false);
        }

        private void buttonLoadClients_Click(object sender, EventArgs e)
        {
            hideElems(false);
            buttonLoadClients.BackColor = Color.Blue;

            ClinicServiceC clinicServiceClient = new ClinicServiceC("http://localhost:5221/",
                new System.Net.Http.HttpClient());

            ICollection<Client> clients = clinicServiceClient.ClientGetAllAsync().Result;
            listViewClients.Items.Clear();

            foreach(Client client in clients)
            {
                viewList(client);
            }

            buttonLoadClients.BackColor = Color.Transparent;
            
        }

        private void buttonLoadById_Click(object sender, EventArgs e)
        {
            vary = 1;
            hideElems(false);
            textBoxClientId.Visible = true;
            labelClientId.Visible = true;
            buttonClientIdOK.Visible = true;

            listViewClients.Items.Clear();
        }

        private void textBoxClientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClientIdOK_Click(object sender, EventArgs e)
        {
            ClinicServiceC clinicServiceClient = new ClinicServiceC("http://localhost:5221/",
               new System.Net.Http.HttpClient());

            if (vary == 1)
            {
                Client client = clinicServiceClient.ClientGetByIdAsync(Convert.ToInt32(textBoxClientId.Text)).Result;
                viewList(client);

            }
            else if (vary == 2)
            {
                int n = clinicServiceClient.ClientDeleteAsync(Convert.ToInt32(textBoxClientId.Text)).Result;
                ICollection<Client> clients = clinicServiceClient.ClientGetAllAsync().Result;

                foreach (Client client in clients)
                {
                    viewList(client);
                }
            }
            
            if (vary == 3)
            {
                CreateClientRequest req = new CreateClientRequest();
                req.Document = "Паспорт";
                req.SurName = textBoxClientSurName.Text;
                req.FirstName = textBoxClientName.Text;
                req.Patronymic = textBoxClientPatron.Text;
                req.Birthday = dateTimePickerClient.Value;

                int n = clinicServiceClient.ClientCreateAsync(req).Result;
                Client client = new Client();
                client.SurName = textBoxClientSurName.Text;
                client.FirstName = textBoxClientName.Text;
                client.Patronymic = textBoxClientPatron.Text;

                viewList(client);
            }
            if (vary == 4)
            {
                UpdateClientRequest req = new UpdateClientRequest();
                req.ClientId = Convert.ToInt32(textBoxClientId.Text);
                req.Document = "Паспорт";
                req.SurName = textBoxClientSurName.Text;
                req.FirstName = textBoxClientName.Text;
                req.Patronymic = textBoxClientPatron.Text;
                req.Birthday = dateTimePickerClient.Value;

                int n = clinicServiceClient.ClientUpdateAsync(req).Result;
                ICollection<Client> clients = clinicServiceClient.ClientGetAllAsync().Result;
                listViewClients.Items.Clear();
                foreach (Client client in clients)
                {
                    viewList(client);
                }
            }
                
        }
        private void hideElems(bool bl)
        {
            textBoxClientId.Visible = bl;
            textBoxClientSurName.Visible = bl;
            textBoxClientName.Visible = bl;
            textBoxClientPatron.Visible = bl;
            dateTimePickerClient.Visible = bl;

            labelClientId.Visible = bl;
            labelClientSurName.Visible = bl;
            labelClientName.Visible = bl;
            labelClientPatron.Visible = bl;
            labelClientBirth.Visible = bl;

            buttonClientIdOK.Visible = bl;

        }

        

        private void buttonDelClient_Click(object sender, EventArgs e)
        {
            vary = 2;
            hideElems(false);
            textBoxClientId.Visible = true;
            labelClientId.Visible = true;
            buttonClientIdOK.Visible = true;

            listViewClients.Items.Clear();
        }

        private void buttonCreateClient_Click(object sender, EventArgs e)
        {
            vary = 3;
            hideElems(true);
            textBoxClientId.Visible = false;
            labelClientId.Visible = false;

            listViewClients.Items.Clear();
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            vary = 4;
            hideElems(true);

            listViewClients.Items.Clear();
            ClinicServiceC clinicServiceClient = new ClinicServiceC("http://localhost:5221/",
               new System.Net.Http.HttpClient());

            ICollection<Client> clients = clinicServiceClient.ClientGetAllAsync().Result;

            foreach (Client client in clients)
            {
                viewList(client);
            }
        }

        private void buttonLoadPets_Click(object sender, EventArgs e)
        {
            ClinicServiceC clinicServicePet = new ClinicServiceC("http://localhost:5221/",
              new System.Net.Http.HttpClient());

            ICollection<Pet> pets = clinicServicePet.PetGetAllAsync().Result;
            listViewPets.Items.Clear();

            foreach (Pet pet in pets)
            {
                viewList(pet);
            }
        }

        private void viewList(Client client)
        {
            ListViewItem item = new ListViewItem();
            item.Text = client.ClientId.ToString();

            ListViewItem.ListViewSubItem surNameItem = new ListViewItem.ListViewSubItem();
            surNameItem.Text = client.SurName;
            item.SubItems.Add(surNameItem);

            ListViewItem.ListViewSubItem nameItem = new ListViewItem.ListViewSubItem();
            nameItem.Text = client.FirstName;
            item.SubItems.Add(nameItem);

            ListViewItem.ListViewSubItem patronymicItem = new ListViewItem.ListViewSubItem();
            patronymicItem.Text = client.Patronymic;
            item.SubItems.Add(patronymicItem);

            listViewClients.Items.Add(item);
        }

        private void viewList(Pet pet)
        {
            ListViewItem item = new ListViewItem();
            item.Text = pet.PetId.ToString();

            ListViewItem.ListViewSubItem nameItem = new ListViewItem.ListViewSubItem();
            nameItem.Text = pet.Name;
            item.SubItems.Add(nameItem);

            ListViewItem.ListViewSubItem birthItem = new ListViewItem.ListViewSubItem();
            birthItem.Text = pet.Birthday.ToString();
            item.SubItems.Add(birthItem);

            listViewPets.Items.Add(item);
        }
    }
}
