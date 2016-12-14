using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4j.Driver.V1;
using Neo4jClient;

namespace Airport_Project
{
    class ServerQuery
    {
        private GraphClient client;

        public ServerQuery()
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "bigdata");
            client.Connect();

        }
            
        public IEnumerable<Node<CCountry>> getCountries()
        {
            var cnty = client
                .Cypher
                .Match("(c:Country)")
                .Return(c => c.As<Node<CCountry>>())
                .Results;

            return cnty;
        }

        public IEnumerable<Node<Airport>> getAirports(string target)
        {

            var query = client
                .Cypher
                .Match("(a:Airport)-[:LOCATED_AT]->(location:Location)")
                .Where((Location location) => location.City_Country == target)
                .Return(a => a.As<Node<Airport>>())
                .Results;

            return query;


        }

        public Airline getAirline(int ID)
        {
            if (ID > 0)
            {
                var airlinequery = client
                    .Cypher
                    .Match("(a:Airline)")
                    .Where((Airline a) => a.AirlineID == ID)
                    .Return(a => a.As<Airline>())
                    .Results;

                return airlinequery.First();
            }
            return null;

        }

        public Location getLocation(string target)
        {
            var locationquery = client
                .Cypher
                .Match("(location:Location)")
                .Where((Location location) => location.City_Country == target)
                .Return(location => location.As<Location>())
                .Results;

            return locationquery.First();
        }

        public IEnumerable<Node<Route>> findRoutes(int srcID, int dstID)
        {
            var routesQuery = client
                .Cypher
                .Match("(a:Airport)-[:FROM]->(r:Route)-[:TO]->(b:Airport)")
                .Where((Airport a) => a.AirportID == srcID)
                .AndWhere((Airport b) => b.AirportID == dstID)
                .Return(r => r.As<Node<Route>>())
                .Results;

            return routesQuery;
        }
    }
}
