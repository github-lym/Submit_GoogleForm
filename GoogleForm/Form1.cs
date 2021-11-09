using IniFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleForm
{
    public partial class Form1 : Form
    {
        static string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        IniFile ini = new IniFile(Path.Combine(assemblyPath, "settings.ini"));
        string url = "https://docs.google.com/forms/d/e/1FAIpQLSeI1A97JjEdiGwgXrMLpM-VeYpgYDnD0TGZakz9EYu8SZGh_A/formResponse";
        public Form1()
        {
            InitializeComponent();
            string name = ini.ReadString("option", "username");
            TextBox_Username.Text = name.Trim();
            DateTimePicker.Text = DateTime.Now.ToShortTimeString();
            RichTextBox_Result.Text = string.Empty;
            CheckedListBox_Symptom.SetItemChecked(0, true);
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            RichTextBox_Result.Text = string.Empty;

            string dept = ini.ReadString("option", "dept");
            DateTime dt = DateTimePicker.Value;

            string place = string.Empty;
            if (RadioButton_Place_False.Checked)
                place = "無";
            else
                place = "有";

            string person = string.Empty;
            if (RadioButton_Person_False.Checked)
                person = "無";
            else
                person = "有";

            //var fields = new Dictionary<string, string>
            //{
            //    {"entry.1676736489_year",$"{dt.Year}"},
            //    {"entry.1676736489_month",$"{dt.Month}"},
            //    {"entry.1676736489_day",$"{dt.Day}"},
            //    {"entry.825579087",dept},
            //    {"entry.459349779",TextBox_Username.Text.Trim()},
            //    {"entry.181475719",NumericUpDown_Temperature.Value.ToString()},
            //    {"entry.80909422",place},
            //    {"entry.712339993",person},
            //    //{"entry.449155430","皆無"},
            //};
            //if (!string.IsNullOrWhiteSpace(RichTextBox_Memo.Text.Trim()))
            //    fields.Add("entry.1443228459", RichTextBox_Memo.Text.Trim());


            //var response = await client.PostAsync(url, content);

            // Use the StatusCode and Response Content

            var submissionService = new GoogleFormsSubmissionService(url);
            //submissionService.SetFieldValues(fields);
            submissionService.SetCheckboxValues("entry.1676736489_year", $"{dt.Year}");
            submissionService.SetCheckboxValues("entry.1676736489_month", $"{dt.Month}");
            submissionService.SetCheckboxValues("entry.1676736489_day", $"{dt.Day}");
            submissionService.SetCheckboxValues("entry.825579087", dept);
            submissionService.SetCheckboxValues("entry.459349779", TextBox_Username.Text.Trim());
            submissionService.SetCheckboxValues("entry.181475719", NumericUpDown_Temperature.Value.ToString());
            submissionService.SetCheckboxValues("entry.80909422", place);
            submissionService.SetCheckboxValues("entry.712339993", person);
            if (!string.IsNullOrWhiteSpace(RichTextBox_Memo.Text.Trim()))
                submissionService.SetCheckboxValues("entry.1443228459", RichTextBox_Memo.Text.Trim());

            var list = CheckedListBox_Symptom.CheckedItems;
            if (list.Count == 1)
                submissionService.SetCheckboxValues("entry.449155430", list[0].ToString());
            else if (list.Count > 1)
            {
                string[] s = new string[list.Count];
                list.CopyTo(s, 0);
                submissionService.SetCheckboxValues("entry.449155430", s);
            }
            //foreach (var item in list)
            //{
            //    bodyValues.Add("entry.449155430", item.ToString());
            //}
            //submissionService.SetCheckboxValues("entry.44444", "One fish", "Two fish");     //Multiple checkbox values
            //submissionService.SetCheckboxValues("entry.55555", "There can be only one");    //Single checkbox value

            var response = await submissionService.SubmitAsync();
            RichTextBox_Result.Text = $"Status : {(int)response.StatusCode} {response.StatusCode.ToString()}";
            RichTextBox_Result.Text += "\n若出現 200 OK以外的訊息，\n請還是乖乖開表單網頁填寫";

            //await ExecuteGoogleFormsSubmitAsync();
        }

        //private async Task ExecuteGoogleFormsSubmitAsync()
        //{
        //    // Init HttpClient to send the request
        //    HttpClient client = new HttpClient();

        //    // Build the Field Ids and Answers dictionary object
        //    // (replace with your Google Form Ids and Answers)
        //    string dept = iniManager.ReadIniFile("option", "dept", "應用服務部");
        //    DateTime dt = DateTimePicker.Value;

        //    string place = string.Empty;
        //    if (RadioButton_Place_False.Checked)
        //        place = "無";
        //    else
        //        place = "有";

        //    string person = string.Empty;
        //    if (RadioButton_Person_False.Checked)
        //        person = "無";
        //    else
        //        person = "有";

        //    var bodyValues = new Dictionary<string, string>
        //    {
        //        {"entry.1676736489_year",$"{dt.Year}"},
        //        {"entry.1676736489_month",$"{dt.Month}"},
        //        {"entry.1676736489_day",$"{dt.Day}"},
        //        {"entry.825579087",dept},
        //        {"entry.459349779",TextBox_Username.Text.Trim()},
        //        {"entry.181475719",NumericUpDown_Temperature.Value.ToString()},
        //        {"entry.80909422",place},
        //        {"entry.712339993",person},
        //        {"entry.449155430","皆無"},
        //    };

        //    if (!string.IsNullOrWhiteSpace(RichTextBox_Memo.Text.Trim()))
        //        bodyValues.Add("entry.1443228459", RichTextBox_Memo.Text.Trim());
        //    //var list = CheckedListBox_Symptom.CheckedItems;
        //    //foreach (var item in list)
        //    //{
        //    //    bodyValues.Add("entry.449155430", item.ToString());
        //    //}

        //    // Encode object to application/x-www-form-urlencoded MIME type
        //    var content = new FormUrlEncodedContent(bodyValues);

        //    // Post the request (replace with your Google Form Link)
        //    //var response = await client.PostAsync(
        //    //    "https://docs.google.com/forms/d/e/" +
        //    //    "1FAIpQLSeI1A97JjEdiGwgXrMLpM-VeYpgYDnD0TGZakz9EYu8SZGh_A" +
        //    //    "/formResponse",
        //    //    content);
        //    string url = iniManager.ReadIniFile("option", "url", "https://docs.google.com/forms/d/e/1FAIpQLSeVW1KUFMXFwnF-uymSaEaO1CWjN3ffwts4dkHDVoOjROOfbg/viewform");
        //    var response = await client.PostAsync(url, content);

        //    // Use the StatusCode and Response Content
        //    RichTextBox_Result.Text = $"Status : {(int)response.StatusCode} {response.StatusCode.ToString()}";
        //    RichTextBox_Result.Text += "\n若出現 200 OK以外的訊息，\n請還是乖乖開表單網頁填寫";
        //    //Console.WriteLine($"Body : \n{await response.Content.ReadAsStringAsync()}");

        //    // Imagination is the limit yo! 😉 
        //}
    }
}
