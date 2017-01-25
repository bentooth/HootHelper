using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Management.Automation.Runspaces;

namespace RandomGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void saveTo_Click(object sender, EventArgs e)
        {
            //Getting save location.
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            Variables.Path = openFileDialog1.FileName;
            fileLocation.Text = openFileDialog1.FileName;

            Variables.LineCount = File.ReadLines(Variables.Path).Count();
            generateMax.Text = Variables.LineCount.ToString(CultureInfo.InvariantCulture);
        }

        private void generate_Click(object sender, EventArgs e) {

            if (filename.Text == "")
            {
                MessageBox.Show(@"Please enter a file name.");
                return;
            }

            //Setting up a runspace & pipeline for Powershell to execute.
            var runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            var pipeline = runspace.CreatePipeline();

            //Setting seed for Randomly generated content.
            var random = new Random();
            var seed = random.Next(Variables.LineCount);

            //This Content.csv is only a temporary file
            var outfile = Variables.Drop + @"\Content.csv";


            // This if statement checks if the random radio button is 
            if (rradio.Checked)
            {
                var scriptText = @"Import-Csv " + Variables.Path + " -Delimiter " + "';'" + " | Get-Random -count " +
                              Variables.Count++ + " -setseed " + seed + " | export-csv " + outfile + " -NoTypeInformation";

                pipeline.Commands.AddScript(scriptText);

            } else if (sradio.Checked) {

                var scriptText = @"Import-Csv " + Variables.Path + " -Delimiter " + "';'" + " | export-csv " + outfile + " -NoTypeInformation";
                pipeline.Commands.AddScript(scriptText);

            } else {
                MessageBox.Show(@"Please select a sequence.");
                return;
            }


            try
            {
                pipeline.Invoke();

                var span = TimeScheduler(Variables.Dtp, Variables.Interval, Variables.Count + 1);

                TimeReplace(span);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Something went wrong! :( Please see that your content file is formatted correctly. ex: 1/1/2013 00:00 ; This is an example ; www.electrictooth.com");
                return;
            }

            runspace.Close();

            MessageBox.Show(@"" + Variables.FileName + ".csv was successfully created!");

        }

        private void generateNum_TextChanged(object sender, EventArgs e) {

            var t = ValidateNumberTb2();

            if (t) {
                Variables.Count = Convert.ToInt32(generateNum.Text);
                Variables.Count = --Variables.Count;
            }
	        
        }

        private void saveTo_Click_1(object sender, EventArgs e) {

            var openFolderDiaglog1 = new FolderBrowserDialog();
            openFolderDiaglog1.ShowDialog();

            Variables.Drop = openFolderDiaglog1.SelectedPath;
            saveLocation.Text = openFolderDiaglog1.SelectedPath;

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e) {

            Variables.Date = dateTimePicker.Value.ToString("M/d/yyyy HH:mm tt");
            Variables.Dtp = dateTimePicker.Value;
            
        }

        public string[] TimeScheduler (DateTime dt, int interval, int count) {

            var lines = new string[count];

            for (var i = 0; i < count; i++) {

                lines[i] = dt.ToString("M/d/yyyy HH:mm tt");
                dt = dt.Add(new TimeSpan(0, interval, 0));
            }

            return lines;
        }

        private static void TimeReplace(string[] schedule) {

            var outfile = Variables.Drop + @"\Content.csv";
            var outfileTemp = Variables.Drop + @"\" + Variables.FileName + ".csv";

            var sW = new StreamWriter(outfileTemp);
            var rL = File.ReadAllLines(outfile);

            var i = 0;

            foreach (var s in rL)
            {

                //Limits the foreach block for Sequential Scheduling
                if (i == schedule.Count()) {
                    break;
                } 

                var newline = s.Replace("1/1/2013 00:00", schedule[i]);
                sW.WriteLine(newline);
                i++;
                
            }

            File.Delete(outfile);
            sW.Close();
        }

        private void timeInterval_TextChanged(object sender, EventArgs e)
        {
            var t = ValidateNumberTb5();
            if (t) {
                Variables.Interval = Convert.ToInt32(timeInterval.Text);
            }
        }

        private bool ValidateNumberTb2()
        {
            var bStatus = true;

            if (generateNum.Text == "")
            {
                errorProvider1.SetError(generateNum, "Please enter the number of content you want to generate");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(generateNum, "");
            }

            try
            {
                int temp = int.Parse(generateNum.Text);
                errorProvider1.SetError(generateNum, "");

                if (temp > 350)
                {
                    errorProvider1.SetError(generateNum, "Yo Capt, that's to many! Must be under 350");
                    MessageBox.Show(@"Yo Capt, that's too many! Must be under 350");
                    bStatus = false;
                }
                else
                {
                    errorProvider1.SetError(generateNum, "");
                }

            }
            catch
            {
                errorProvider1.SetError(generateNum, "Please enter a number");
                bStatus = false;
            }
            return bStatus;
        }


        private bool ValidateNumberTb5()
        {

            var bStatus = true;

            if (timeInterval.Text == "")
            {
                errorProvider1.SetError(timeInterval, "Please enter a vaild interval of time in which you would like to schedule your content!");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(timeInterval, "");
            }

            try
            {
                errorProvider1.SetError(timeInterval, "");

                if (timeInterval.Text == "")
                {
                    errorProvider1.SetError(timeInterval, "Please enter a vaild interval of time greater than 1!");
                    bStatus = false;
                }
                else
                {
                    errorProvider1.SetError(timeInterval, "");
                }

            }
            catch
            {
                errorProvider1.SetError(timeInterval, "Please enter a vaild interval of time!");
                bStatus = false;
            }
            return bStatus;
        }

        private bool ValidateFileName()
        {
            var bStatus = true;

            if (filename.Text == "")
            {
                errorProvider1.SetError(filename, "Please enter a file name!");
                MessageBox.Show(@"Please enter a file name!");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(filename, "");
            }

            return bStatus;
        }


        private void filename_TextChanged(object sender, EventArgs e)
        {

            var t = ValidateFileName();
            if (t)
            {
                Variables.FileName = filename.Text;
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rradio_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void fileLocation_TextChanged(object sender, EventArgs e)
        {

        }
        private void saveLocation_TextChanged(object sender, EventArgs e)
        {

        }
        private void generateMax_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
