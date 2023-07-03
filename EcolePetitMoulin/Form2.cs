using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace EcolePetitMoulin
{
    public partial class Form2 : Form
    {
        ErrorProvider err1 = new ErrorProvider();
        // Form1 myForm1 = new Form1();
        public const int Longueur = 209;
        public int nombreDeleve;
        public List<string> dataList = new List<string>();
        public ListView listViewBox = new ListView();

        public List<decimal> listeNoteTp1 = new List<decimal>();
        public List<decimal> listeNoteIntra = new List<decimal>();
        public List<decimal> listeNoteTp2 = new List<decimal>();
        public List<decimal> listeNoteFinal = new List<decimal>();

        public Form2()
        {
            InitializeComponent();
        }

        private void lbValeurTp1_Click(object sender, EventArgs e)
        {

        }

        public void Form2_Load(object sender, EventArgs e)
        {   // tout ca ici pour avoir notre nombre deleve inscrit
            Form1 myForm1 = new Form1();
            try
            {
                FileStream fs = new FileStream(myForm1.NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                // Ici on détermine le nombre de membres dans le fichier delon la longueur du fichier / par la longueur d'un eleve
                nombreDeleve = (int)fs.Length / Longueur;   // il interfere avec la variable du form 1 ,...risquer
                // on ferme le filestream
                fs.Close();
                lbNbrEleve.Text = nombreDeleve.ToString();


                if (nombreDeleve > 0) 
                {
                    // Récupérer le 1er membre du fichier
                    myForm1.pos = 0;
                    RecupererEleveBin(myForm1.pos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        public void RecupererEleveBin(int p)
        {
            Form1 myForm1 = new Form1();
            try
            {
                using (FileStream fs = new FileStream(myForm1.NomFichier, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        fs.Seek(p * Longueur, SeekOrigin.Begin);


                        for (int i = 0; i < nombreDeleve; i++)
                        {
                            // 5) Lire les infos du membre dans membres.bin et les mettre dans des variables
                            int noIndex = br.ReadInt32();
                            string tel = br.ReadString();
                            string prenom = br.ReadString();
                            string nom = br.ReadString();
                            char sexe = br.ReadChar();
                            string date = br.ReadString();
                            string numeroCivique = br.ReadString();
                            string rue = br.ReadString();
                            string ville = br.ReadString();
                            string codePostal = br.ReadString();
                            string codePermanent = br.ReadString();
                            decimal tp1 = br.ReadDecimal();
                            decimal intra = br.ReadDecimal();
                            decimal tp2 = br.ReadDecimal();
                            decimal final = br.ReadDecimal();
                            string noID = br.ReadString();

                            ListViewItem item1;  // Ici on rempli le listeView
                            item1 = listView1.Items.Add(noID); /// nombre membre
                            item1.SubItems.Add(nom);
                            item1.SubItems.Add(prenom);
                            item1.SubItems.Add(codePermanent);
                            item1.SubItems.Add(tel.ToString());
                            item1.SubItems.Add(sexe.ToString());
                            item1.SubItems.Add(date);
                            item1.SubItems.Add(numeroCivique);
                            item1.SubItems.Add(rue);
                            item1.SubItems.Add(ville);
                            item1.SubItems.Add(codePostal);
                            item1.SubItems.Add(tp1.ToString());
                            item1.SubItems.Add(intra.ToString());
                            item1.SubItems.Add(tp2.ToString());
                            item1.SubItems.Add(final.ToString());
                            

                            listeNoteTp1.Add(tp1);
                            listeNoteIntra.Add(intra);
                            listeNoteTp2.Add(tp2);
                            listeNoteFinal.Add(final);

                            //Calcul des moyennes
                            Calcul();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calcul()
        {
            decimal noteTotaltp1 = listeNoteTp1.Sum();
            decimal noteIntraTotal = listeNoteIntra.Sum();
            decimal noteTotaltp2 = listeNoteTp2.Sum();
            decimal noteTotalfinal = listeNoteFinal.Sum();

            decimal moyenneTp1 = noteTotaltp1 / nombreDeleve;
            decimal moyenneIntra = noteIntraTotal / nombreDeleve;
            decimal moyenneTp2 = noteTotaltp2 / nombreDeleve;
            decimal moyenneFinal = noteTotalfinal / nombreDeleve;

            lbValeurTp1.Text = String.Format("{0:0.00}", moyenneTp1);
            lbValeurIntra.Text = String.Format("{0:0.00}", moyenneIntra);
            lbValeurTp2.Text = String.Format("{0:0.00}", moyenneTp2);
            lbValeurFinal.Text = String.Format("{0:0.00}", moyenneFinal);

            decimal noteSommaireTp1 = moyenneTp1 * 0.1M;
            decimal noteSommaireIntra = moyenneIntra * 0.4M;
            decimal noteSommaireTp2 = moyenneTp2 * 0.1M;
            decimal noteSommaireFinal = moyenneFinal * 0.4M;

            decimal noteSommaire = noteSommaireTp1 + noteSommaireIntra + noteSommaireTp2 + noteSommaireFinal;
            lbNoteSommaire.Text = String.Format("{0:0.00}", noteSommaire);
        }


        private void txBoxRecherche_TextChanged_1(object sender, EventArgs e)
        { 

            string searchVal = txBoxRecherche.Text.ToLower();
            foreach (ListViewItem item in listView1.Items)
            {
                //enleve ca pis ca marche
                foreach (ListViewItem.ListViewSubItem subSearch in item.SubItems)
                {
                    // IMPORTANT *** ColumnHeader *** IMPORTANT
                   // move condition here
                   if (searchVal != "" && subSearch.Text.ToLower().Contains(searchVal) == true)
                   {
                       subSearch .BackColor = Color.Coral;    
                   }
                   else
                   {
                       subSearch.BackColor = Color.White;
                   }
                }

                item.UseItemStyleForSubItems = false;
            }
            
        }

        public void RefreshForm2(Form2 myform2)
        {
            int form2_X = this.Location.X;
            int form2_Y = this.Location.Y;
            this.Close();
            Form2 myForm = new Form2();
            myForm.Show();
            myForm.Location = new Point(form2_X, form2_Y);
        }
    }
}