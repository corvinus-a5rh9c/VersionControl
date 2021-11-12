using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Abstractions;
using week08.Abstractions;
using week08.Entities;

namespace week08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private List<Toy> _toys = new List<Toy>();
        private IToyFactory _factory;
        public IToyFactory Factory
        {

            get { return _factory; }
            set
            {
                _factory = value;
                DisplayNext();
            }
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (Toy toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                    maxPosition = toy.Left;
            }
            if (maxPosition > 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
        }
        private Toy _nextToy;
        private void Carbutton_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void Ballbutton_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory
            {
                BallColor = btnBallColor.BackColor
            };
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = lblNext.Top + lblNext.Height + 20;
            _nextToy.Left = lblNext.Left;
            Controls.Add(_nextToy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();
            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
        }

        private void Presentbutton_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory
            {
                RibbonColor = Ribbonbutton.BackColor,
                BoxColor = Boxbutton.BackColor
            };
        }
    }
}
