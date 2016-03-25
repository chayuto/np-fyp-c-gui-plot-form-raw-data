using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FYP_RawData_To_Graph_Ver1._3
{
    public partial class Form1 : Form
    {

        byte[] data = new byte[40]; 
        int x_val, y_val, z_val, adc_val, adc_temp;
        int[,] dataset = new int[1000, 7];
        Stopwatch stopWatch1 = new Stopwatch();
        Encoding unicode = Encoding.Unicode;
        Encoding ascii = Encoding.ASCII;


        int Tickcount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            int countlines;
            DialogResult openResult = openFileDialog.ShowDialog();
            String openFilename = openFileDialog.FileName.ToString();
            
            textBoxLocation.Text = openFilename;

            //After opening the file start format convertion to the format that can be plotted
            
            List<String> data = loadData(openFilename);
            String formattedData = formatData(data);
            //dataTextBox.Text = formattedData;

            //After covertion write it to a file 

            string directoryName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SentinelActive");
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }

            string filename = Path.Combine(directoryName, "converted.txt");

            StreamWriter writer = new StreamWriter(filename);
            writer.Write(formattedData);
            writer.Close();

            StreamReader fileStreamReader = new StreamReader(filename);
            for (countlines = 0; fileStreamReader.Peek() != -1; countlines++)
            {
                listBoxRead.Items.Add(fileStreamReader.ReadLine());
            }
            fileStreamReader.Close();
            textBoxDetected.Text = countlines.ToString();
        }

        private String formatData(List<String> data)
        {
            String formattedData = "";

            if (data[0].Length < 4)
            {
                int counter = 0;
                foreach (String hex in data)
                {
                    formattedData = formattedData + hex + ":";
                    counter = (counter + 1) % 26;

                    if (counter == 0)
                        formattedData = formattedData + ":::\r\n";
                }
            }

            else
            {
                foreach (String line in data)
                {
                    formattedData = formattedData + line + "\r\n";
                }
            }

            return formattedData.Substring(0, formattedData.Length - 2);
        }

        private List<String> loadData(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            String buffer = "";
            List<String> output = new List<String>();

            while ((buffer = reader.ReadLine()) != null)
            {
                if (buffer.Contains('x'))
                    output.AddRange(removeHex(buffer));

                else
                    output.Add(buffer);
            }

            reader.Close();

            return output;
        }

        private List<String> removeHex(string data)
        {
            String[] hexData = data.Split(' ');
            List<String> processedString = new List<String>();

            foreach (String hex in hexData)
            {
                if (hex.Length > 2)
                {
                    String hexString = hex.Substring(2);

                    if (hexString.Length == 1)
                        hexString = "0" + hexString;

                    processedString.Add(hexString.ToUpper());
                }
            }

            return processedString;
        }






        private void buttonPlot_Click(object sender, EventArgs e)
        {
            int ToRead;
            int NOLR;
            int skipper=0;
            int Line;
            string unwanted;
            ToRead = int.Parse(textBoxLinesPlot.Text);
            for (NOLR = 0; NOLR < ToRead; NOLR++)
             {
                string OneLine;
                char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

                //open the converted file
                //converted file location 
                string directoryName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SentinelActive");
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }

                string convertfilelocation = Path.Combine(directoryName, "converted.txt");

                StreamReader fileStreamReader = new StreamReader(convertfilelocation);
                
                //**************Line Skipper**********
               if (skipper != 0)
               {
                    for (Line = 0; Line < NOLR; Line++)
                  {
                      unwanted = fileStreamReader.ReadLine();
                   }
                    
               }

               
                //**************************************

                OneLine = fileStreamReader.ReadLine();
                skipper++;
                String[] Split = OneLine.Split(delimiterChars);
                fileStreamReader.Close();
                

                string filename = Path.Combine(directoryName, "split.txt");
                
                StreamWriter fileStreamWriter = new StreamWriter(filename);
                int B;
                for (B = 0; B < 26; B++)
                {
                    fileStreamWriter.WriteLine(Split[B].ToString());
                }
                fileStreamWriter.Close();

                StreamReader fileReaderForSplit = new StreamReader(filename);
                int A;
                for (A = 0; fileReaderForSplit.Peek() != -1; A++)
                 {
                     //string str = (fileReaderForSplit.ReadLine());
                     string str = (fileReaderForSplit.ReadLine()).Substring(0, 2);
                     data[A] = Convert.ToByte(str,16);

                }
                fileReaderForSplit.Close();

                textBoxS.Text = "Raw data loaded into int[] data";
                int i = 0;
                for (i = 0; i < 26 ; i++)
                {

                    if ((data[i] == 0x99) && (data[i + 11] == 0x99)) //is attribute for data
                    {
                        DataSetUpdate(data[i + 1], data[i + 2], data[i + 3], data[i + 4], data[i + 5], data[i + 6], data[i + 7], data[i + 8], data[i + 9], data[i + 10]);
                        textBoxS.Text = "Data send to graph";


                    }
                }

                
            }//End of for loop


        }

        private void DataSetUpdate(byte x1, byte x0, byte y1, byte y0, byte z1, byte z0, byte adc1, byte adc0, byte adc_temp1, byte adc_temp0)
        {

            //Convert X 
            if (x0 > 127)
            {
                x_val = 255;
                x_val = x_val << 8;
                x_val = x_val + 255;
                x_val = x_val << 8;
            }
            else { x_val = 0; }
            x_val = x_val + x0;
            x_val = x_val << 8;
            x_val = x_val + x1;

            //convert Y
            if (y0 > 127)
            {
                y_val = 255;
                y_val = y_val << 8;
                y_val = y_val + 255;
                y_val = y_val << 8;
            }
            else { y_val = 0; }
            y_val = y_val + y0;
            y_val = y_val << 8;
            y_val = y_val + y1;

            //convert Z
            if (z0 > 127)
            {
                z_val = 255;
                z_val = z_val << 8;
                z_val = z_val + 255;
                z_val = z_val << 8;
            }
            else { z_val = 0; }
            z_val = z_val + z0;
            z_val = z_val << 8;
            z_val = z_val + z1;

            // convert adc
            if (adc0 > 127)
            {
                adc_val = 255;
                adc_val = adc_val << 8;
                adc_val = adc_val + 255;
                adc_val = adc_val << 8;
                adc_val = adc_val + 255;
                adc_val = adc_val << 8;
            }
            else { adc_val = 0; }

            adc_val = adc_val + adc0;
            adc_val = adc_val << 4;
            adc_val = adc_val + (adc1 >> 4);//Remove insignificant 4 LSB then asign
            if (PPGinvertcheckBox.Checked)
            {
                adc_val = 3000 - adc_val;
            }

            // convert adc_temp
            if (adc_temp0 > 127)
            {
                adc_temp = 255;
                adc_temp = adc_temp << 8;
                adc_temp = adc_temp + 255;
                adc_temp = adc_temp << 8;
                adc_temp = adc_temp + 255;
                adc_temp = adc_temp << 8;
            }
            else { adc_temp = 0; }

            adc_temp = adc_temp + adc_temp0;
            adc_temp = adc_temp << 4;
            adc_temp = adc_temp + (adc_temp1 >> 4);//Remove insignificant 4 LSB then asign

            if (adc_temp > 2030)
            {
                TempLabel.Text = "<27 'C";
            }
            else
            {

                TempLabel.Text = calculate_temp(adc_temp).ToString() + "C";
            }


            //update raw data labels
            xLabel.Text = x_val.ToString();
            yLabel.Text = y_val.ToString();
            zLabel.Text = z_val.ToString();
            RawDataLabel.Text = adc_val.ToString();//(fltMag / 256f).ToString();
            RawDataLabel2.Text = adc_temp.ToString();//(fltMag / 256f).ToString();




            //Plot Graph

            GraphpictureBox.Refresh();

        }

       
        private void Detect_Peak()
        {
            int start_pt = 40;
            int after = 25;
            int before = 17;
            int peak = 1;
            int i = 0; // counter 

            for (i = 1; (i <= after) && (peak == 1); i++)
            {
                if (dataset[start_pt, 4] > dataset[(start_pt - i), 4])
                {
                    peak = 0;
                }

            }
            for (i = 1; (i <= before) && (peak == 1); i++)
            {
                if (dataset[start_pt, 4] >= dataset[start_pt + i, 4])
                {
                    peak = 0;
                }

            }
            if (peak == 1)
            {
                dataset[40, 5] = peak;
                calculate_HR();
            }

        }
        private void calculate_HR()
        {
            int HR;
            float period;


            if (Tickcount == 0)
            {
                stopWatch1.Start();
                Tickcount++;
            }


            else if (Tickcount == 3)
            {


                stopWatch1.Stop();

                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch1.Elapsed;
                //restart stopwatch for next interavl
                stopWatch1.Reset();
                stopWatch1.Start();


                period = ((float)ts.TotalMilliseconds / 1000.0f) / 3.0f;
                HR = (int)((1.0f / period) * 60.0f);
                if ((HR > 60) && (HR < 200))
                {
                    HRlabel.Text = "HR: " + HR.ToString(); // Display HR

                    if (HR < 70)
                    {
                        EventListBox.Items.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff tt") + " -- Bradycardia");
                        if (AlertcheckBox.Checked) { MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff tt") + "\nBradycardia Detected", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    }
                    if (HR > 110)
                    {
                        EventListBox.Items.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff tt") + " -- Tachycardia");
                        if (AlertcheckBox.Checked) { MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff tt") + "\nTachycardia Detected", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    }
                }

                Tickcount = 1;

            }
            else
            {
                Tickcount++;
            }
        }
        float calculate_temp(int tempadc)
        {
            float temp = 40.0f - (0.00623f) * tempadc;

            return temp;
        }

        private float Calculate_Acc_Mag()
        {
            float fltX, fltY, fltZ, fltMag;

            fltX = (float)x_val;
            fltY = (float)y_val;
            fltZ = (float)z_val;
            fltMag = (float)Math.Sqrt((fltX * fltX) + (fltY * fltY) + (fltZ * fltZ));

            MagLabel.Text = (fltMag / 256f).ToString() + "G";

            return fltMag;
        }

        private void GraphpictureBox_Paint(object sender, PaintEventArgs e)
        {
             
            int i, j;

            int pw = GraphpictureBox.Size.Width;
            int ph = GraphpictureBox.Size.Height;
            int w = GraphpictureBox.Size.Width / 2;
            int h = GraphpictureBox.Size.Height / 2;
            Graphics objGraphics = this.GraphpictureBox.CreateGraphics();
            Pen pen = new Pen(Color.DarkGray);
            //changing scale of graph
            int scaleFactor = int.Parse(ScaledomainUpDown.Text);


            for (i = -10; i <= 10; i++)
            {
                e.Graphics.DrawLine(pen, 0, ph - ((256 * i) / scaleFactor) - h, pw, ph - ((256 * i) / scaleFactor) - h);
            }


            //datashift

            for (i = 0; i <= 6; i++)
            {
                for (j = pw; j >= 1; j--)
                {
                    dataset[j, i] = dataset[j - 1, i];
                }
            }


            //load new values into array
            dataset[0, 0] = ph - (x_val / scaleFactor) - h;
            dataset[0, 1] = ph - (y_val / scaleFactor) - h;
            dataset[0, 2] = ph - (z_val / scaleFactor) - h;
            dataset[0, 3] = ph - (int)(Calculate_Acc_Mag() / scaleFactor) - h;
            dataset[0, 4] = ph - (int)((float)(adc_val * ph) / 9000.0) - h;
            dataset[0, 6] = ph - (int)((float)(adc_temp * ph) / 9000.0) - h;
            Detect_Peak(); //determine change too dataset[40,5]

            for (i = 6; i >= 0; i--)
            {
                //plot peak
                if (i == 5)
                {
                    pen.Color = Color.Purple;
                    for (j = pw; j >= 1; j--)
                    {
                        if (dataset[j, i] == 1)
                        {
                            e.Graphics.DrawLine(pen, j, 0, j, ph);
                        }
                    }
                }


                //change colour for each axis
                else if (i == 0) { pen.Color = Color.Red; }
                else if (i == 1) { pen.Color = Color.Blue; }
                else if (i == 2) { pen.Color = Color.Green; }
                else if (i == 3) { pen.Color = Color.Wheat; }
                else if (i == 4) { pen.Color = Color.Orange; }
                else if (i == 6) { pen.Color = Color.Aqua; }
                //plot each axis
                for (j = pw; j >= 1; j--)
                {
                    e.Graphics.DrawLine(pen, j, dataset[j, i], j - 1, dataset[j - 1, i]);
                }


            }
        }


        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }








    }
}
