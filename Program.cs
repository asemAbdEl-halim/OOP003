namespace Session3OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Quetion01

            /*
             * 1 - a)  What is the difference between Method Overloading and Method Overriding?
             * ==> Answer <==
             * ==> Overloading: Same method name but different parameters in the same class.
             * ==> Overriding: A child class changes the implementation of a method from the parent class.
             * 
             * 1 - b) What is the difference between Static Binding and Dynamic Binding?
             * => Answer <==
             * Static Binding: The method to call is decided at compile time.
             * Dynamic Binding: The method to call is decided at runtime, usually with virtual and override.
             * **/

            #endregion

            #region Quetion02

            /*
             * 2 - a)  What is the purpose of the sealed keyword when applied to a class?
             * => Answer <==
             * A sealed class cannot be inherited by another class.
             * 
             * 2 - b) What is the difference between a sealed class and a sealed method?
             * => Answer <==
             * Sealed class: Prevents other classes from inheriting from it.
             * Sealed method: Prevents child classes from overriding that method again
             * 
             * 2 - c)  Can a sealed method be overridden? Why?
             * => Answer <==
             * No, a sealed method cannot be overridden because sealed stops further overriding in child classes.
             * **/

            #endregion

            #endregion

            #region Part02

            #region Question01

            /*
             * 1 - Update the Shipment Class
             * **/

            #endregion

            #region Question02

            /*
             * 2 - Constructor Chaining
             * **/

            #endregion

            #region Question03

            /*
             * 3 - Override EstimatedCost

             * **/

            #endregion

            #region Question04

            /*
             * 4 - Override PrintShipment()
             * **/

            #endregion

            #region Question05

            /*
             * 5 - Class Relationships
             * **/

            #endregion

            #region Question06

            /*
             * 6 -  Update DeliveryCenter
             * **/

            #endregion

            #region Question07

            /*
             * 7 -  Create DeliveryHelper
             * **/

            #endregion

            #region Question08

            /*
             * 8 - Sealed Class
             * **/

            #endregion

            #region Question09

            /*
             * 9 -  Sealed Method
             * **/

            #endregion

            #region Question10

            /*
             * 10 -  Main() Checklist
             * **/
            /*
            // ==========================================
            // Delivery Center
            // ==========================================
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // a. Create a Driver
            Driver driver = new Driver(
                1,
                "Ahmed Mohamed",
                "01012345678"
            );

            // b. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();

            // c. Assign Driver to DeliveryCenter
            center.Driver = driver;

            Console.WriteLine("Driver : " + center.Driver.FullName);
            Console.WriteLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine();


            // ==========================================
            // d. Create StandardShipment
            // ==========================================

            StandardShipment standardShipment =
                new StandardShipment(
                    "SH001",
                    "Laptop",
                    3,
                    80,
                    new DeliveryAddress(
                        "Cairo",
                        "Tahrir Street",
                        15
                    )
                );


            // ==========================================
            // e. Create ExpressShipment
            // ==========================================

            ExpressShipment expressShipment =
                new ExpressShipment(
                    "SH002",
                    "Mobile Phone",
                    2,
                    60,
                    new DeliveryAddress(
                        "Cairo",
                        "Nasr City",
                        20
                    ),
                    30
                );


            // ==========================================
            // f. Create InternationalShipment
            // ==========================================

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    "SH003",
                    "Television",
                    8,
                    120,
                    new DeliveryAddress(
                        "Cairo",
                        "Maadi Street",
                        25
                    ),
                    "Germany",
                    100
                );


            // ==========================================
            // g. Add all shipments
            // ==========================================

            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);


            // ==========================================
            // h. Print all shipments
            // ==========================================

            center.PrintAllShipments();


            // ==========================================
            // i. DeliveryHelper
            // ==========================================

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Printing Using DeliveryHelper...");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(standardShipment);
            Console.WriteLine("Standard Shipment Printed Successfully.");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(expressShipment);
            Console.WriteLine("Express Shipment Printed Successfully.");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(internationalShipment);
            Console.WriteLine("International Shipment Printed Successfully.");
            Console.WriteLine();


            // ==========================================
            // j. UpdateWeight Overloading
            // ==========================================

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Updating Weight...");
            Console.WriteLine();

            Console.WriteLine("Original Weight : "
                + standardShipment.Weight + " KG");

            // First version
            standardShipment.UpdateWeight(5);

            Console.WriteLine();
            Console.WriteLine("Updated Weight : "
                + standardShipment.Weight + " KG");

            // Second version
            standardShipment.UpdateWeight(
                standardShipment.Weight,
                0.5m
            );

            Console.WriteLine();
            Console.WriteLine("Updated Weight After Packing : "
                + standardShipment.Weight + " KG");

            Console.WriteLine();


            // ==========================================
            // k. Shipment[] with mixed types
            // ==========================================

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine();

            Shipment[] shipments =
            {
                standardShipment,
                expressShipment,
                internationalShipment
            };

            foreach (Shipment shipment in shipments)
            {
                if (shipment is StandardShipment)
                {
                    Console.WriteLine("Standard Shipment...");
                }
                else if (shipment is ExpressShipment)
                {
                    Console.WriteLine("Express Shipment...");
                }
                else if (shipment is InternationalShipment)
                {
                    Console.WriteLine("International Shipment...");
                }

                shipment.PrintShipment();

                Console.WriteLine();
            }


            // ==========================================
            // l. Sealed Class and Sealed Method
            // ==========================================

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Sealed Class and Sealed Method");
            Console.WriteLine();

            // CompletedShipment is a sealed class.
            // So, we cannot create another class that inherits from it.

            CompletedShipment completedShipment =
                new CompletedShipment(
                    "SH004",
                    "Computer",
                    4,
                    100,
                    new DeliveryAddress(
                        "Cairo",
                        "Heliopolis",
                        10
                    )
                );

            completedShipment.PrintShipment();

            Console.WriteLine();

            // PriorityInternationalShipment overrides
            // GenerateCustomsReport() and makes it sealed.

            PriorityInternationalShipment priorityShipment =
                new PriorityInternationalShipment(
                    "SH005",
                    "Camera",
                    5,
                    150,
                    new DeliveryAddress(
                        "Cairo",
                        "Zamalek",
                        12
                    ),
                    "Germany",
                    80
                );

            priorityShipment.GenerateCustomsReport();

            Console.WriteLine();
            Console.WriteLine("==========================================");
            */
            #endregion

            #endregion
        }
    }
}
