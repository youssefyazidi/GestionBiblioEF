using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblioEF
{
    public partial class Form1 : Form
    {

        const int MODE_LECTURE = 1;
        const int MODE_AJOUT = 2;
        const int MODE_MODIFICATIONN = 3;
        private int MODE_FORM = MODE_LECTURE;



        ModelBiblio context = new ModelBiblio();
        BindingSource binding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modeLecture();

            //Définir le DataSource (Lier à la liste renvoyer par toList)
            //Requete LINQ
            /* binding.DataSource = 
                 context.Adherents.ToList();*/

            //Le DataSource est le contexte directement
            //Appel de Load
            context.Adherents.Load();
            //Liaison vers le contexte
            binding.DataSource = context.Adherents.Local;

            
            //Liaison avec l'interface
            textBoxCode.DataBindings.Add("Text", binding, "CodeA");
            textBoxNom.DataBindings.Add("Text", binding, "NomA");
            textBoxAdresse.DataBindings.Add("Text", binding, "Adresse");
            dateTimePickerInscription.DataBindings.Add("Value", binding, "DateInscription");
        }

        private void buttonfirst_Click(object sender, EventArgs e)
        {
            binding.MoveFirst();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            binding.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            binding.MoveNext();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            binding.MoveLast();
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            if (MODE_FORM == MODE_LECTURE)
            {
                modeAjout();

                binding.AddNew();
            }
            else
            {
                //Operation d'ajout
                //Confirmer de l'edition
                binding.EndEdit();
                modeLecture();
            }
        }



        //Les modes de la fenetre
        private void modeLecture()
        {
            MODE_FORM = MODE_LECTURE;
            textBoxCode.Enabled = textBoxNom.Enabled =
                textBoxAdresse.Enabled = dateTimePickerInscription.Enabled = false;
            buttonNouveau.Text = "Nouveau";
            buttonModifier.Text = "Modifier";
            buttonSupprimer.Text = "Suppimer";
            buttonModifier.Enabled = true;
            buttonSupprimer.Enabled = true;
            buttonRechercher.Enabled = true;

            buttonfirst.Enabled = buttonLast.Enabled = buttonNext.Enabled =
                buttonPrevious.Enabled = true;
        }

        private void modeAjout()
        {
            MODE_FORM = MODE_AJOUT;
            textBoxNom.Enabled =
                 textBoxAdresse.Enabled = dateTimePickerInscription.Enabled = true;
         
            buttonNouveau.Text = "Ajouter";
            buttonModifier.Text = "Modifier";
            buttonSupprimer.Text = "Suppimer";
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonRechercher.Enabled = false;

            buttonfirst.Enabled = buttonLast.Enabled = buttonNext.Enabled =
                buttonPrevious.Enabled = false;
        }


        private void modeModification()
        {
            MODE_FORM = MODE_MODIFICATIONN;
            textBoxNom.Enabled =
                 textBoxAdresse.Enabled = dateTimePickerInscription.Enabled = true;

            buttonNouveau.Text = "Nouveau";
            buttonModifier.Text = "Valider";
            buttonSupprimer.Text = "Suppimer";
            buttonModifier.Enabled = true;
            buttonSupprimer.Enabled = false;
            buttonRechercher.Enabled = false;

            buttonfirst.Enabled = buttonLast.Enabled = buttonNext.Enabled =
                buttonPrevious.Enabled = false;
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Est ce que vous voulez enregistrer ?"
              , "Enregistrement...",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
             /*   Adherent adh = new Adherent()
                {
                    NomA = "adherent5",
                    Adresse = "adresse5",

                };
                //Attacher l'objet au contexte
                context.Adherents.Add(adh);*/
                context.SaveChanges();
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (MODE_FORM == MODE_LECTURE)
            {
                modeModification();
            }
            else if (MODE_FORM == MODE_MODIFICATIONN)
            {
                binding.EndEdit();
                modeLecture();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Est ce que vous voulez supprimer ?"
                , "Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {

                binding.RemoveAt(binding.Position);
            }
        }
    }
}
