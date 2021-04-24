using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMLib.Extensions;

namespace AffinCipher //(a * x) + b) % 26
{
    public partial class Form1 : Form
    {

        #region Important Assignments
        //building alphabet variables
        string[] orignalAlphaBet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        List<char> subsitutionAlphaBet;
        int a = 0, b = 0, result = 0, inverseModulo = 0;

        //Encryption Varaibles
        string userOTToEncrypt = string.Empty, userCTToDecrypt = string.Empty, CipherText = string.Empty;
        List<char> cipherTextList = new List<char>();
        List<int> indexOfOrginal, indexofCipherText, indexofCipherTextDecryption;

        //decryption variables 
        List<char> openTextList = new List<char>();
        string OpenText = string.Empty;

        #endregion

        #region Function to calculate Mod correctly
        float mod(float a, float b)
        {
            return (float)(a - b * Math.Floor(a / b));
        }

        #region buttin clear to clear all fields
        private void btnClearAllFields_Click(object sender, EventArgs e)
        {
            txtBoxSubsituitionAlphabet.Text = string.Empty;
            numericKeyA.Value = 0;
            numericKeyB.Value = 0;
            TextBoxEncryption.Text = string.Empty;
            TextBoxFilteredOT.Text = string.Empty;
            TextBoxCipherText.Text = string.Empty;
            TextBoxDecryption.Text = string.Empty;
            TextBoxDecryptedText.Text = string.Empty;
            TextBoxFilteredDecryptedText.Text = string.Empty;


        }
        #endregion


        #endregion

        #region Method to check if the keys and are empty 

