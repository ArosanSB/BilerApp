using BusniessLogic.BLL;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfBiler.Windows
{
    /// <summary>
    /// Interaction logic for FormWindow.xaml
    /// </summary>
    public partial class FormWindow : Window
    {
        public BilDTO bil;
        
        public FormWindow()
        {
            InitializeComponent();
            bil = new BilDTO();
            
            ChangeFormSetup("Opret");
            
        }
        public FormWindow(BilDTO bilUpdate)
        {
            InitializeComponent();
            this.bil = bilUpdate;
            ChangeFormSetup("Opdatere");
            setDataForUpdateHandler();
            

        }

        private void Done(object sender, RoutedEventArgs e)
        {
            string regnr = this.tbox_Regnr.Text.Trim();
            string model = this.tbox_Model.Text.Trim();
            string mærke = this.tbox_Mærke.Text.Trim();
            int aargang = int.Parse(this.tbox_Aargang.Text);
            int km;
            if (this.tbox_Km == null)
            {
                km = 0;
            } else
            {
                 km = int.Parse(this.tbox_Km.Text.Trim());

            }

            if (validateData(regnr, mærke, model, aargang, km))
            {
                this.bil.RegNr = regnr;
                    this.bil.Model = model;
                    this.bil.Mærke = mærke;
                    this.bil.Aargang = aargang;
                this.bil.kM = km;
                this.DialogResult = true;
                this.Close();
            }


        }

        public void setDataForUpdateHandler()
        {
            this.tbox_Regnr.Text = bil.RegNr;
            this.tbox_Model.Text = bil.Model;
            this.tbox_Mærke.Text = bil.Mærke ;
            this.tbox_Aargang.Text = bil.Aargang.ToString();
            this.tbox_Km.Text = bil.kM.ToString();
        }

        public void ChangeFormSetup(string title)
        {
            lbl_Bil.Content = title + " bil";
            btn_CreateUpdate.Content = title;

        }

        private bool validateData(string regnr, string mærke,string model,int aargang,int km)
        {
            if (regnr.Trim().Length<=1)
            {
                this.lbl_Error.Content = "Reg nr. skal have minimum 1 karakter";
                return false;
            }
            if (model.Trim().Length <= 1)
            {
                this.lbl_Error.Content = "Model skal have minimum 1 karakter";

                return false;
            }
            if (mærke.Trim().Length <= 1)
            {
                this.lbl_Error.Content = "Mærke. skal have minimum 1 karakter";

                return false;
            }
            if (aargang<=1900 || aargang>=2022 )
            {
                this.lbl_Error.Content = "Årgang skal være større end 1900 og mindre 2022";

                return false;
            }
            if (km < 0)
            {
                this.lbl_Error.Content = "Kilometer skal være større end 0";

                return false;
            }

            


            return true;
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
