using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace WindowsFormsCountries
{
    public partial class Form1 : Form
    {
        public List<Country> lCountries;

        public Form1()
        {
            InitializeComponent();//funkcija koja kreira samu formu
            /*DATA GRID*/
            lCountries = GetCountries();
            dataGridViewCountries.DataSource = lCountries;

            /*COMBO BOX Filtriranje*/
            List<String> lRegions = lCountries.Where(o => o.sRegion != "").Select(o =>o.sRegion).Distinct().ToList();
            lRegions.Insert(0, "Svi kontinenti");
            comboBoxRegion.DataSource = lRegions;

            /*COMBO BOX sortiranje*/
            List<string> lSortCriterias = new List<string>(){"‐","Glavni grad","Naziv","Broj stanovnika","Povrsina"};
            comboBoxSort.DataSource = lSortCriterias;

            /*COMBO BOX NOVA REGIJA*/
            List<string> lNewRegionOptions = lCountries.Where(o => o.sRegion != "").Select(o => o.sRegion).Distinct().ToList();
            lNewRegionOptions.Insert(0, " - ");
            inptNewRegion.DataSource = lNewRegionOptions;
        }
        public List<Country> GetCountries()
        {
            List<Country> lRestCountries = new List<Country>();         
            string url = (System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"]);
            string sJson = CallRestMethod(url);
            JArray json = JArray.Parse(sJson);
            //čitanje vrijednosti iz Json-a
            foreach (JObject item in json)
            {
                string code = (string)item.GetValue("alpha2Code");
                string name = (string)item.GetValue("name");
                string capital = (string)item.GetValue("capital");
                int population = (int)item.GetValue("population");
                float area = -1;
                if (item.GetValue("area").Type == JTokenType.Null)
                {
                    area = 0;
                }
                else
                {
                    area = (float)item.GetValue("area");
                }
                string region = (string)item.GetValue("region");
                //dodavanje objekata u listu
                lRestCountries.Add(new Country
                {
                    sCode = code,
                    sName = name,
                    sCapital = capital,
                    nPopulation = population,
                    fArea = area,
                    sRegion = region
                });
            }
            return lRestCountries;
         }
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            //webrequest.Headers.Add("Username", "xyz");
            //webrequest.Headers.Add("Password", "abc");
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sRegion = (string)comboBoxRegion.SelectedItem; 
            lCountries = GetCountries();
            if (sRegion != "Svi kontinenti")
            {
                lCountries = lCountries.Where(o => o.sRegion == sRegion).ToList();
                dataGridViewCountries.DataSource = lCountries;//filtrirana lista
            }
            else
            {
                dataGridViewCountries.DataSource = lCountries;
            }
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sChoice = (string)comboBoxSort.SelectedItem;
            lCountries = GetCountries();
            switch (sChoice)
            {
                case "Glavni grad":
                    dataGridViewCountries.DataSource = lCountries.OrderBy(o => o.sCapital).ToList();
                    break;
                case "Naziv":
                    dataGridViewCountries.DataSource = lCountries.OrderBy(o => o.sName).ToList();
                    break;
                case "Broj stanovnika":
                    dataGridViewCountries.DataSource = lCountries.OrderByDescending(o => o.nPopulation).ToList();
                    break;
                case "Povrsina":
                    dataGridViewCountries.DataSource = lCountries.OrderByDescending(o => o.fArea).ToList();
                    break;
                default:
                    dataGridViewCountries.DataSource = lCountries;
                    break;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var ContainsQuery = from c in lCountries where c.sName.Contains(inptSearch.Text) select c;
            List<Country> lContainFilteredCountries = ContainsQuery.ToList();
            for (int i = 0; i < lContainFilteredCountries.Count; i++)
            {
                dataGridViewCountries.DataSource = lContainFilteredCountries;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string NewCode = inptNewCode.Text;
            string NewName = inptNewName.Text;
            string NewCapital = inptNewCapital.Text;
            int NewPopulation = Convert.ToInt32(inptNewPopulation.Text);
            float NewArea = Convert.ToSingle(inptNewArea.Text);
            string NewRegion = inptNewRegion.Text;
            Country zemljica=new Country()
            {
                sCode =NewCode,
                sName = NewName,
                sCapital = NewCapital,
                nPopulation = NewPopulation,
                fArea = NewArea,
                sRegion = NewRegion
            };
            lCountries.Add(zemljica);
            dataGridViewCountries.DataSource = lCountries;
        }
    }
}




/* string sUrl = (System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"]);
 Debug.WriteLine(sUrl);//provjera vrijednosti varijabli iz app.config-a
 Trace.WriteLine(sUrl);//prikaz u outputu
  
     
 List<String> lRegions = lCountries.Where(o => o.sRegion != "").Select(o =>o.sRegion).Distinct().ToList();
 //link za dohvaćanje distinct djelova liste (dohvaćanje jedinstvenih vrijednosti liste)
 
     Kod dodavanja nov države mora se pozvati ona lista u koju smo dodali novu državu. 
 */
