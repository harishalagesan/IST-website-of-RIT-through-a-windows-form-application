using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTUtil;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Diagnostics;


namespace Client_3
{
    public partial class Form1 : Form
    {

        Rest rj = new Rest("http://ist.rit.edu/api");
        Rest rjGoogle = new Rest("http://info.google.com/api");
        Employment emp;
        COOP coopres;


        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            Mapofstudents.Navigate("http://ist.rit.edu/api/map/"); // Include the map of where our students work using a web browser
           
            Load();
        }

        private void Load() 
        {
            // Create the Main Page for better User experience 
            Rit_Name.Text = "Information Science And Technologies @ RIT";
            Rit_Name1.Text = "Information Science And Technologies @ RIT";
            Rit_Name_Minors.Text = "Information Science And Technologies @ RIT";
            Rit_Name_Employment.Text = "Information Science And Technologies @ RIT";

            link1.Text = "R.I.T";                                       // Links provided to reroute to RIT homepage
            link2.Text = "Rochester Institute Of Technology";

            // get About information
            string jsonAbout = getRestData("/about/");

            // need a way to get the JSON form into an About object
            About about = JToken.Parse(jsonAbout).ToObject<About>();

            // start displaying the About object information on the screen
            aboutTitle.Text = about.title;
            aboutDescription.Text = about.description;
            aboutQuote.Text = about.quote;
            aboutQuoteAuthor.Text = about.quoteAuthor;

            // get Degree Under Graduate information
            string jsonUDegrees1 = getRestData("/degrees/undergraduate/degreeName=wmc/");

            // need a way to get the JSON form into an Degree object
            Degree1 Udegrees1 = JToken.Parse(jsonUDegrees1).ToObject<Degree1>();

            // start displaying the Ungergraduatedegree object information on the screen

            ug1.Text = Udegrees1.title;
            ug1_1.Text = Udegrees1.description;

            // get Degree Under Graduate information
            string jsonUDegrees2 = getRestData("/degrees/undergraduate/degreeName=hcc/");

            // need a way to get the JSON form into an Degree object
            Degree2 Udegrees2 = JToken.Parse(jsonUDegrees2).ToObject<Degree2>();

            // start displaying the Ungergraduatedegree object information on the screen


            ug2.Text = Udegrees2.title;
            ug2_1.Text = Udegrees2.description;

            // get Degree Under Graduate information
            string jsonUDegrees3 = getRestData("/degrees/undergraduate/degreeName=cit/");

            // need a way to get the JSON form into an Degree object
            Degree3 Udegrees3 = JToken.Parse(jsonUDegrees3).ToObject<Degree3>();

            // start displaying the Ungergraduatedegree object information on the screen


            ug3.Text = Udegrees3.title;
            ug3_1.Text = Udegrees3.description;

            /*Graduate Students data*/

            // get Degree Under Graduate information
            string jsonGDegrees1 = getRestData("/degrees/graduate/degreeName=ist/");

            // need a way to get the JSON form into an Degree object
            gDegree1 Gdegrees1 = JToken.Parse(jsonGDegrees1).ToObject<gDegree1>();

            // start displaying the Ungergraduatedegree object information on the screen

            g1.Text = Gdegrees1.title;
            g1_1.Text = Gdegrees1.description;

            // get Degree Under Graduate information
            string jsonGDegrees2 = getRestData("/degrees/graduate/degreeName=hci/");

            // need a way to get the JSON form into an Degree object
            gDegree2 Gdegrees2 = JToken.Parse(jsonGDegrees2).ToObject<gDegree2>();

            // start displaying the Ungergraduatedegree object information on the screen

            g2.Text = Gdegrees2.title;
            g2_1.Text = Gdegrees2.description;

            // get Degree Under Graduate information
            string jsonGDegrees3 = getRestData("/degrees/graduate/degreeName=nsa/");

            // need a way to get the JSON form into an Degree object
            gDegree3 Gdegrees3 = JToken.Parse(jsonGDegrees3).ToObject<gDegree3>();

            // start displaying the Ungergraduatedegree object information on the screen


            g3.Text = Gdegrees3.title;
            g3_1.Text = Gdegrees3.description;

            //Display Graduate advanced certificates details on the screen

            grad_adv_1.Text = "Web Development Advanced certificate";
            grad_adv_2.Text = "Networking,Planning and Design Advanced Cerificate";

            empintrotitle.Text = "Academic excellence equals career performance";



            //Employment Details


            // get Employment information
            string jsonemployintro1 = getRestData("/employment/introduction/content/title=Employment");

            // need a way to get the JSON form into an Employintro object
            Content Eintro1 = JToken.Parse(jsonemployintro1).ToObject<Content>();

            //Start displaying the Employment information on Screen

            empintrocontenttitle.Text = Eintro1.title;
            empintrocontentdesc.Text = Eintro1.description;


            // get Employment information
            string jsonemployintro2 = getRestData("/employment/introduction/content/title=Cooperative Education");

            // need a way to get the JSON form into an Employintro object
            Content Eintro2 = JToken.Parse(jsonemployintro2).ToObject<Content>();

            //Start displaying the Employment information on Screen

            empintrocoopttitle.Text = Eintro2.title;
            empintrocoopdesc.Text = Eintro2.description;

            //Degree Statistics box1 display

            string jsondegstat1button = getRestData("/employment/degreeStatistics/statistics/value=$80,000");

            // need a way to get the JSON form into an Employintro object
            Statistic degstatistic1 = JToken.Parse(jsondegstat1button).ToObject<Statistic>();

            //Start displaying the Employment information on Screen

            degstat1.Text = degstatistic1.value + Environment.NewLine + degstatistic1.description;


            //Degree Statistics box2 display

            string jsondegstat2button = getRestData("/employment/degreeStatistics/statistics/value=36th");

            // need a way to get the JSON form into an Employintro object
            Statistic degstatistic2 = JToken.Parse(jsondegstat2button).ToObject<Statistic>();

            //Start displaying the Employment information on Screen

            degstat2.Text = degstatistic2.value + Environment.NewLine + degstatistic2.description;

            //Degree Statistics box2 display

            string jsondegstat3button = getRestData("/employment/degreeStatistics/statistics/value=35");

            // need a way to get the JSON form into an Employintro object
            Statistic degstatistic3 = JToken.Parse(jsondegstat3button).ToObject<Statistic>();

            //Start displaying the Employment information on Screen

            degstat3.Text = degstatistic3.value + Environment.NewLine + degstatistic3.description;

            //Degree Statistics box2 display

            string jsondegstat4button = getRestData("/employment/degreeStatistics/statistics/value=1.11 Billion GB");

            // need a way to get the JSON form into an Employintro object
            Statistic degstatistic4 = JToken.Parse(jsondegstat4button).ToObject<Statistic>();

            //Start displaying the Employment information on Screen

            degstat4.Text = degstatistic4.value + Environment.NewLine + degstatistic4.description;


            //Employer display

            string jsonemployerdet = getRestData("/employment/employers/title=Employers");

            // need a way to get the JSON form into an Employintro object
            emp empdet = JToken.Parse(jsonemployerdet).ToObject<emp>();
            Employer empdet1 = JToken.Parse(jsonemployerdet).ToObject<Employer>();

            //Start displaying the Employment information on Screen

            employer_title.Text = "Employers";
            coop_title.Text = "Carers";
            employer_details.Text = "Rochester Software Associates" + "|" + "Podio" + "|" + "MG Lomb Advertising Inc" + "|" + "Credit Suisse" + "|" + "T-Mark International" + "|" + "Labor International Local 435";
            coop_details.Text = "Applications Programmer II" + "|" + "Positive Experience Architect" + "|" + "Project Lead" + "|" + "IT Engineer" + "|" + "Malware / Chat Online Support" + "|" + "Web Developer/Programmer";


            //Research Areas of Interest

            string jsonresearch1 = getRestData("/research/byInterestArea/areaName=HCI");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea1 = JToken.Parse(jsonresearch1).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research1.Text = resarea1.areaName;

            string jsonresearch2 = getRestData("/research/byInterestArea/areaName=Education");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea2 = JToken.Parse(jsonresearch2).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research2.Text = resarea2.areaName;

            string jsonresearch3 = getRestData("/research/byInterestArea/areaName=Geo");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea3 = JToken.Parse(jsonresearch3).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research3.Text = resarea3.areaName;

            string jsonresearch4 = getRestData("/research/byInterestArea/areaName=Database");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea4 = JToken.Parse(jsonresearch4).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research4.Text = resarea4.areaName;

            string jsonresearch5 = getRestData("/research/byInterestArea/areaName=Analytics");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea5 = JToken.Parse(jsonresearch5).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research5.Text = resarea5.areaName;

            string jsonresearch6 = getRestData("/research/byInterestArea/areaName=Web");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea6 = JToken.Parse(jsonresearch6).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research6.Text = resarea6.areaName;

            string jsonresearch7 = getRestData("/research/byInterestArea/areaName=Networking");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea7 = JToken.Parse(jsonresearch7).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research7.Text = resarea7.areaName;

            string jsonresearch8 = getRestData("/research/byInterestArea/areaName=Mobile");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea8 = JToken.Parse(jsonresearch8).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research8.Text = resarea8.areaName;

            string jsonresearch9 = getRestData("/research/byInterestArea/areaName=Health Informatics");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea9 = JToken.Parse(jsonresearch9).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research9.Text = resarea9.areaName;

            string jsonresearch10 = getRestData("/research/byInterestArea/areaName=Programming");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea10 = JToken.Parse(jsonresearch10).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research10.Text = resarea10.areaName;

            string jsonresearch11 = getRestData("/research/byInterestArea/areaName=System Administration");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea11 = JToken.Parse(jsonresearch11).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research11.Text = resarea11.areaName;

            string jsonresearch12 = getRestData("/research/byInterestArea/areaName=Ubiquitous Computing");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea12 = JToken.Parse(jsonresearch12).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            research12.Text = resarea12.areaName;

            //COOP table grid populate on load, this populates all the coop data into the gridview

            sw.Reset();
            sw.Start();
            string jsonEmp = rj.getRestData("/employment/");
            emp = JToken.Parse(jsonEmp).ToObject<Employment>();

            for (var i = 0; i < emp.coopTable.coopInformation.Count; i++)
            {
                dataGridView1.Rows.Add();       // 1st row added is row 0
                dataGridView1.Rows[i].Cells[0].Value =
                    emp.coopTable.coopInformation[i].employer;
                dataGridView1.Rows[i].Cells[1].Value =
                    emp.coopTable.coopInformation[i].degree;
                dataGridView1.Rows[i].Cells[2].Value =
                    emp.coopTable.coopInformation[i].city;
                dataGridView1.Rows[i].Cells[3].Value =
                    emp.coopTable.coopInformation[i].term;
            }



            //Employee table grid populate on load, this populates all the employment data into gridview

            for (var i = 0; i < emp.employmentTable.professionalEmploymentInformation.Count; i++)
            {
                emptablegridview.Rows.Add();       // 1st row added is row 0
                emptablegridview.Rows[i].Cells[0].Value =
                    emp.employmentTable.professionalEmploymentInformation[i].employer;
                emptablegridview.Rows[i].Cells[1].Value =
                   emp.employmentTable.professionalEmploymentInformation[i].degree;
                emptablegridview.Rows[i].Cells[2].Value =
                   emp.employmentTable.professionalEmploymentInformation[i].city;
                emptablegridview.Rows[i].Cells[3].Value =
                    emp.employmentTable.professionalEmploymentInformation[i].title;
                emptablegridview.Rows[i].Cells[3].Value =
                    emp.employmentTable.professionalEmploymentInformation[i].startDate;

            }

            //COOP enrollment for current students the title of each button is added here from the api

            string jsoncs1 = rj.getRestData("/resources/");
            COOP cs1data = JToken.Parse(jsoncs1).ToObject<COOP>();
            CoopEnrollment ce = cs1data.coopEnrollment;
            cs1.Text = ce.title;
            StudyAbroad sa = cs1data.studyAbroad;
            cs2.Text = sa.title;
            TutorsAndLabInformation tli = cs1data.tutorsAndLabInformation;
            cs3.Text = tli.title;
            StudentServices sser = cs1data.studentServices;
            cs4.Text = sser.title;
            StudentAmbassadors samb = cs1data.studentAmbassadors;
            cs5.Text = samb.title;
            Forms frm = cs1data.forms;
            cs6.Text = "Forms";

        

            //Adding Faculty name to all buttons in faculty section of People

            people facul;
            string jsonfaculty = getRestData("/people/faculty/");
            facul = JToken.Parse(jsonfaculty).ToObject<people>();
            Button[] facarray = { fac1, fac2, fac3, fac4, fac5, fac6, fac7, fac8, fac9, fac10, fac11, fac12, fac13, fac14, fac15, fac16, fac17, fac18, fac19, fac20, fac21, fac22, fac23, fac24, fac25, fac26, fac27, fac28, fac29, fac30, fac31, fac32, fac33 };
            for (var n = 0; n < facul.faculty.Count; n++)
            {
                facarray[n].Text = facul.faculty[n].name;
                
            }

            // Adding Faculty image by reseach done and populating the text box with their name and research work carried out
            people faculre;
            facres faculresearch;

            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearch = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();


            string jsonfacultyre = getRestData("/people/faculty/");
            faculre = JToken.Parse(jsonfacultyre).ToObject<people>();

            PictureBox[] facarrayre = { pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26 };
            
                for (var n = 0; n < faculresearch.byFaculty.Count; n++)
                 {
                for (var k = 0; k < faculre.faculty.Count; k++)
                {
                if (faculresearch.byFaculty[n].username == faculre.faculty[k].username)
                {
                    facarrayre[n].ImageLocation = faculre.faculty[k].imagePath;
                }
               }
            }

            //Adding Staff name to all buttons in Staff section of People
            staf sta;
            string jsonstaff = getRestData("/people/staff/");
            sta = JToken.Parse(jsonstaff).ToObject<staf>();
            Button[] stafarray = { staff1, staff2,staff3,staff4,staff5,staff6,staff7,staff8,staff9,staff10,staff11,staff12};
            for (var n = 0; n < sta.staff.Count; n++)
            {
                stafarray[n].Text = sta.staff[n].name;
            }


            //Loading the news data from API based on CUrrent year news, News by quarter and News by Month also older news from this year
            string jsonnews = getRestData("/news/");
            News news1 = JToken.Parse(jsonnews).ToObject<News>();
            for (var i = 0; i < news1.year.Count; i++)
            {
                byyeartext.Text += news1.year[i].date + Environment.NewLine + news1.year[i].title + Environment.NewLine + news1.year[i].description + Environment.NewLine + Environment.NewLine;

            }

            for (var i = 0; i < news1.month.Count; i++)
            {
                bymonthtext.Text += news1.month[i].date + Environment.NewLine + news1.month[i].title + Environment.NewLine + news1.month[i].description + Environment.NewLine + Environment.NewLine;

            }

            for (var i = 0; i < news1.quarter.Count; i++)
            {
                byquartertext.Text += news1.quarter[i].date + Environment.NewLine + news1.quarter[i].title + Environment.NewLine + news1.quarter[i].description + Environment.NewLine + Environment.NewLine;

            }

            for (var i = 0; i < news1.older.Count; i++)
            {
                oldertext.Text += news1.older[i].date + Environment.NewLine + news1.older[i].title + Environment.NewLine + news1.older[i].description + Environment.NewLine + Environment.NewLine;

            }

        }



