using FTN.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientGUI
{
    public partial class Form1 : Form
    {
        public GDA gda = new GDA();
        ModelResourcesDesc modelRD = new ModelResourcesDesc();

        public List<ModelCode> listaPropertija = new List<ModelCode>();
        public List<long> lista_getVal = new List<long>();
        public List<long> lista_getExVal = new List<long>();
        public List<long> lista_getRelVal = new List<long>();
        public Form1()
        {
            InitializeComponent();

            //ZA EXT VALUES
            comboBox2.Items.Add("CONNODE");
            comboBox2.Items.Add("PLSIMPEDANCE");
            comboBox2.Items.Add("SERIESCOMP");
            comboBox2.Items.Add("DCLSEGMENT");
            comboBox2.Items.Add("ACLSEGMENT");
            comboBox2.Items.Add("TERMINAL");

            //za VALUES
            comboBox3.Items.Add("CONNODE");
            comboBox3.Items.Add("PLSIMPEDANCE");
            comboBox3.Items.Add("SERIESCOMP");
            comboBox3.Items.Add("DCLSEGMENT");
            comboBox3.Items.Add("ACLSEGMENT");
            comboBox3.Items.Add("TERMINAL");

            //za RELARED VALUES
            comboBox4.Items.Add("CONNODE");
            comboBox4.Items.Add("PLSIMPEDANCE");
            comboBox4.Items.Add("SERIESCOMP");
            comboBox4.Items.Add("DCLSEGMENT");
            comboBox4.Items.Add("ACLSEGMENT");
            comboBox4.Items.Add("TERMINAL");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region TAB 2
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        //klik na dugme kod Get Extended Values
        private void button1_Click(object sender, EventArgs e)
        {
            lista_getExVal.Clear();
            ispis1.Text = string.Empty;

            try
            {
                switch (comboBox2.SelectedItem.ToString())
                {
                    case "CONNODE":
                        lista_getExVal = gda.GetExtentValues(ModelCode.CONNODE);
                        break;
                    case "PLSIMPEDANCE":
                        lista_getExVal = gda.GetExtentValues(ModelCode.PLSIMPEDANCE);
                        break;
                    case "SERIESCOMP":
                        lista_getExVal = gda.GetExtentValues(ModelCode.SERIESCOMP);
                        break;
                    case "DCLSEGMENT":
                        lista_getExVal = gda.GetExtentValues(ModelCode.DCLSEGMENT);
                        break;
                    case "ACLSEGMENT":
                        lista_getExVal = gda.GetExtentValues(ModelCode.ACLSEGMENT);
                        break;
                    case "TERMINAL":
                        lista_getExVal = gda.GetExtentValues(ModelCode.TERMINAL);
                        break;
                }

                foreach (long gid in lista_getExVal)
                {
                    ResourceDescription rd = gda.GetValues(gid);
                    ispis1.Text += gda.IspisUTextBox(rd);
                }

            }
            catch
            {
                ispis1.Text = "ERROR!";
            }
        }
        #endregion


        #region TAB 1
        //punjenje drugog comboboxa u TABU 1
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista_getVal.Clear();
            richTextBox1.Text = string.Empty;
            comboBox1.Items.Clear();

            switch (comboBox3.SelectedItem.ToString())
            {
                case "CONNODE":
                    lista_getVal = gda.GetExtentValues(ModelCode.CONNODE);
                    break;
                case "PLSIMPEDANCE":
                    lista_getVal = gda.GetExtentValues(ModelCode.PLSIMPEDANCE);
                    break;
                case "SERIESCOMP":
                    lista_getVal = gda.GetExtentValues(ModelCode.SERIESCOMP);
                    break;
                case "DCLSEGMENT":
                    lista_getVal = gda.GetExtentValues(ModelCode.DCLSEGMENT);
                    break;
                case "ACLSEGMENT":
                    lista_getVal = gda.GetExtentValues(ModelCode.ACLSEGMENT);
                    break;
                case "TERMINAL":
                    lista_getVal = gda.GetExtentValues(ModelCode.TERMINAL);
                    break;
            }

            foreach (var v in lista_getVal) //vracalistu gidova
            {
                comboBox1.Items.Add(v);
            }

            comboBox1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                button2.Enabled = true;
            else
                button2.Enabled = false;
        }

        //KLIK KOD PRVOG TABA
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            if (comboBox1.SelectedItem != null)
            {
                try
                {
                    long gid = (long)comboBox1.SelectedItem;
                    ResourceDescription rd = gda.GetValues(gid);
                    richTextBox1.Text = gda.IspisUTextBox(rd);
                }
                catch
                {
                    richTextBox1.Text = "ERROR";
                }
            }

        }
        #endregion


        #region TAB 3
        //punjenjne 2. comboboxa iz 3. taba
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista_getRelVal.Clear();
            richTextBox2.Text = string.Empty;
            comboBox5.Items.Clear();

            switch (comboBox4.SelectedItem.ToString())
            {
                case "CONNODE":
                    lista_getRelVal = gda.GetExtentValues(ModelCode.CONNODE);
                    break;
                case "PLSIMPEDANCE":
                    lista_getRelVal = gda.GetExtentValues(ModelCode.PLSIMPEDANCE);
                    break;
                case "SERIESCOMP":
                    lista_getRelVal = gda.GetExtentValues(ModelCode.SERIESCOMP);
                    break;
                case "DCLSEGMENT":
                    lista_getRelVal = gda.GetExtentValues(ModelCode.DCLSEGMENT);
                    break;
                case "ACLSEGMENT":
                    lista_getRelVal = gda.GetExtentValues(ModelCode.ACLSEGMENT);
                    break;
                case "TERMINAL":
                    lista_getRelVal = gda.GetExtentValues(ModelCode.TERMINAL);
                    break;
            }

            foreach (var v in lista_getRelVal)
            {
                comboBox5.Items.Add(v);
            }
            comboBox5.Enabled = true;
        }

        //popunjavanje 3. comboboxa iz 3. taba
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaPropertija.Clear();
            richTextBox2.Text = string.Empty;
            comboBox6.Items.Clear();

            try
            {
                long gid = (long)comboBox5.SelectedItem;

                ModelCode mc = modelRD.GetModelCodeFromId(gid);
                ResourceDescription rd = gda.GetValues(gid);


                for (int i = 0; i < rd.Properties.Count; i++)
                {
                    switch (rd.Properties[i].Type)
                    {
                        case PropertyType.Reference:
                            listaPropertija.Add(rd.Properties[i].Id); break;
                        case PropertyType.ReferenceVector:
                            listaPropertija.Add(rd.Properties[i].Id); break;
                    }
                }

                foreach (var v in listaPropertija)
                {
                    comboBox6.Items.Add(v);
                }
            }
            catch
            {
                richTextBox2.Text = "ERROR!";
            }

            if (comboBox5.SelectedItem != null)
                comboBox6.Enabled = true;
            else
                comboBox6.Enabled = false;

        }

        //omogucen rad dugmeta i punjenje Combobox-a 7
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Items.Clear();
            if (comboBox6.SelectedItem != null)
                button3.Enabled = true;
            else
                button3.Enabled = false;


            long gid = (long)comboBox5.SelectedItem;
            ModelCode propertyId = (ModelCode)comboBox6.SelectedItem;
            ModelCode type;

            ResourceDescription rd = gda.GetValues(gid);
            List<long> gids = new List<long>();
            for (int i = 0; i < rd.Properties.Count; i++)
            {
                if (rd.Properties[i].Id == propertyId)
                {
                    gids = rd.Properties[i].PropertyValue.LongValues;
                }
            }
            comboBox7.Items.Add("");
            for (int i = 0; i < gids.Count; i++)
            {
                try
                {
                    type = modelRD.GetModelCodeFromId(gids[i]);
                    comboBox7.Items.Add(type);
                }
                catch
                {
                    continue;
                }

            }

        }

        //KLIK KOD 3. TABA
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = string.Empty;

            try
            {
                long gid = (long)comboBox5.SelectedItem;
                string selectedCLass = comboBox4.SelectedItem.ToString();
                ModelCode propertyId = (ModelCode)comboBox6.SelectedItem;
                ResourceDescription rd = gda.GetValues(gid);

                Association association = new Association();
                association.PropertyId = propertyId;

                if (comboBox7.SelectedItem.ToString() == "")
                {
                    association.Type = 0;
                }
                else
                {
                    ModelCode type = (ModelCode)comboBox7.SelectedItem;
                    association.Type = type;
                }

                List<long> retVal = gda.GetRelatedValues(gid, association);
                if (retVal != null)
                {
                    foreach (long val in retVal)
                    {
                        ResourceDescription rsd = gda.GetValues(val);
                        richTextBox2.Text += gda.IspisUTextBox(rsd);
                    }
                }
                else
                {
                    richTextBox2.Text += "";
                }

            }
            catch
            {
                richTextBox2.Text = "There is no value for !!";
            }
        }
        #endregion


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ispis1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
