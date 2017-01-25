using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAM
{
    public partial class AffectedAreas : MetroForm
    {
        public AffectedAreas()
        {
            InitializeComponent();
            gmap.DragButton = System.Windows.Forms.MouseButtons.Left;
        }


        private void districtOne()
        {
            
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            //points.Add(new PointLatLng(7.112349, 125.497362));
            //points.Add(new PointLatLng(7.100510, 125.497448));
           // points.Add(new PointLatLng(7.099999, 125.504830));
            points.Add(new PointLatLng(7.107409, 125.504916));
            points.Add(new PointLatLng(7.105961, 125.543539));
            points.Add(new PointLatLng(7.118992, 125.543711));
            //points.Add(new PointLatLng(7.125891, 125.525858));
            points.Add(new PointLatLng(7.120695, 125.506890));
            points.Add(new PointLatLng(7.110986, 125.505602));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.115074, 125.518477);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 14;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
        }

        private void districtTwo()
        {
           
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.125237, 125.518616));
            points.Add(new PointLatLng(7.124300, 125.526856));
            points.Add(new PointLatLng(7.119701, 125.532692));
            points.Add(new PointLatLng(7.119701, 125.532692));
            points.Add(new PointLatLng(7.119020, 125.543679));
            points.Add(new PointLatLng( 7.116806, 125.543979));
	        points.Add(new PointLatLng(7.117231, 125.546254));
	        points.Add(new PointLatLng(7.121745, 125.548228));
	        points.Add(new PointLatLng(7.122256, 125.551661));
	        points.Add(new PointLatLng(7.128729, 125.556982));
	     	points.Add(new PointLatLng(7.123364, 125.561532));
	        points.Add(new PointLatLng(7.129441, 125.562047));
	        points.Add(new PointLatLng(7.127537, 125.570372));
	        points.Add(new PointLatLng(7.142100, 125.567883));
	        points.Add(new PointLatLng(7.143548, 125.553721));
	        points.Add(new PointLatLng(7.150617, 125.542992));
	        points.Add(new PointLatLng(7.153001, 125.531748));
	        points.Add(new PointLatLng(7.149595, 125.522908));
            points.Add(new PointLatLng(7.147380, 125.516299));
	        GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.134521, 125.539645);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 14;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
            
        }
        private void districtThree()
        {
            
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.111412, 125.505559));
            points.Add(new PointLatLng(7.119844, 125.506246));
            points.Add(new PointLatLng(7.117970, 125.490625));
            points.Add(new PointLatLng(7.104002, 125.491741));

            points.Add(new PointLatLng(7.098423, 125.496847));

            points.Add(new PointLatLng(7.107528, 125.502474));
            points.Add(new PointLatLng(7.106080, 125.516293));
	        points.Add(new PointLatLng(7.095646, 125.515778));
            points.Add(new PointLatLng(7.096157, 125.500629));

            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.110390, 125.494315);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 14;
            gmap.Manager.Mode = AccessMode.ServerAndCache;

        }

        private void districtFour()
        {
            
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.111623, 125.488223));
            points.Add(new PointLatLng(7.114817, 125.484897));
            points.Add(new PointLatLng(7.109877, 125.480198));
            points.Add(new PointLatLng(7.107236, 125.483353));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.110047, 125.483975);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 16;
            gmap.Manager.Mode = AccessMode.ServerAndCache;

        }

        private void districtFive()
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.128465, 125.472752));
            points.Add(new PointLatLng(7.116541, 125.473439));
            points.Add(new PointLatLng(7.106576, 125.459449));
            points.Add(new PointLatLng(7.106236, 125.447904));
            points.Add(new PointLatLng(7.111346, 125.443656));
            points.Add(new PointLatLng(7.128209, 125.457346));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.118330, 125.459062);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 14;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
        }


        private void districtSix()
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.116143, 125.433013));
            points.Add(new PointLatLng(7.089655, 125.431468));
            points.Add(new PointLatLng(7.091784, 125.453097));
            points.Add(new PointLatLng(7.094169, 125.452839));
            points.Add(new PointLatLng(7.095106, 125.468718));
            points.Add(new PointLatLng(7.106859, 125.468804));
            points.Add(new PointLatLng(7.106774, 125.448033));
            points.Add(new PointLatLng(7.114695, 125.448805));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.104134, 125.439450);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 14;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
        }
        private void districtSeven()
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.080986, 125.493711));
            points.Add(new PointLatLng(7.073320, 125.493797));
            points.Add(new PointLatLng(7.073746, 125.512079));
            points.Add(new PointLatLng(7.061565, 125.519031));
            points.Add(new PointLatLng(7.050406, 125.504097));
            points.Add(new PointLatLng(7.061650, 125.486759));
            points.Add(new PointLatLng(7.080986, 125.483583));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.062332, 125.503582);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 14;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
        }

        private void districtEight()
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.073598, 125.504228));
            points.Add(new PointLatLng(7.074620, 125.512682));
            points.Add(new PointLatLng(7.090931, 125.514184));
            points.Add(new PointLatLng(7.092379, 125.505172));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.078453, 125.508476);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 14;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
        }

        private void districtNine()
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.069247, 125.517062));
            points.Add(new PointLatLng(7.082322, 125.529079));
            points.Add(new PointLatLng(7.091819, 125.513586));
            points.Add(new PointLatLng(7.075976, 125.511869));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.079894, 125.517878);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 14;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
        }

        private void districtTen()
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.078872, 125.530108));
            points.Add(new PointLatLng(7.067544, 125.539722));
            points.Add(new PointLatLng(7.060772, 125.532168));
            points.Add(new PointLatLng(7.068268, 125.520925));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.069375, 125.530538);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 15;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
        }

        private void districtEleven()
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.067629, 125.539121));
            points.Add(new PointLatLng(7.061325, 125.532126));
            points.Add(new PointLatLng(7.057535, 125.537061));
            points.Add(new PointLatLng(7.062986, 125.542554));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.061879, 125.538434);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 15;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
        }

        private void districtTweleveThirteen()
        {
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(7.080216, 125.469156));
            points.Add(new PointLatLng(7.080557, 125.493189));
            points.Add(new PointLatLng(7.073232, 125.493618));
            points.Add(new PointLatLng(7.074084, 125.503746));
            points.Add(new PointLatLng(7.094781, 125.504004));
            points.Add(new PointLatLng(7.094781, 125.468813));
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.DarkRed, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Position = new PointLatLng(7.084134, 125.487438);
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.Zoom = 14;
            gmap.Manager.Mode = AccessMode.ServerAndCache;
            
        }
        //************************************************************************************** CONNECTION STRING
        string connString = "server=localhost;database=psam;Persist Security Info=True;User Id=root;password=root";
        //************************************************************************************** CONNECTION STRING
        private void loadDisaster()
        {
            MySqlConnection myconn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string query = "SELECT gkkdetails.district, household.houseHoldID, affectedareas.houseHoldID, CONCAT(disaster.disasterType, ': ', DATE_FORMAT(disaster.disasterDate,'%b %d %Y')) as disasterName FROM gkkdetails, household, affectedareas, disaster WHERE affectedareas.houseHoldID = household.houseHoldID AND household.gkkID = gkkdetails.gkkID AND disaster.disasterID = affectedareas.disasterID GROUP BY affectedareas.disasterID";

            string disaster = query;
            MySqlCommand mycommand = new MySqlCommand(disaster, myconn);
            MySqlDataAdapter da = new MySqlDataAdapter(mycommand);
            da.Fill(dt);
            disasterCombo.DataSource = dt;
            disasterCombo.DisplayMember = "disasterName";
            disasterCombo.ValueMember = "district";
        }
        private void AffectedAreas_Load(object sender, EventArgs e)
        {
            //districtTwo();
           // districtOne();
            //districtThree();
           // districtFour();
           // districtEight();
           // districtTweleveThirteen();
            loadDisaster();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Clear();
            int district = Int32.Parse(disasterCombo.SelectedValue.ToString());
            switch (district)
            {
                case 1: districtOne(); break;
                case 2: districtTwo(); break;
                case 3: districtThree(); break;
                case 4: districtFour(); break;
                case 5: districtFive(); break;
                case 6: districtSix(); break;
                case 7: districtSeven(); break;
                case 8: districtEight(); break;
                case 9: districtNine(); break;
                case 10: districtTen(); break;
                case 11: districtEleven(); break;
                case 12: districtTweleveThirteen(); break;
                case 13: districtTweleveThirteen(); break;


            }
        }
    }
}
