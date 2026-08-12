//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Session3OOP
//{
//    internal class InternationalShipment : Shipment
//    {
//        private string destinationCountry;
//        private decimal customsFee;

//        public string DestinationCountry
//        {
//            get { return destinationCountry; }

//            set
//            {
//                if (!string.IsNullOrWhiteSpace(value))
//                    destinationCountry = value;
//            }
//        }

//        public decimal CustomsFee
//        {
//            get { return customsFee; }

//            set
//            {
//                if (value >= 0)
//                    customsFee = value;
//            }
//        }

//        public InternationalShipment(
//            string trackingCode,
//            string description,
//            decimal weight,
//            decimal deliveryFee,
//            DeliveryAddress destination,
//            string destinationCountry,
//            decimal customsFee)
//            : base(trackingCode, description, weight, deliveryFee, destination)
//        {
//            if (!string.IsNullOrWhiteSpace(destinationCountry))
//                this.destinationCountry = destinationCountry;
//            else
//                this.destinationCountry = "Unknown";

//            if (customsFee >= 0)
//                this.customsFee = customsFee;
//            else
//                this.customsFee = 0;
//        }

//        public override decimal EstimatedCost
//        {
//            get
//            {
//                return DeliveryFee + (Weight * 5) + CustomsFee;
//            }
//        }

//        public override void PrintShipment()
//        {
//            Console.WriteLine("----- International Shipment -----");
//            base.PrintShipment();
//            Console.WriteLine("Destination Country: " + DestinationCountry);
//            Console.WriteLine("Customs Fee: " + CustomsFee + " EGP");
//        }
//    }
//}
