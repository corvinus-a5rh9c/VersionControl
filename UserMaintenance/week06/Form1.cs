using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using week06.Entities;
using week06.MnbServiceReference;

namespace week06
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();
        string result;
        public Form1()
        {
            InitializeComponent();
            currency(GetCurrencies().ToString());
            RefreshData();
            ShowData();
            
        }
        public void currency(string xmll)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmll);

            foreach (XmlElement item in xml.DocumentElement.ChildNodes[0])
            {
                Currencies.Add(item.InnerText);
            }
            comboBoxCurrency.DataSource = Currencies;
        }
        string GetCurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var requestCurr = new GetCurrenciesRequestBody();
            var responseCurr = mnbService.GetCurrencies(requestCurr);
            var resultCurr = responseCurr.GetCurrenciesResult;
            return resultCurr;
        }

        public void RefreshData()
        {
            Rates.Clear();
            LoadWeb();
            ShowData();
            dataGridView1.DataSource = Rates;
            Xml(result);
        }
        public void LoadWeb()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBoxCurrency.SelectedItem.ToString(),
                startDate = dateTimePickerStart.Value.ToString(),
                endDate = dateTimePickerEnd.Value.ToString(),
                //currencyNames = "EUR"
            };
            var response = mnbService.GetExchangeRates(request);
            result = response.GetExchangeRatesResult;
            
        }

        public void ShowData()
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }
        public void Xml(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);

                // Dátum
                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                // Valuta
                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                // Érték
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
