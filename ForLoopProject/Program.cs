using System;

namespace ForLoopProject {
    class Customer {
        public string Name { get; set; }
        public string State { get; set; }
    }

    class Program {
        static void Main(string[] args) {

            Customer[] customers = {
                new Customer { Name = "PG", State = "OH" },
                new Customer { Name = "SDCust", State = "SD" },
                new Customer { Name = "MICust", State = "MI" }
            };

            bool FoundSDCust = false;
            bool FoundMTCust = false;

            foreach(Customer cust in customers) {

                switch(cust.State) {
                    case "MT":
                        FoundMTCust = true;
                        break;
                    case "SD":
                        FoundSDCust = true;
                        break;
                }

                //if(cust.State == "MT") {
                //    FoundMTCust = true;
                //    continue;
                //}
                //if(cust.State == "SD") {
                //    FoundSDCust = true;
                //}

                //if(FoundMTCust && FoundSDCust) {
                //    break;
                //}
            }
            Console.WriteLine($"Found MT customer: {FoundMTCust}");
            Console.WriteLine($"Found SD customer: {FoundSDCust}");

            int i = 0;



















            int[] numbers = { 89 ,188 ,295 ,943, 975, 277, 119,
                            736, 952, 321, 521, 444, 758, 397,
                            915, 878, 674, 701, 379, 331, 804,
                            461, 459 ,908, 373
                        };

            string[] names = { "Braliee", "Briana", "Marianne", "Maggie",
                                "Glenn", "Alex", "Jesse", "Titus" };

            string allNames = "";

            foreach(string name in names) {

                string upperName = name.ToUpper();

                allNames += upperName;

            }

            Console.WriteLine($"The names are {allNames}");















            int total = 0;

            foreach(int Fred in numbers) {
                total += Fred;
            }
            //total = 0;
            //for(int idx = 0; idx < ints.Length; idx++) {
            //    total += ints[idx];
            //}

            decimal average = total / (decimal)numbers.Length;
            Console.WriteLine($"Total: {total}, Average: {average}");
        }
    }
}
