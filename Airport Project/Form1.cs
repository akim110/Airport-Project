using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;

namespace Airport_Project
{
    public partial class Form1 : Form
    {
        GraphClient client;
        ServerQuery SQ;

        /* Textboxes called srcCity, destCity
         * Combo boxes called Countries, srcCountry, dstCountry
         * 
         */
        public Form1()
        {
            InitializeComponent();
            SQ = new ServerQuery();
            initServer();
            fillCountries();

        }

        private void fillCountries()
        {
            //var cnty = SQ.getCountries();
            var cnty = client
                .Cypher
                .Match("(c:Country)")
                .Return(c => c.As<Node<CCountry>>())
                .Results;

            foreach (var c in cnty)
            {
                countries.Items.Add(c.Data.Country);
                srcCountry.Items.Add(c.Data.Country);
                dstCountry.Items.Add(c.Data.Country);
            }
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            // Node<Airport> src;
            //Node<Airport> dst;
            IEnumerable<Node<Airport>> srcCities = null;
            IEnumerable<Node<Airport>> dstCities = null;
            IEnumerable<Node<Route>> routes = null;
            tab2Results.Clear();
            string target = srcCity.Text + "_" + srcCountry.Text;
            if (srcCity.Text != "")
                srcCities = SQ.getAirports(target);
            if (dstCity.Text != "")
                dstCities = SQ.getAirports(dstCity.Text + "_" + dstCountry.Text);
            /*var test = client
                .Cypher
                .Match("(a:Airport)-[:FROM]->(r:Route)-[:TO]->(b:Airport)")
                .Where()
                .AndWhere("(r)-[:OPERATED_BY]->(airline:Airline)")*/


            /*var routesQuery = client
                .Cypher
                .Start(srcCities)
                .Match("(srcCities)-[:FROM]->(r:Route)-[:TO]->(dstCities)")
                .Return(r => r.As<Node<Route>>())
                .Results;
        
            foreach (var r in routesQuery)
            {
                tab2Results.Text += r.Data.to_from + "\r\n";
            }*/
            //Location dst = SQ.getLocation(dstCity.Text + "_" + srcCountry.Text);
            //srcAirport = SQ.getAirport(target).First();
            foreach (var src in srcCities)
            {
                
                foreach (var dst in dstCities)
                {
                    
                    routes = SQ.findRoutes(src.Data.AirportID, dst.Data.AirportID);
                    /* var routesQuery = client
                .Cypher
                .Match("(a:Airport)-[:FROM]->(r:Route)-[:TO]->(b:Airport)")
                .OptionalMatch("(r)-[:OPERATED_BY]->(airline:Airline)")
                .Where((Airport a) => a.AirportID == srcID)
                .AndWhere((Airport b) => b.AirportID == dstID)
                .Return((r,airline) => new {
                    Route = r.As<Node<Route>>(),
                    Airline = airline.As<Node<Airline>>() })

                .Results;*/
                    foreach (var txt in routes)
                    {
                        Airline ar = SQ.getAirline(txt.Data.AirlineID);
                        if (ar != null)
                            tab2Results.Text += src.Data.AirportName + ":\r\n" + txt.Data.to_from +
                                " Operated by " + ar.Name + "\r\n";

                    }
                }
                


            }
        }
        private void initServer()
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"),"neo4j", "bigdata");
            client.Connect();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tab2Results.Clear();
            var airports = client
                .Cypher
                .Match("(a)-[:OPERATING_IN]-(c:Country)")
                .Where((CCountry c) => c.Country == countries.Text)
                .Return(a => a.As<Airport>())
                .Results;

            foreach (var ar in airports)
            {
                tab2Results.Text += ar.AirportName + "\r\n";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tab2Results.Clear();

            var airlines = client
                .Cypher
                .Match("(a)-[:OPERATED_FROM]-(c:Country)")
                .Where((CCountry c) => c.Country == countries.Text)
                .Return(a => a.As<Airline>())
                .Results;

            foreach (var ar in airlines)
            {
                tab2Results.Text += ar.Name + "\r\n";
            }
        }
    }

    public class Location
    {
        public string City_Country { get; set; }
    }
    public class Airline
    {
        public string Name { get; set; }
        public int AirlineID { get; set; }
        public bool Active { get; set; }
        public string Callsign { get; set; }
        public string Alias { get; set; }
        public string IATA { get; set; }
        public string ICAO { get; set; }
    }
    public class Airport
    {
        public int AirportID { get; set; }
        public string AirportName { get; set; }
        public string ICAO { get; set; }
    }
    public class CCountry
    {
        public string Country { get; set; }
    }
    public class Route
    {
        public string to_from { get; set; }
        public int AirlineID { get; set; }
    }
}
