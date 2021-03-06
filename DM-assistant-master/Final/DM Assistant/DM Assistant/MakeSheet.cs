﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Assistant
{
    public partial class MakeSheet : Form
    {
        public MakeSheet()
        {
            InitializeComponent();
        }
        //Sets StatMod Accoding to stat level
        private int SetStatMod(int Stat)
        {
            int intMod = 0;
            switch (Stat)
            {
                case 1:
                    intMod = -5;
                    break;
                case 2:
                case 3:
                    intMod = -4;
                    break;
                case 4:
                case 5:
                    intMod = -3;
                        break;
                case 6:
                case 7:
                    intMod = -2;
                    break;
                case 8:
                case 9:
                    intMod = -1;
                    break;
                case 10:
                case 11:
                    intMod = 0;
                    break;
                case 12:
                case 13:
                    intMod = 1;
                    break;
                case 14:
                case 15:
                    intMod = 2;
                    break;
                case 16:
                case 17:
                    intMod = 3;
                    break;
                case 18:
                case 19:
                    intMod = 4;
                    break;
                case 20:
                    intMod = 5;
                    break;
            }
            return intMod;
        }
        private void txtEXP_TextChanged(object sender, EventArgs e)
        {
            //Sets the lvl according to the exp 
            int intEXP;
            int intLevel;
            int intProficancy;
            if (int.TryParse(txtEXP.Text, out intEXP))
            {
                if (intEXP > 355000)
                {
                    lblLevel.Text = "20";
                }
                else if (intEXP >= 305000)
                {
                    lblLevel.Text = "19";
                }
                else if (intEXP >= 265000)
                {
                    lblLevel.Text = "18";
                }
                else if (intEXP >= 225000)
                {
                    lblLevel.Text = "17";
                }
                else if (intEXP >= 195000)
                {
                    lblLevel.Text = "16";
                }
                else if (intEXP >= 165000)
                {
                    lblLevel.Text = "15";
                }
                else if (intEXP >= 140000)
                {
                    lblLevel.Text = "14";
                }
                else if (intEXP >= 120000)
                {
                    lblLevel.Text = "13";
                }
                else if (intEXP >= 100000)
                {
                    lblLevel.Text = "12";
                }
                else if (intEXP >= 85000)
                {
                    lblLevel.Text = "11";
                }
                else if (intEXP >= 64000)
                {
                    lblLevel.Text = "10";
                }
                else if (intEXP >= 48000)
                {
                    lblLevel.Text = "9";
                }
                else if (intEXP >= 34000)
                {
                    lblLevel.Text = "8";
                }
                else if (intEXP >= 23000)
                {
                    lblLevel.Text = "7";
                }
                else if (intEXP >= 14000)
                {
                    lblLevel.Text = "6";
                }
                else if (intEXP >= 6500)
                {
                    lblLevel.Text = "5";
                }
                else if (intEXP >= 2700)
                {
                    lblLevel.Text = "4";
                }
                else if (intEXP >= 900)
                {
                    lblLevel.Text = "3";
                }
                else if (intEXP >= 300)
                {
                    lblLevel.Text = "2";
                }
                else if (intEXP >= 0)
                {
                    lblLevel.Text = "1";
                }
                //Sets proficancy bounus according to level
                if(int.TryParse(lblLevel.Text, out intLevel))
                {
                    switch (intLevel)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            intProficancy = 2;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                            intProficancy = 3;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                            intProficancy = 4;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                            intProficancy = 5;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            intProficancy = 6;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                    }
                }
            }
        }

        private void txtSTR_TextChanged(object sender, EventArgs e)
        {
            int STR;
            if (int.TryParse(txtSTR.Text, out STR))
            {
                STR = SetStatMod(STR);
                if (STR <= 0)
                {
                    lblSTR.Text = STR.ToString("0");
                }
                else
                {
                    lblSTR.Text = "+" + STR.ToString("0");
                }
            }
        }

        private void txtDEX_TextChanged(object sender, EventArgs e)
        {
            int DEX;
            if (int.TryParse(txtDEX.Text, out DEX))
            {
                DEX = SetStatMod(DEX);
                if (DEX <= 0)
                {
                    lblDEX.Text = DEX.ToString("0");
                }
                else
                {
                    lblDEX.Text = "+" + DEX.ToString("0");
                }
            }
        }

        private void txtCON_TextChanged(object sender, EventArgs e)
        {
            int CON;
            if (int.TryParse(txtCON.Text, out CON))
            {
                CON = SetStatMod(CON);
                if (CON <= 0)
                {
                    lblCON.Text = CON.ToString("0");
                }
                else
                {
                    lblCON.Text = "+" + CON.ToString("0");
                }
            }
        }

        private void txtINT_TextChanged(object sender, EventArgs e)
        {
            int INT;
            if (int.TryParse(txtINT.Text, out INT))
            {
                INT = SetStatMod(INT);
                if (INT <= 0)
                {
                    lblINT.Text = INT.ToString("0");
                }
                else
                {
                    lblINT.Text = "+" + INT.ToString("0");
                }
            }
        }

        private void txtWIS_TextChanged(object sender, EventArgs e)
        {
            int WIS;
            if (int.TryParse(txtWIS.Text, out WIS))
            {
                WIS = SetStatMod(WIS);
                if (WIS <= 0)
                {
                    lblWIS.Text = WIS.ToString("0");
                }
                else
                {
                    lblWIS.Text = "+" + WIS.ToString("0");
                }
            }
        }

        private void txtCHA_TextChanged(object sender, EventArgs e)
        {
            int CHA;
            if (int.TryParse(txtCHA.Text, out CHA))
            {
                CHA = SetStatMod(CHA);
                if (CHA <= 0)
                {
                    lblCHA.Text = CHA.ToString("0");
                }
                else
                {
                    lblCHA.Text = "+" + CHA.ToString("0");
                }
            }
        }

        private void cmbRace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