        #region getRestData - Returns the requested API information as a string
        private string getRestData(string url)
        {
            string baseUri = "http://ist.rit.edu/api";

            // connect to the API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUri + url);
            try
            {
                WebResponse response = request.GetResponse();

                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException we)
            {
                // Something goes wrong, get the error response, then do something with it
                WebResponse err = we.Response;
                using (Stream responseStream = err.GetResponseStream())
                {
                    StreamReader r = new StreamReader(responseStream, Encoding.UTF8);
                    string errorText = r.ReadToEnd();
                    // display or log error
                    Console.WriteLine(errorText);
                }
                throw;
            }
        } // end getRestData
        #endregion

        //Rerouting to RIT home page on click of Name in the home screen
        private void Rit_Name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/");

        }
        //Rerouting to RIT home page on click of name in small in the home screen on the side
        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/");
        }

        //Rerouting to RIT home page on click of name in small in the home screen on the side
        private void link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/");
        }

        //Rerouting to respective pages on click
        private void grad_adv_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://rit.edu/programs/web-development-adv-cert");

        }

        //Rerouting to respective pages on click
        private void grad_adv_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://rit.edu/programs/networking-planning-and-design-adv-cert");
        }

        //Creating a search box linked to google search page and displaying results in a web browser at the bottom of the home page
        private void search_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Trim().Length == 0)
            {
                label1.Text = "RIT Search";
                return;
            }
            else
            {
                string harishAlagesan = "http://www.google.com/search?q=" + searchBox.Text;
                webBrowser1.Navigate(harishAlagesan);
            }
        }

        //Undergradute WMC button click
        private void ugClick1_Click(object sender, EventArgs e)
        {
            // get Degree Under Graduate information
            string jsonUDegrees1 = getRestData("/degrees/undergraduate/degreeName=wmc/");

            // need a way to get the JSON form into an Degree object
            Degree1 Udegrees1 = JToken.Parse(jsonUDegrees1).ToObject<Degree1>();

            // start displaying the Ungergraduatedegree object information on the screen



            ugclick1Text.Visible = true;
            ugClick1Text2.Visible = true;
            ugClick1Text3.Visible = true;
            ugclick1Text.Text = Udegrees1.title;
            ugClick1Text2.Text = "Concentrations";
            ugClick1Text3.Text = String.Join(Environment.NewLine, Udegrees1.concentrations);

        }

        //Undergradute HCC button click

        private void ugClick2_Click_1(object sender, EventArgs e)
        {
            // get Degree Under Graduate information
            string jsonUDegrees1 = getRestData("/degrees/undergraduate/degreeName=hcc/");

            // need a way to get the JSON form into an Degree object
            Degree2 Udegrees1 = JToken.Parse(jsonUDegrees1).ToObject<Degree2>();

            // start displaying the Ungergraduatedegree object information on the screen



            ugclick1Text.Visible = true;
            ugClick1Text2.Visible = true;
            ugClick1Text3.Visible = true;
            ugclick1Text.Text = Udegrees1.title;
            ugClick1Text2.Text = "Concentrations";
            ugClick1Text3.Text = String.Join(Environment.NewLine, Udegrees1.concentrations);
        }

        //Undergradute CIT button click

        private void ugClick3_Click(object sender, EventArgs e)
        {
            // get Degree Under Graduate information
            string jsonUDegrees1 = getRestData("/degrees/undergraduate/degreeName=cit/");

            // need a way to get the JSON form into an Degree object
            Degree3 Udegrees1 = JToken.Parse(jsonUDegrees1).ToObject<Degree3>();

            // start displaying the Ungergraduatedegree object information on the screen


            ugclick1Text.Visible = true;
            ugClick1Text2.Visible = true;
            ugClick1Text3.Visible = true;
            ugclick1Text.Text = Udegrees1.title;
            ugClick1Text2.Text = "Concentrations";
            ugClick1Text3.Text = String.Join(Environment.NewLine, Udegrees1.concentrations);
        }

        //Graduate IST button click
        private void g1_Click_Click(object sender, EventArgs e)
        {
            // get Degree Graduate information
            string jsongDegrees1 = getRestData("/degrees/graduate/degreeName=ist/");

            // need a way to get the JSON form into an Degree object
            gDegree1 gdegrees1 = JToken.Parse(jsongDegrees1).ToObject<gDegree1>();

            // start displaying the Ungergraduatedegree object information on the screen


            gclickText1.Visible = true;
            gclickText2.Visible = true;
            gclickText3.Visible = true;
            gclickText1.Text = gdegrees1.title;
            gclickText2.Text = "Concentrations";
            gclickText3.Text = String.Join(Environment.NewLine, gdegrees1.concentrations);

        }

        //Graduate HCI button click
        private void g2_Click_Click(object sender, EventArgs e)
        {
            // get Degree Graduate information
            string jsongDegrees1 = getRestData("/degrees/graduate/degreeName=hci/");

            // need a way to get the JSON form into an Degree object
            gDegree2 gdegrees1 = JToken.Parse(jsongDegrees1).ToObject<gDegree2>();

            // start displaying the Ungergraduatedegree object information on the screen


            gclickText1.Visible = true;
            gclickText2.Visible = true;
            gclickText3.Visible = true;
            gclickText1.Text = gdegrees1.title;
            gclickText2.Text = "Concentrations";
            gclickText3.Text = String.Join(Environment.NewLine, gdegrees1.concentrations);
        }

        //Graduate NSA button click
        private void g3_Click_Click(object sender, EventArgs e)
        {
            // get Degree Graduate information
            string jsongDegrees1 = getRestData("/degrees/graduate/degreeName=nsa/");

            // need a way to get the JSON form into an Degree object
            gDegree3 gdegrees1 = JToken.Parse(jsongDegrees1).ToObject<gDegree3>();

            // start displaying the Ungergraduatedegree object information on the screen


            gclickText1.Visible = true;
            gclickText2.Visible = true;
            gclickText3.Visible = true;
            gclickText1.Text = gdegrees1.title;
            gclickText2.Text = "Concentrations";
            gclickText3.Text = String.Join(Environment.NewLine, gdegrees1.concentrations);
        }

        //Minors DBDDI button click
        private void minor1_Click(object sender, EventArgs e)
        {
            // get Minor information
            string jsonminor = getRestData("/minors/UgMinors/name=DBDDI-MN/");

            // need a way to get the JSON form into an Minor object
            Minor1 minor = JToken.Parse(jsonminor).ToObject<Minor1>();

            // start displaying the Minor object information on the screen

            minorTitle.Visible = true;
            minorDesc.Visible = true;

            minorTitle.Text = minor.title;
            minorDesc.Text = minor.description;

        }

        //Minors GIS button click
        private void minor2_Click(object sender, EventArgs e)
        {
            // get Minor information
            string jsonminor = getRestData("/minors/UgMinors/name=GIS-MN/");

            // need a way to get the JSON form into an Minor object
            Minor2 minor = JToken.Parse(jsonminor).ToObject<Minor2>();

            // start displaying the Minor object information on the screen

            minorTitle.Visible = true;
            minorDesc.Visible = true;

            minorTitle.Text = minor.title;
            minorDesc.Text = minor.description;
        }

        //Minors MDDEV button click
        private void minor3_Click(object sender, EventArgs e)
        {
            // get Minor information
            string jsonminor = getRestData("/minors/UgMinors/name=MEDINFO-MN/");

            // need a way to get the JSON form into an Minor object
            Minor3 minor = JToken.Parse(jsonminor).ToObject<Minor3>();

            // start displaying the Minor object information on the screen

            minorTitle.Visible = true;
            minorDesc.Visible = true;

            minorTitle.Text = minor.title;
            minorDesc.Text = minor.description;
        }

        //Minors MDDEV button click
        private void minor4_Click(object sender, EventArgs e)
        {
            // get Minor information
            string jsonminor = getRestData("/minors/UgMinors/name=MDDEV-MN/");

            // need a way to get the JSON form into an Minor object
            Minor4 minor = JToken.Parse(jsonminor).ToObject<Minor4>();

            // start displaying the Minor object information on the screen

            minorTitle.Visible = true;
            minorDesc.Visible = true;

            minorTitle.Text = minor.title;
            minorDesc.Text = minor.description;

        }

        //Minors MDDEV button click
        private void minor5_Click(object sender, EventArgs e)
        {
            // get Minor information
            string jsonminor = getRestData("/minors/UgMinors/name=MDEV-MN/");

            // need a way to get the JSON form into an Minor object
            Minor5 minor = JToken.Parse(jsonminor).ToObject<Minor5>();

            // start displaying the Minor object information on the screen

            minorTitle.Visible = true;
            minorDesc.Visible = true;

            minorTitle.Text = minor.title;
            minorDesc.Text = minor.description;
        }

        //Minors NETSYS button click
        private void minor6_Click(object sender, EventArgs e)
        {
            // get Minor information
            string jsonminor = getRestData("/minors/UgMinors/name=NETSYS-MN/");

            // need a way to get the JSON form into an Minor object
            Minor6 minor = JToken.Parse(jsonminor).ToObject<Minor6>();

            // start displaying the Minor object information on the screen

            minorTitle.Visible = true;
            minorDesc.Visible = true;

            minorTitle.Text = minor.title;
            minorDesc.Text = minor.description;
        }

        //Minors WEBDD button click
        private void minor7_Click(object sender, EventArgs e)
        {
            // get Minor information
            string jsonminor = getRestData("/minors/UgMinors/name=WEBDD-MN/");

            // need a way to get the JSON form into an Minor object
            Minor7 minor = JToken.Parse(jsonminor).ToObject<Minor7>();

            // start displaying the Minor object information on the screen

            minorTitle.Visible = true;
            minorDesc.Visible = true;

            minorTitle.Text = minor.title;
            minorDesc.Text = minor.description;
        }

        //Minors WEBD button click
        private void minor8_Click(object sender, EventArgs e)
        {
            // get Minor information
            string jsonminor = getRestData("/minors/UgMinors/name=WEBD-MN/");

            // need a way to get the JSON form into an Minor object
            Minor8 minor = JToken.Parse(jsonminor).ToObject<Minor8>();

            // start displaying the Minor object information on the screen

            minorTitle.Visible = true;
            minorDesc.Visible = true;

            minorTitle.Text = minor.title;
            minorDesc.Text = minor.description;
        }

        //Research Areas of Interest  creation of button click activities  based on each research item 

        //Area of research HCI
        private void research1_Click(object sender, EventArgs e)
        {

            string jsonresearch1 = getRestData("/research/byInterestArea/areaName=HCI");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea1 = JToken.Parse(jsonresearch1).ToObject<researcharea>();
            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea1.citations);
            facres.Visible = false;
            facresclick.Visible = false;

        }

        //Area of research Education
        private void research2_Click(object sender, EventArgs e)
        {
            string jsonresearch2 = getRestData("/research/byInterestArea/areaName=Education");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea2 = JToken.Parse(jsonresearch2).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea2.citations);
            facres.Visible = false;
            facresclick.Visible = false;

        }

        //Area of research GEO
        private void research3_Click(object sender, EventArgs e)
        {
            string jsonresearch3 = getRestData("/research/byInterestArea/areaName=Geo");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea3 = JToken.Parse(jsonresearch3).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea3.citations);
            facres.Visible = false;
            facresclick.Visible = false;
        }

        //Area of research Database
        private void research4_Click(object sender, EventArgs e)
        {
            string jsonresearch4 = getRestData("/research/byInterestArea/areaName=Database");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea4 = JToken.Parse(jsonresearch4).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea4.citations);
            facres.Visible = false;
            facresclick.Visible = false;
        }

        //Area of research Analytics
        private void research5_Click(object sender, EventArgs e)
        {
            string jsonresearch5 = getRestData("/research/byInterestArea/areaName=Analytics");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea5 = JToken.Parse(jsonresearch5).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea5.citations);
            facres.Visible = false;
            facresclick.Visible = false;
        }

        //Area of research Web
        private void research6_Click(object sender, EventArgs e)
        {
            string jsonresearch6 = getRestData("/research/byInterestArea/areaName=Web");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea6 = JToken.Parse(jsonresearch6).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea6.citations);
            facres.Visible = false;
            facresclick.Visible = false;

        }

        //Area of research Networking
        private void research7_Click(object sender, EventArgs e)
        {
            string jsonresearch7 = getRestData("/research/byInterestArea/areaName=Networking");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea7 = JToken.Parse(jsonresearch7).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea7.citations);
            facres.Visible = false;
            facresclick.Visible = false;
        }

        //Area of research Mobile
        private void research8_Click(object sender, EventArgs e)
        {
            string jsonresearch8 = getRestData("/research/byInterestArea/areaName=Mobile");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea8 = JToken.Parse(jsonresearch8).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea8.citations);
            facres.Visible = false;
            facresclick.Visible = false;
        }

        //Area of research Health Informatics
        private void research9_Click(object sender, EventArgs e)
        {
            string jsonresearch9 = getRestData("/research/byInterestArea/areaName=Health Informatics");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea9 = JToken.Parse(jsonresearch9).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea9.citations);
            facres.Visible = false;
            facresclick.Visible = false;
        }

        //Area of research Programming
        private void research10_Click(object sender, EventArgs e)
        {
            string jsonresearch10 = getRestData("/research/byInterestArea/areaName=Programming");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea10 = JToken.Parse(jsonresearch10).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea10.citations);
            facres.Visible = false;
            facresclick.Visible = false;
        }

        //Area of research System Administration
        private void research11_Click(object sender, EventArgs e)
        {
            string jsonresearch11 = getRestData("/research/byInterestArea/areaName=System Administration");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea11 = JToken.Parse(jsonresearch11).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea11.citations);
            facres.Visible = false;
            facresclick.Visible = false;
        }

        //Area of research Ubiquitous Computing
        private void research12_Click(object sender, EventArgs e)
        {
            string jsonresearch12 = getRestData("/research/byInterestArea/areaName=Ubiquitous Computing");

            // need a way to get the JSON form into an Employintro object
            researcharea resarea12 = JToken.Parse(jsonresearch12).ToObject<researcharea>();

            //Start displaying the Employment information on Screen
            researchtext.Text = string.Join(Environment.NewLine, resarea12.citations);
            facres.Visible = false;
            facresclick.Visible = false;
        }

        //Making the Employment table and COOP table visible on click since by default visible propert of these tables are set to false
        private void employeetableclick_Click(object sender, EventArgs e)
        {
            emptablegridview.Visible = true;
        }

        private void showDataGrid_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

        }

        // Creating and populating student resources section 

        //Resources retreived and displayed for coopEnrollment
        private void cs1_Click(object sender, EventArgs e)
        {
            resources_text.Visible = true;
            resources_text.Clear();
            string jsoncs1 = getRestData("/resources/");
            coopres = JToken.Parse(jsoncs1).ToObject<COOP>();

            for (var i = 0; i < coopres.coopEnrollment.enrollmentInformationContent.Count; i++)
            {
                resources_text.Text += coopres.coopEnrollment.enrollmentInformationContent[i].title + Environment.NewLine + coopres.coopEnrollment.enrollmentInformationContent[i].description + Environment.NewLine + Environment.NewLine;

            }
        }

        //Resources retreived and displayed for studyAbroad
        private void cs2_Click(object sender, EventArgs e)
        {
            resources_text.Visible = true;
            resources_text.Clear();
            string jsoncs1 = getRestData("/resources/");
            coopres = JToken.Parse(jsoncs1).ToObject<COOP>();
        
            resources_text.Text = coopres.studyAbroad.title + Environment.NewLine + coopres.studyAbroad.description + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            for (var i = 0; i < coopres.studyAbroad.places.Count; i++)
            {
                resources_text.Text += coopres.studyAbroad.places[i].nameOfPlace + Environment.NewLine + coopres.studyAbroad.places[i].description + Environment.NewLine + Environment.NewLine;

            }
        }

        //Resources retreived and displayed for Tutors and Lab Information
        private void cs3_Click(object sender, EventArgs e)
        {
            resources_text.Visible = true;
            resources_text.Clear();
            string jsoncs1 = getRestData("/resources/");
            coopres = JToken.Parse(jsoncs1).ToObject<COOP>();
            
            resources_text.Text = coopres.tutorsAndLabInformation.title + Environment.NewLine + coopres.tutorsAndLabInformation.description;

        }

        //Resources retreived and displayed for All Advisers
        private void cs4_Click(object sender, EventArgs e)
        {
            resources_text.Visible = true;
            resources_text.Clear();
            string jsoncs1 = getRestData("/resources/");
            coopres = JToken.Parse(jsoncs1).ToObject<COOP>();
            resources_text.Text = coopres.studentServices.title + Environment.NewLine;
            resources_text.Text += coopres.studentServices.academicAdvisors.title + Environment.NewLine + coopres.studentServices.academicAdvisors.description + Environment.NewLine;
            resources_text.Text += coopres.studentServices.academicAdvisors.faq.title + Environment.NewLine + coopres.studentServices.academicAdvisors.faq.contentHref;
            resources_text.Text += coopres.studentServices.facultyAdvisors.title + Environment.NewLine + coopres.studentServices.facultyAdvisors.description + Environment.NewLine;
            resources_text.Text += coopres.studentServices.istMinorAdvising.title + Environment.NewLine;
            for (var i = 0; i < coopres.studentServices.istMinorAdvising.minorAdvisorInformation.Count; i++)
            {
                resources_text.Text += coopres.studentServices.istMinorAdvising.minorAdvisorInformation[i].title + Environment.NewLine + coopres.studentServices.istMinorAdvising.minorAdvisorInformation[i].advisor + Environment.NewLine + coopres.studentServices.istMinorAdvising.minorAdvisorInformation[i].email + Environment.NewLine + Environment.NewLine;
            }

        }

        //Resources retreived and displayed for Student Ambassadors
        private void cs5_Click(object sender, EventArgs e)
        {
            resources_text.Visible = true;
            resources_text.Clear();
            string jsoncs1 = getRestData("/resources/");
            coopres = JToken.Parse(jsoncs1).ToObject<COOP>();
            resources_text.Text = coopres.studentAmbassadors.title + Environment.NewLine;
            resources_text.Text += coopres.studentAmbassadors.ambassadorsImageSource + Environment.NewLine;
            for (var i = 0; i < coopres.studentAmbassadors.subSectionContent.Count; i++)
            {
                resources_text.Text += coopres.studentAmbassadors.subSectionContent[i].title + Environment.NewLine + coopres.studentAmbassadors.subSectionContent[i].description + Environment.NewLine + Environment.NewLine;
            }
        }

        //Resources retreived and displayed for Graduate and Undergraduate Forms
        private void cs6_Click(object sender, EventArgs e)
        {
            resources_text.Visible = true;
            resources_text.Clear();
            string jsoncs1 = getRestData("/resources/");
            coopres = JToken.Parse(jsoncs1).ToObject<COOP>();

            for (var i = 0; i < coopres.forms.undergraduateForms.Count; i++)
            {
                resources_text.Text += coopres.forms.undergraduateForms[i].formName + Environment.NewLine + "http://ist.rit.edu/" + coopres.forms.undergraduateForms[i].href + Environment.NewLine + Environment.NewLine;
            }

            resources_text.Text += "Graduate Forms" + Environment.NewLine;

            for (var i = 0; i < coopres.forms.graduateForms.Count; i++)
            {
                resources_text.Text += coopres.forms.graduateForms[i].formName + Environment.NewLine + "http://ist.rit.edu/" + coopres.forms.graduateForms[i].href + Environment.NewLine + Environment.NewLine;
            }

        }

        //This entire section is to retreive data on staff in the staff section of people tab to display details about individual staff
        private void staff1_Click(object sender, EventArgs e)
        {

            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for(var n =0; n< stanew.staff.Count; n++)
            {
                if(stanew.staff[n].username == "rdbcst")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine+ stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
           
        }

        private void staff2_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "lwb2627")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff3_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "pxg5962")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff4_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "mchics")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "echics")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff6_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "sxk5664")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff7_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "mdl4959")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff8_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "jdmics")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff9_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "manics")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff10_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "jmpics")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff11_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "tapast")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        private void staff12_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Staff_info.Visible = true;
            string jsonstaff = getRestData("/people/staff/");
            staf stanew = JToken.Parse(jsonstaff).ToObject<staf>();
            for (var n = 0; n < stanew.staff.Count; n++)
            {
                if (stanew.staff[n].username == "jssics")
                {
                    pictureBox5.ImageLocation = stanew.staff[n].imagePath;
                    Staff_info.Text = stanew.staff[n].name + Environment.NewLine + stanew.staff[n].title + Environment.NewLine + stanew.staff[n].phone + Environment.NewLine + stanew.staff[n].office + Environment.NewLine + stanew.staff[n].email + Environment.NewLine + stanew.staff[n].interestArea + Environment.NewLine + stanew.staff[n].tagline + Environment.NewLine + stanew.staff[n].website;
                }
            }
        }

        //This entire section is to retreive data on Faculty in the Faculty section of people tab to display details about individual Faculty
        private void fac1_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "gpavks")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac2_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "dlaics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac3_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "ciiics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac4_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "dsbics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac5_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "cbbics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac6_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "mjfics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac7_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "bdfvks")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac8_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "efgics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac9_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "vlhics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac10_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "bhhics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac11_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "amhgss")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac12_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "lwhfac")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac13_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "ephics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac14_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "mphics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac15_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "jcjics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac16_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "jwkics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac17_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "drkisd")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac18_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "dmlics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac19_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "jalics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac20_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "jalvks")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac21_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "salvse")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac22_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "phlics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac23_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "spmics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac24_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "mjmics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac25_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "thoics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac26_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "sphics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac27_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "nxsvks")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac28_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "aesfaa")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac29_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "bmtski")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac30_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "rpvvks")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac31_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "emwics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac32_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "qyuvks")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        private void fac33_Click(object sender, EventArgs e)
        {
            faculty_pic.Visible = true;
            faculty_info.Visible = true;
            string jsonfaculty = getRestData("/people/faculty/");
            people faculnew = JToken.Parse(jsonfaculty).ToObject<people>();
            for (var n = 0; n < faculnew.faculty.Count; n++)
            {
                if (faculnew.faculty[n].username == "sjzics")
                {
                    faculty_pic.ImageLocation = faculnew.faculty[n].imagePath;
                    faculty_info.Text = faculnew.faculty[n].name + Environment.NewLine + faculnew.faculty[n].title + Environment.NewLine + faculnew.faculty[n].phone + Environment.NewLine + faculnew.faculty[n].office + Environment.NewLine + faculnew.faculty[n].email + Environment.NewLine + faculnew.faculty[n].interestArea + Environment.NewLine + faculnew.faculty[n].tagline + Environment.NewLine + faculnew.faculty[n].website;
                }
            }
        }

        //This entire section is to retreive data on Faculty in Faculty by research area tab to display details about individual faculty based on their Research area
        facres faculresearchnew;
        private void click1(object sender, EventArgs e)
        {
            
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if(faculresearchnew.byFaculty[n].username == "jwkics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "bmtski")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "emwics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "qyuvks")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "sjzics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "thoics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "spmics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "bhhics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "dsbics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "ciiics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }
        
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "lwhfac")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "vlhics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "mjfics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "ephics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "nxsvks")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "dlaics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "cbbics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "mphics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "rpvvks")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            string jsonfacultybyresearch = getRestData("/research/byFaculty/");
            faculresearchnew = JToken.Parse(jsonfacultybyresearch).ToObject<facres>();
            for (var n = 0; n < faculresearchnew.byFaculty.Count; n++)
            {
                if (faculresearchnew.byFaculty[n].username == "dmlics")
                {
                    richTextBox1.Text = faculresearchnew.byFaculty[n].facultyName + Environment.NewLine + string.Join(Environment.NewLine, faculresearchnew.byFaculty[n].citations);
                }
            }
        }
    }
}
