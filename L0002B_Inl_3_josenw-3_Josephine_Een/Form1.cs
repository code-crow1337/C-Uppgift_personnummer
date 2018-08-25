using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L0002B_Inl_3_josenw_3_Josephine_Een
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnTryAgain.Visible = false; //Gör knapparna osynliga
            btnTestaIgen.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string userInput = txtPerNr.Text; //ta emot informationen användaten skrivier i textboxen
            int langd = userInput.Length; 
            if(langd == 10) { // om längden inte är 10 siffror ber användaren att försöka igen
            int[] personummer = ConsolTakeInput(userInput); //kallar på metoden varav returen läggs i arrayen personummer
            KollarGiltighet(personummer); // kallar metoden och skickar in arrayen som parameter
            
            }
            else
            {
                txtGroupPerNrFalse.Visible = true; //Visar labeln 
                txtGroupPerNrFalse.Text = "Personummret felaktigt. Ange 10 siffror"; //ändrar labels text till stringen angiven
                btnTryAgain.Visible = true; //Knappen för att försöka igen visas


            }

        }


            private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFNamn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtENamn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPerNr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGroup_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        public void FyllUppgifter()
        {
            string fNamn = txtFNamn.Text; //Tar emot informationen och får en ny variabel
            string eNamn = txtENamn.Text;
            txtGroupENamnSvar.Visible = true; //labeln där informationen ska presenteras görs synlig
            txtGroupFNamnSvar.Visible = true; 
            txtGroupFNamnSvar.Text = fNamn; //tar anvädarens input och sätter den i rutan i resultat
            txtGroupENamnSvar.Text = eNamn;


        }
        public static int[] ConsolTakeInput(string userInput) //Tar in användarens input
        {
            int[] personummer = new int[10];
            for (int i = 0; i < userInput.Length; i++) //för varje position i arrayen får varje siffra en position
            {
                personummer[i] = userInput[i] - '0';

            }
            return personummer;//skickar tillbaka den färdiga arrayen till buttom_click
        }
        public void KollarGiltighet(int[] nummer) //argumentet är arrayen som omvandlas i metoden ConsolTakeInput
        {
            PersonNrCheck nr = new PersonNrCheck(); //skapar ett nytt objekt av typen personnrCheck
            int[] personummer = nummer; // argumentet som tagits emot läggs i arrayen för att hanteras
            int total = nr.PerNrAlgoritm(personummer); // tar emot summan när objektet genomgått metoden för att beräkna totalen
            bool giltig = nr.Giltigt(total); //en boolean skickar in totalen som kollar om totalen är giltig dvs ingen remainder
            if (giltig == true) //om talen var lika med 0, blir de true och satserna innanför utförs
            {        
                
                if(nr.CheckSex(personummer) == 0)//om remainder är noll så är de en kvinna
                {
                    txtSex.Visible = true; //gör labeln kön synnlig
                    txtGroupSexSvar.Visible = true; //gör svaret synnligt
                    txtGroupSexSvar.Text = " Kvinna "; //sätter texten ifrån "svar" till "man"
                }else
                {
                    txtSex.Visible = true;
                    txtGroupSexSvar.Visible = true;
                    txtGroupSexSvar.Text = "Man";
                }
                FyllUppgifter();//Fyller i de resterande uppgifterna i reslutat rutan
                txtGroupPerNrSvar.Visible = true; // visar att personnummret är giltigt
                txtGroupFnamn.Visible = true;
                txtGroupENamn.Visible = true;
                txtGroupPerNr.Visible = true;      
                btnTestaIgen.Visible = true; //gör testa igen knappen möjligt för fler programkörningar av applikationen
                
            }
            else
            {
                txtGroupPerNrFalse.Visible = true; //visar upp felmeddelande 
                btnTryAgain.Visible = true;   
            }
                   
        }

        private void btnAvslut_Click(object sender, EventArgs e)
        {
            Application.Exit();//stänger ner applikationen 
        }

        private void btnTryAgain_Click(object sender, EventArgs e)// när knappen "försök igen" klickas töms informationen och man ser applikationen som man 
            //såg den första gången
        {
            txtGroupPerNrFalse.Visible = false; 
            btnTryAgain.Visible = false;  
            btnOk.Visible = true;
            txtPerNr.Clear();
        }

        private void btnTestaIgen_Click(object sender, EventArgs e)//när testa igen körs efter en lyckad och giltigt personummer tas all information bort och man kan
            //köra programmet igen
        {
            btnTestaIgen.Visible = false;
            btnOk.Visible = true;
            txtFNamn.Clear(); 
            txtENamn.Clear();
            txtPerNr.Clear();  
            txtGroupPerNrSvar.Visible = false;
            txtGroupFnamn.Visible = false;
            txtGroupENamn.Visible = false;
            txtGroupPerNr.Visible = false;
            txtGroupENamnSvar.Visible = false;
            txtGroupFNamnSvar.Visible = false;
            txtSex.Visible = false;
            txtGroupSexSvar.Visible = false;
        }
    }
}
