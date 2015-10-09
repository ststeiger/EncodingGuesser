
using System.Windows.Forms;


namespace EncodingTester
{


    public partial class Form1 : Form
    {
        public System.Data.DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }


        public System.Data.DataTable CreateTable()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("SourceEncoding", typeof(string));
            dt.Columns.Add("TargetEncoding", typeof(string));
            dt.Columns.Add("Result", typeof(string));
            dt.Columns.Add("SourceEncodingName", typeof(string));
            dt.Columns.Add("TargetEncodingName", typeof(string));

            return dt;
        }


        private void btnTest_Click(object sender, System.EventArgs e)
        {
            dt = CreateTable();

            string correct = "Brokers México, Intermediario de Aseguro,S.A.";
            string broken = "Brokers MÃ©xico, Intermediario de Aseguro,S.A."; // Get text from database

            correct = this.txtCorrect.Text;
            broken = this.txtWrong.Text;


            // For reference
            // https://msdn.microsoft.com/en-us/library/system.text.encodinginfo.getencoding(v=vs.110).aspx
            int[] encs = new int[] { 
                 20127 // US-ASCII
                ,28591 // iso-8859-1 Western European (ISO)       
                ,28592 // iso-8859-2 Central European (ISO)       
                ,28593 // iso-8859-3 Latin 3 (ISO)
                ,28594 // iso-8859-4 Baltic (ISO)
                ,28595 // iso-8859-5 Cyrillic (ISO)
                ,28596 // iso-8859-6 Arabic (ISO)
                ,28597 // iso-8859-7 Greek (ISO)
                ,28598 // iso-8859-8 Hebrew (ISO-Visual)          
                ,28599 // iso-8859-9 Turkish (ISO)
                ,28603 // iso-8859-13 Estonian (ISO)
                ,28605 // iso-8859-15 Latin 9 (ISO)   
     
                ,1250 // windows-1250 Central European (Windows)      
                ,1251 // windows-1251 Cyrillic (Windows)             
                ,1252 // Windows-1252 Western European (Windows)      
                ,1253 // windows-1253 Greek (Windows)                
                ,1254 // windows-1254 Turkish (Windows)              
                ,1255 // windows-1255 Hebrew (Windows)               
                ,1256 // windows-1256 Arabic (Windows)               
                ,1257 // windows-1257 Baltic (Windows)               
                ,1258 // windows-1258 Vietnamese (Windows)

                ,20866 // Cyrillic (KOI8-R)
                ,21866 // Cyrillic (KOI8-U)  

                ,65000 // UTF-7
                ,65001 // UTF-8
                ,1200 // UTF-16
                ,1201 // Unicode (Big-Endian)    

                ,12000 // UTF-32
                ,12001 // UTF-32BE (UTF-32 Big-Endian) 
            };


            for (int i = 0; i < encs.Length; ++i)
            {

                for (int j = 0; j < encs.Length; ++j)
                {
                    System.Data.DataRow dr = dt.NewRow();

                    dr["SourceEncoding"] = encs[i];
                    dr["TargetEncoding"] = encs[j];


                    System.Text.Encoding enci = System.Text.Encoding.GetEncoding(encs[i]);
                    System.Text.Encoding encj = System.Text.Encoding.GetEncoding(encs[j]);

                    byte[] encoded = enci.GetBytes(broken);
                    string corrected = encj.GetString(encoded);

                    dr["Result"] = corrected;

                    dr["SourceEncodingName"] = enci.BodyName;
                    dr["TargetEncodingName"] = encj.BodyName;


                    if (System.StringComparer.InvariantCultureIgnoreCase.Equals(correct, corrected))
                        dt.Rows.Add(dr);
                } // Next j 

            } // Next i 

            this.dgvResult.DataSource = dt;
        }


        private void btnTestAll_Click(object sender, System.EventArgs e)
        {
            dt = CreateTable();

            string correct = "Brokers México, Intermediario de Aseguro,S.A.";
            string broken = "Brokers MÃ©xico, Intermediario de Aseguro,S.A."; // Get text from database

            correct = this.txtCorrect.Text;
            broken = this.txtWrong.Text;


            System.Text.EncodingInfo[] encs = System.Text.Encoding.GetEncodings();
            for (int i = 0; i < encs.Length; ++i)
            {

                for (int j = 0; j < encs.Length; ++j)
                {
                    System.Data.DataRow dr = dt.NewRow();

                    dr["SourceEncoding"] = encs[i].CodePage;
                    dr["TargetEncoding"] = encs[j].CodePage;


                    System.Text.Encoding enci = System.Text.Encoding.GetEncoding(encs[i].CodePage);
                    System.Text.Encoding encj = System.Text.Encoding.GetEncoding(encs[j].CodePage);

                    byte[] encoded = enci.GetBytes(broken);
                    string corrected = encj.GetString(encoded);

                    dr["Result"] = corrected;

                    dr["SourceEncodingName"] = enci.BodyName;
                    dr["TargetEncodingName"] = encj.BodyName;


                    if (System.StringComparer.InvariantCultureIgnoreCase.Equals(correct, corrected))
                        dt.Rows.Add(dr);
                } // Next j 

            } // Next i 

            this.dgvResult.DataSource = dt;
        } // End Function btnTestAll_Click


    } // End Class 


} // End Namespace 
