using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slutprov
{
    public partial class CompanyRegistry : Form
    {
        private List<Företag> företag = new List<Företag>();

        public CompanyRegistry ()
        {
            InitializeComponent();
        }

        private void UpdateWindow()
        {
            lbxCompanies.Items.Clear(); //Rensa allt innehåll i listboxen

            int minNumEmployees = 0;
            int.TryParse(tbxFilterNum.Text, out minNumEmployees);
            
            if (!cbxFilterNum.Checked)
            {
                minNumEmployees = 0; //Om rutan inte är ikryssad, visa alla företag (eftersom företag inte kan ha negativt antal anställda så har alla företag fler än eller lika med noll anställda och då visas alla företag då minsta antal anställda sätts till 0)
            }

            if (minNumEmployees < 0) //Antal anställda kan ej vara mindre än 0.
            {
                minNumEmployees = 0;
            }

            try
            {
                for (int i = 0; i < företag.Count; i++)
                {
                    if (företag[i].AntalAnställda >= minNumEmployees) //Visa bara de företag som har fler än eller lika många anställda som minimialet som specifierat i filtret.
                    {
                        lbxCompanies.Items.Add(företag[i].Namn + " (" + företag[i].AntalAnställda + ")");
                    }
                }
            }
            catch
            {
               MessageBox.Show(this, "Något gick fel! Försök igen!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error); //Visa felmeddelande om något gick fel när listboxen fylldes i.
               Console.WriteLine("Something went wrong whilst populating the listbox.");
            }
        }

        private void btnRegister_Click (object sender, EventArgs e)
        {
            int numEmployees = 0; //Om företagsnamnet inte är tomt och antalet anställda faktiskt är en siffra så ska företaget läggas till i listan.
            
            if (!String.IsNullOrEmpty(tbxRegName.Text) && int.TryParse(tbxRegNum.Text, out numEmployees))
            {
                if (numEmployees < 0) //Företag kan inte ha ett negativt antal anställda, om det har det ska det ha 0 istället.
                {
                    numEmployees = 0;
                }

                Företag newCompany = new Företag(tbxRegName.Text, numEmployees); //Skapa nytt företag och lägg till det i listan
                företag.Add(newCompany);

                UpdateWindow(); //Uppdatera listboxens innehåll
            }
        }

        private void btnRemove_Click (object sender, EventArgs e)
        {
            try
            {
                int index = lbxCompanies.SelectedIndex; //Ta texten från listboxen, ta bort antal anställda och hitta företaget med namnet som blir kvar. Ta sedan bort det.
                string dataLine = lbxCompanies.Items[index].ToString();

                int trimIndex = dataLine.LastIndexOf('(') - 1; // Hitta index i strängen för mellanslaget innan parantesen som innehåller antalet anställda.
                string companyName = dataLine.Remove(trimIndex); //Ta bort allt efter, och inklusive det indexet

                for (int i = 0; i < företag.Count; i++)
                {
                    if (företag[i].Namn == companyName)
                    {
                        företag.RemoveAt(i); //Ta bort företaget vars namn matchar det valda i listan.
                    }
                }

                UpdateWindow(); //Uppdatera listboxen så att användaren kan se att företaget blivit borttaget
            }
            catch
            {
                MessageBox.Show(this, "Företaget kunde inte hittas. Kontrollera att du har valt ett företag i listan eller kontakta din systemadministratör för mer hjälp.", "Företaget kunde inte hittas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbxFilterNum_CheckedChanged (object sender, EventArgs e) //Om kryssrutan blivit ikryssad eller urkryssad måste listboxen uppdateras, annars finns risken att den visar utvalda företag eller alla när det ska vara tvärt om.
        {
            UpdateWindow();
        }

        private void tbxFilterNum_TextChanged (object sender, EventArgs e) //Om antalet anställda som företagen ska filtreras på förändras så måste listboxen uppdateras, annars måste användaren klicka i och ur kryssrutan för att något ska hända.
        {
            UpdateWindow();
        }
    }
}
