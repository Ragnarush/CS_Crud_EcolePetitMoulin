
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;

namespace EcolePetitMoulin
{
    public partial class Form1 : Form
    {
        ErrorProvider err1 = new ErrorProvider();
        Form2 myForm2;

        // ************************** FIELDS / CHAMPS **************************
        // Indique la position ou nous sommes dans le fichier
        public int pos = -1;
        // Longueur de l'enregistrement
        public const int Longueur = 209;
        // indique l’action nous allons faire sur le fichier
        public string action = "";
        // Indique le nombre de membres contenu dans le fichier
        public int nb_eleves = 0;
        public int nb_index = 0;
        // Indique les noms de fichiers
        public string NomFichier = "Eleves.bin";
        public string NomFichierTemp = "Eleves.tmp";

        // Constructeur
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            BarrerDebarrer(false);
            try
            {
                FileStream fs = new FileStream(NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                // Ici on détermine le nombre de membres dans le fichier delon la longueur du fichier / par la longueur d'un eleve
                nb_eleves = (int)fs.Length / Longueur;
                // on ferme le filestream
                fs.Close();

                if (nb_eleves > 0) //   commentaire PRUDENT POUR ALEX
                {
                    // Débarrer
                    grBoxNavigation.Enabled = true;
                    btnMiseAjour.Enabled = true;
                    btnDestruction.Enabled = true;
                    // Récupérer le 1er membre du fichier
                    pos = 0;
                    RecupererEleve(pos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }


        // ************************** MÉTHODES **************************
        public void RecupererEleve(int p)
        {
            try
            {
                using (FileStream fs = new FileStream(NomFichier, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        fs.Seek(p * Longueur, SeekOrigin.Begin);

                        numUpDownIndex.Value = br.ReadInt32();
                        mskBoxTelephone.Text = br.ReadString();
                        txBoxPrenom.Text = br.ReadString();
                        txBoxNom.Text = br.ReadString();

                        char sexe = br.ReadChar();
                        if (sexe == 'F')
                            radioBtnFemme.Checked = true;
                        else
                            radioBtnHomme.Checked = true;

                        mskTxBoxDate.Text = br.ReadString();

                        txBoxNoCivique.Text = br.ReadString();
                        txBoxNomDeRue.Text = br.ReadString();
                        txBoxVille.Text = br.ReadString();
                        mskCodePostal.Text = br.ReadString();
                        mskBoxCodePermanent.Text = br.ReadString();

                        numUpDownTp1.Value = br.ReadDecimal();
                        numUpDownTp2.Value = br.ReadDecimal();
                        numUpDownIntra.Value = br.ReadDecimal();
                        numUpDownFinal.Value = br.ReadDecimal();

                        txBoxNoId.Text = br.ReadString();

                        //Ecrire tout les champs associé en ordre 
                        btn.Text = "Eleve " + (p + 1).ToString() + " de " + nb_eleves.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BarrerDebarrer(bool option) 
        {   // option à true on débarre sinon on barre
            numUpDownIndex.Enabled = false;
            grBoxInfoEleves.Enabled = option;
            btnEnregistrer.Enabled = option;
            btnAnnuler.Enabled = option;
            grBoxNote.Enabled = option; 
            btnInscription.Enabled = !option;
            //btnGenererId.Enabled = option;


            if (nb_eleves == 0)
            {
                btnMiseAjour.Enabled = false;
                btnDestruction.Enabled = false;
                grBoxNavigation.Enabled = false;
            }
            else
            {
                btnMiseAjour.Enabled = !option;
                btnDestruction.Enabled = !option;
                grBoxNavigation.Enabled = !option;
            }
        }

        private void ViderEcran() //Ici on vide les champs pour l'utlisateur
        {
            mskBoxTelephone.Clear();
            txBoxPrenom.Clear();
            txBoxNom.Clear();
            radioBtnFemme.Checked = false;
            radioBtnHomme.Checked = false;
            mskTxBoxDate.Clear();
            txBoxNoCivique.Clear();
            txBoxNomDeRue.Clear();
            txBoxVille.Clear();
            mskCodePostal.Clear();
            mskBoxCodePermanent.Clear();
            numUpDownTp1.Value = 0;
            numUpDownTp2.Value = 0;
            numUpDownIntra.Value = 0;
            numUpDownFinal.Value = 0;
            txBoxNoId.Clear();
        }
        private bool ValiderEcran() // Validation des champs pour diriger l'utlisateur
        {
            err1.Clear(); // Efface les messages d'erreurs
            bool valide = true;
            // 1) Vérifier si le prénom est ok
            if (txBoxPrenom.Text.Trim() == "" || txBoxPrenom.Text.Length < 2)
            {
                valide = false;
                err1.SetError(txBoxPrenom, "Prénom obligatoire et 2 caractères minimum");
            }
            // 2) Vérifier si le nom est ok
            if (txBoxNom.Text.Trim() == "" || txBoxNom.Text.Length < 2)
            {
                valide = false;
                err1.SetError(txBoxNom, "Nom obligatoire et 2 caractères minimum");
            }
            // 3) Vérifier si le Téléphone est ok
            if (mskBoxTelephone.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskBoxTelephone, "Téléphone obligatoire");
            }
            if (mskTxBoxDate.Text == "")
            {
                valide = false;
                err1.SetError(mskTxBoxDate, "Date obligatoire");
            }

            if (mskBoxCodePermanent.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskBoxCodePermanent, "Code Permanent obligatoire");
            }

            if (txBoxNoCivique.Text.Trim() == "" || txBoxNoCivique.Text.Length < 2)
            {
                valide = false;
                err1.SetError(txBoxNoCivique, "Adresse obligatoire et 2 caractères minimum");
            }
            if (txBoxNomDeRue.Text.Trim() == "" || txBoxNomDeRue.Text.Length < 2)
            {
                valide = false;
                err1.SetError(txBoxNomDeRue, "Adresse obligatoire et 2 caractères minimum");
            }
            if (txBoxVille.Text.Trim() == "" || txBoxVille.Text.Length < 2)
            {
                valide = false;
                err1.SetError(txBoxVille, "Ville obligatoire et 2 caractères minimum");
            }
            if (mskCodePostal.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskCodePostal, "Code postal obligatoire");
            }
            if (numUpDownTp1.Value == 1 && numUpDownTp2.Value == 1 && numUpDownIntra.Value == 1 && numUpDownFinal.Value == 1)
            {
                valide = false;
                err1.SetError(numUpDownTp1, "Veuillez saisir au moins un coefficient");
            }
            return valide;
        }

        //private void mskTxBoxDate_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        //{
        //    if (!e.IsValidInput) { toolTip1.ToolTipTitle = "Date invalide"; toolTip1.Show("Entrer une date valide avec le format mm/dd/yyyy.", mskTxBoxDate, 0, -20, 5000); }
        //    else
        //    {                //Now that the type has passed basic type validation, enforce more specific type rules.                
        //        DateTime userDate = (DateTime)e.ReturnValue;
        //        var myDate = DateTime.Now; var newDate = myDate.AddYears(-16);
        //        if (userDate > newDate) { toolTip1.ToolTipTitle = "Date invalide"; toolTip1.Show("Entrer une date inférieur à cette date. L'élève est trop jeune pour s'inscrire!", mskTxBoxDate, 0, -20, 5000); e.Cancel = true; }
        //    }
        //}
        //
        //private void mskTxBoxDate_KeyDown(object sender, KeyEventArgs e)
        //{
        //    toolTip1.Hide(mskTxBoxDate);
        //}

        // Create (CRUD)
        private void AjouterEleve()

        {   // 1) ouvrir le filestream

            ConcatID(); // Génère le numéro d'identification unique de l'élève 

            using (FileStream fs = new FileStream(NomFichier, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                // 2) Se créer un BinaryWriter
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    // 3) On récupère les données du formulaire
                    int noIndex = (int)numUpDownIndex.Value;  // fonction pour resoudre le prob d'indexation
                    string tel = mskBoxTelephone.Text; 
                    string prenom = txBoxPrenom.Text.PadRight(15);
                    string nom = txBoxNom.Text.PadRight(15);
                    char sexe = radioBtnFemme.Checked ? 'F' : 'M';
                    string date = mskTxBoxDate.Text.PadRight(10); 
                    string numeroCivique = txBoxNoCivique.Text.PadRight(5);
                    string rue = txBoxNomDeRue.Text.PadRight(25);
                    string ville = txBoxVille.Text.PadRight(20);
                    string codePostal = mskCodePostal.Text.PadRight(7); 
                    string codePermanent = mskBoxCodePermanent.Text.PadRight(12); 
                    decimal tp1 = numUpDownTp1.Value;
                    decimal intra = numUpDownIntra.Value;
                    decimal tp2 = numUpDownTp2.Value;
                    decimal final = numUpDownFinal.Value;
                    string noID = txBoxNoId.Text.PadRight(5);
                    
                    // 4) ici on écrit dans le fichier
                    bw.Write(noIndex);
                    bw.Write(tel);
                    bw.Write(prenom);
                    bw.Write(nom);
                    bw.Write(sexe);
                    bw.Write(date);
                    bw.Write(numeroCivique);
                    bw.Write(rue);
                    bw.Write(ville);
                    bw.Write(codePostal);
                    bw.Write(codePermanent);
                    bw.Write(tp1);
                    bw.Write(intra);
                    bw.Write(tp2);
                    bw.Write(final);
                    bw.Write(noID);
                }
            } // 5) fermer le fichier se ferme automatiquement après le using
        }

        private void ModifierEleve()
        {   // 1) ouvrir le filestream pour membres.bin
            using (FileStream fs = new FileStream("Eleves.Bin", FileMode.Open, FileAccess.Write, FileShare.None))
            {
                // 2) Se créer un BinaryWriter
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    // 3) Déplacer la position dans le fichier binaire au premier octet du membre a modifier
                    fs.Seek(pos * Longueur, SeekOrigin.Begin);

                    // 4) Récupérer les données du formulaire pour réécire dans le ficheir membres.bin
                    int noIndex = (int)numUpDownIndex.Value;
                    string tel = mskBoxTelephone.Text.PadRight(14); 
                    string prenom = txBoxPrenom.Text.PadRight(15);
                    string nom = txBoxNom.Text.PadRight(15);
                    char sexe = radioBtnFemme.Checked ? 'F' : 'M';
                    string date = mskTxBoxDate.Text.PadRight(10); 
                    string numeroCivique = txBoxNoCivique.Text.PadRight(5);
                    string rue = txBoxNomDeRue.Text.PadRight(25);
                    string ville = txBoxVille.Text.PadRight(20);
                    string codePostal = mskCodePostal.Text.PadRight(7); 
                    string codePermanent = mskBoxCodePermanent.Text.PadRight(12); 
                    decimal tp1 = numUpDownTp1.Value;
                    decimal intra = numUpDownIntra.Value;
                    decimal tp2 = numUpDownTp2.Value;
                    decimal final = numUpDownFinal.Value;
                    string noID = txBoxNoId.Text.PadRight(5);

                    // 5) ici on écrit dans le fichier en écrasant les données existantes
                    bw.Write(noIndex);
                    bw.Write(tel);
                    bw.Write(prenom);
                    bw.Write(nom);
                    bw.Write(sexe);
                    bw.Write(date);
                    bw.Write(numeroCivique);
                    bw.Write(rue);
                    bw.Write(ville);
                    bw.Write(codePostal);
                    bw.Write(codePermanent);
                    bw.Write(tp1);
                    bw.Write(intra);
                    bw.Write(tp2);
                    bw.Write(final);
                    bw.Write(noID);
                }
            }
        }

        private void EnleverEleve()
        {
            // 1) Ouvrir le fichier membres.bin et créer le fichier membres.tmp
            using (FileStream fsSource = new FileStream(NomFichier, FileMode.Open, FileAccess.Read,
                FileShare.None))
            using (FileStream fsDest = new FileStream(NomFichierTemp, FileMode.Create, FileAccess.Write,
                FileShare.None))
            using (BinaryReader br = new BinaryReader(fsSource))
            {
                // 2) Créer les objets de lecture et écriture binaire
                
                using (BinaryWriter bw = new BinaryWriter(fsDest))
                {
                    // 3) Déclaration de variables pour la lecture
                    int bidon;
                    int noIndex;
                    string tel;
                    string prenom;
                    string nom;
                    char sexe;
                    string date;
                    string numeroCivique;
                    string rue;
                    string ville;
                    string codePostal;
                    string codePermanent;
                    decimal tp1;
                    decimal tp2;
                    decimal intra;
                    decimal final;
                    string noID;


                    // 4) Itérer tous les membres
                    for (int i = 0; i < nb_eleves; i++)
                    {


                        // 5) Lire les infos du membre dans membres.bin et les mettre dans des variables
                        //bidon = i;
                        noIndex = br.ReadInt32();                // modif ici 
                        tel = br.ReadString();
                        prenom = br.ReadString();
                        nom = br.ReadString();
                        sexe = br.ReadChar();
                        date = br.ReadString();
                        numeroCivique = br.ReadString();
                        rue = br.ReadString();
                        ville = br.ReadString();
                        codePostal = br.ReadString();
                        codePermanent = br.ReadString();
                        tp1 = br.ReadDecimal();
                        tp2 = br.ReadDecimal();
                        intra = br.ReadDecimal();
                        final = br.ReadDecimal();
                        noID = br.ReadString();

                        // 6) Si ce n'est pas le membre qu'on veut supprimer...
                        if (noIndex != numUpDownIndex.Value)
                        {
                           
                            // 7) Écrire dans le fichier membres.tmp
                            bw.Write(noIndex);
                            bw.Write(tel);
                            bw.Write(prenom);
                            bw.Write(nom);
                            bw.Write(sexe);
                            bw.Write(date);
                            bw.Write(numeroCivique);
                            bw.Write(rue);
                            bw.Write(ville);
                            bw.Write(codePostal);
                            bw.Write(codePermanent);
                            bw.Write(tp1);
                            bw.Write(tp2);
                            bw.Write(intra);
                            bw.Write(final);
                            bw.Write(noID);
                        }
                    }
                }
            }

            // 8) Détruire le fichier source membres.bin
            File.Delete(NomFichier);
            // 9) Déplacer/renommer le fichier destination membres.tmp en fichier source membres.bin
            File.Move(NomFichierTemp, NomFichier);

            // 10) Confirmer la destruction
            //nb_eleves_total = nb_eleves;    // MODIFICATION TEST
            nb_eleves--;
            MessageBox.Show("*** Membre # " + numUpDownIndex.Value + " a été supprimé avec succès ***");

            if (nb_eleves != 0)
                // 11) On doit se repositionner dans le fichier sur le dernier candidat
                btnDernier.PerformClick(); // ici on simule le clic de ce bouton
            else
            {
                ViderEcran();
                BarrerDebarrer(false);
            }
        }

        public void ConcatID()
        {
            string concatID; concatID = txBoxNom.Text.Substring(0, 3).ToUpper() + txBoxPrenom.Text.Substring(0, 1).ToUpper() + numUpDownIndex.Value.ToString().Substring(0, 1);
            txBoxNoId.Text = concatID;
        }

        // ************************** ÉVÈNEMENTS **************************

        private void btnInscription_Click_1(object sender, EventArgs e)
        {
            BarrerDebarrer(true);
            action = "AJOUT";
            numUpDownIndex.Value = nb_eleves + 1;    // ICI ON TRAVAIL KEKCHOSE AVEC LA FONCTION D'INDEXATION
            ViderEcran();
            txBoxPrenom.Focus();
            btn.Text = " *** Mode Ajout *** ";
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            // 1) Valider si l'écran est bien rempli
            if (ValiderEcran() == false)
            {
                return;
            }
            // 2) ici on ajoute... mais la semaine prochaine nous allons modifier
            if (action == "AJOUT")
            {
                AjouterEleve();
                MessageBox.Show("*** Membre ajouté avec succès ***");
                nb_eleves++;
                pos = nb_eleves - 1;
            }
            else if (action == "MODIF")
            {
                ModifierEleve();
                MessageBox.Show("*** Membre modifié avec succès ***");
            }
            btnAnnuler.PerformClick(); // PerformClick simule un clic du bouton

            myForm2.RefreshForm2(myForm2);
        }

        private void btnMiseAjour_Click_1(object sender, EventArgs e)
        {
            BarrerDebarrer(true);
            BarrerMaJ();
            action = "MODIF";
            txBoxPrenom.Focus();
            btn.Text = "*** Mode Modification ***";
            
            myForm2.RefreshForm2(myForm2);
        }

        private void BarrerMaJ()
        {
            txBoxPrenom.Enabled = false;
            txBoxNom.Enabled = false;
            grBoxSexe.Enabled = false;
            mskTxBoxDate.Enabled = false;
            mskBoxCodePermanent.Enabled = false;
            txBoxNoId.Enabled = false;
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            err1.Clear();
            BarrerDebarrer(false);
            action = "";
            if (pos != -1)
                RecupererEleve(pos);
            else
            {
                ViderEcran();
                if (numUpDownIndex.Value == 1) 
                    numUpDownIndex.Value = numUpDownIndex.Value - 1;
            }
        }

        private void btnDestruction_Click_1(object sender, EventArgs e) 
        {
            if (MessageBox.Show("Voulez-vous supprimer ce membre ?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EnleverEleve();
            }

            myForm2.RefreshForm2(myForm2);
        }

        private void btnPremier_Click_1(object sender, EventArgs e)
        {
            pos = 0;
            RecupererEleve(pos);
        }

        private void btnPrecedent_Click_1(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                RecupererEleve(pos);
            }
        }

        private void btnSuivant_Click_1(object sender, EventArgs e)
        {
            if (pos < nb_eleves - 1)
            {
                pos++;
                RecupererEleve(pos);
            }
        }

        private void btnDernier_Click_1(object sender, EventArgs e)
        {
            pos = nb_eleves - 1;
            RecupererEleve(pos);
        }

        private int GetNoEleve()
        {
            FileStream fs = new FileStream(NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            nb_eleves = (int)fs.Length / Longueur;
            fs.Close();
            return nb_eleves;
        }

        

        public void btnrechercher_Click(object sender, EventArgs e)
        {
            myForm2 = new Form2();
            myForm2.Show();
            btnrechercher.Enabled = false;
        }

        private void mskBoxCodePermanent_Enter(object sender, EventArgs e)
        {
            int number = GenererRandom();
            mskBoxCodePermanent.AppendText(txBoxNom.Text.Substring(0, 3).ToUpper() + txBoxPrenom.Text.Substring(0, 1).ToUpper());
            mskBoxCodePermanent.AppendText(mskTxBoxDate.Text.Substring(0, 5));
            mskBoxCodePermanent.AppendText(mskTxBoxDate.Text.Substring(8, 2));
            mskBoxCodePermanent.AppendText(number.ToString());
        }

        private int GenererRandom()
        {
            Random rnd = new Random();
            int number = rnd.Next(10, 99);
            return number;
        }

        public bool btnRechercherEnable()
        {
            return btnrechercher.Enabled = true;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

            string message = "Voulez-vous vraiment quitter?";
            string title = "Fermer le programme";
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