        public bool CheckKeysFields()
        {
            if (numericKeyA.Value == 0 || numericKeyB.Value == 0)
            {
                MessageBox.Show("Please provide the Keys for the Encryption and Decryption", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        #endregion

        #region Method to clear every varaible and list execlude a and b 
        public void Clear()
        {
            inverseModulo = 0; OpenText = string.Empty;
            cipherTextList.Clear();
            indexOfOrginal.Clear();
            openTextList.Clear();
            OpenText = string.Empty;
            indexofCipherText.Clear();
            indexofCipherTextDecryption.Clear();
        }

        #endregion
        public Form1()
        {
            InitializeComponent();
            subsitutionAlphaBet = new List<char>();
            indexOfOrginal = new List<int>();
            indexofCipherText = new List<int>();
            indexofCipherTextDecryption = new List<int>();
            txtBoxOrginalAlphabet.Text = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";

        }

        #region Button Build subsitution alphabet 
        private void btnBuildSubsitutionAplhabet_Click(object sender, EventArgs e)
        {


            if (numericKeyA.Value == 0 || numericKeyB.Value == 0)
            {
                MessageBox.Show("Please Provide the Key subsitution info", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //else if A and B not 0(empty)
            else
            {
                //reset values for another click 
                subsitutionAlphaBet.Clear();

                //check if A is an Even number 
                if (numericKeyA.Value % 2 == 0)
                {
                    MessageBox.Show("Choose an odd number for the Key A so you are able to decrypt the text later !!", "Wrong Choice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //else do all the job for building subsitution alphabet
                else
                {

                    a = (int)(numericKeyA.Value);
                    b = (int)(numericKeyB.Value);

                    for (int i = 0; i < 26; i++)
                    {
                        result = ((a * i) + b) % (26);
                        subsitutionAlphaBet.Add(char.Parse(orignalAlphaBet[result]));
                    }

                    txtBoxSubsituitionAlphabet.Text = String.Join(",", subsitutionAlphaBet.ToArray());
                }

            }

        }
        #endregion

        #region button Encrypt
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (CheckKeysFields() == true)
            {
                if (TextBoxEncryption.Text == string.Empty)
                {
                    MessageBox.Show("Please provide the Text to be Encrypted", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else if user provided text we have to encrypt it but we have to do some filtering 
                else
                {
                    //check if the subsitution alphabet is built
                    if (txtBoxSubsituitionAlphabet.Text == string.Empty)
                    {
                        MessageBox.Show("Build the Subsitution alphabet First", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        //reset value for another click
                        Clear();

                        #region Filtering of user OT input 

                        //1- removing Diacritics
                        userOTToEncrypt = TextBoxEncryption.Text;
                        userOTToEncrypt = userOTToEncrypt.RemoveDiacritics();
                        TextBoxCipherText.Text = userOTToEncrypt;

                        //2- replace all special characaters by nothing using for loop
                        char[] specialChar = { '?', '!', '.', '^', '(', ')', ',', '-', '_', '+', '=', '@', '#', '$', '%', '*', '~', '`', '|', '[', ']', '<', '>', '’', '"' };
                        for (int i = 0; i < specialChar.Length; i++)
                        {
                            userOTToEncrypt = userOTToEncrypt.Replace(specialChar[i].ToString(), string.Empty);
                        }
                        userOTToEncrypt = userOTToEncrypt.Replace("\"", "");
                        userOTToEncrypt = userOTToEncrypt.Replace('/'.ToString(), string.Empty);

                        //3- turn the string to upper case 
                        userOTToEncrypt = userOTToEncrypt.ToUpper();

                        //4- turn every space to XSPACEX
                        for (int i = 0; i < userOTToEncrypt.Length; i++)
                        {
                            if (Char.IsWhiteSpace(userOTToEncrypt[i]))
                            {
                                userOTToEncrypt = userOTToEncrypt.Replace(userOTToEncrypt[i].ToString(), "XSPACEX");
                            }
                        }
                        //5- omitt all digit numbers 
                        for (int i = 0; i < userOTToEncrypt.Length; i++)
                        {
                            if (Char.IsDigit(userOTToEncrypt[i]))
                            {
                                userOTToEncrypt = userOTToEncrypt.Replace(userOTToEncrypt[i].ToString(), string.Empty);
                            }
                        }
                        TextBoxFilteredOT.Text = userOTToEncrypt;

                        #endregion


                        #region Encryption 


                        for (int i = 0; i < userOTToEncrypt.Length; i++)
                        {
                            for (int j = 0; j < orignalAlphaBet.Length; j++)
                            {
                                if (userOTToEncrypt[i].ToString() == orignalAlphaBet[j])
                                {
                                    indexOfOrginal.Add(j);
                                }
                            }
                        }

                        for (int i = 0; i < indexOfOrginal.Count; i++)
                        {

                            cipherTextList.Add(subsitutionAlphaBet[indexOfOrginal[i]]);
                        }

                        CipherText = new string(cipherTextList.ToArray());

                        TextBoxCipherText.Text = CipherText;
                        #endregion


                    }
                }
            }
        }

        #endregion

        #region button Decrypt
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (CheckKeysFields() == true)
            {
                if (TextBoxDecryption.Text == string.Empty)
                {
                    MessageBox.Show("Please provide the Text to be Decrypted", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //check if the subsitution alphabet is built
                    if (txtBoxSubsituitionAlphabet.Text == string.Empty)
                    {
                        MessageBox.Show("Build the Subsitution alphabet First", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        Clear();
                        userCTToDecrypt = TextBoxDecryption.Text;
                        userCTToDecrypt = userCTToDecrypt.ToUpper();
                        
                        //1- First finding inverse modular of a 
                        for (int i = 0; i < 26; i++)
                        {
                            if (((i * a) % 26) == 1)
                            {
                                inverseModulo = i;
                            }
                        }
                        //2- collect indexes of each character of cipher text from orginal alphabet
                        for (int j = 0; j < userCTToDecrypt.Length; j++)
                        {
                            for (int i = 0; i < orignalAlphaBet.Length; i++)
                            {
                                if (userCTToDecrypt[j].ToString() == orignalAlphaBet[i])
                                {
                                    indexofCipherText.Add(i);
                                }
                            }
                        }

                        //3- using decryption equation to build indexes to be decrypted from orginal alphabet back 

                        for (int i = 0; i < indexofCipherText.Count; i++)
                        {
                            // nf()
                            //(indexofCipherText[i] - b) * (inverseModulo) % 26
                            indexofCipherTextDecryption.Add((int)(mod((indexofCipherText[i] - b) * (inverseModulo), 26)));
                        }

                        //4- build the decrypted text from indexofCipherTextDecryption from orginal alphabet 

                        // cipherTextList.Add(subsitutionAlphaBet[indexOfOrginal[i]]);
                        for (int i = 0; i < indexofCipherText.Count; i++)
                        {
                            openTextList.Add(char.Parse(orignalAlphaBet[indexofCipherTextDecryption[i]]));
                        }

                        // 5- show open text or decrypted text 
                        OpenText = new string(openTextList.ToArray());
                        TextBoxDecryptedText.Text = OpenText;
                        //6- filtering the decrypted message

                        string FilterDeCryptedText = OpenText;
                        for (int i = 0; i < OpenText.Length; i++)
                        {
                            FilterDeCryptedText = FilterDeCryptedText.Replace("XSPACEX", " ");
                        }
                        TextBoxFilteredDecryptedText.Text = FilterDeCryptedText;
                    }
                }
            }

        }
        #endregion

        #region Event for allowing only letters and spaces and digits for user inputs to Encrypt his text
        private void TextBoxEncryption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
