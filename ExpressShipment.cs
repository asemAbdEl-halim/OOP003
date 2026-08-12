//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Session3OOP
//{
//    internal class ExpressShipment : Shipment
//    {
//        private decimal extraFee;

//        public decimal ExtraFee
//        {
//            get { return extraFee; }

//            set
//            {
//                if (value >= 0)
//                    extraFee = value;
//            }
//        }

//        public ExpressShipment(
//            string trackingCode,
//            string description,
//            decimal weight,
//            decimal deliveryFee,
//            DeliveryAddress destination,
//            decimal extraFee)
//            : base(trackingCode, description, weight, deliveryFee, destination)
//        {
//            if (extraFee >= 0)
//                this.extraFee = extraFee;
//            else
//                this.extraFee = 0;
//        }

//        public override decimal EstimatedCost
//        {
//            get
//            {
//                return DeliveryFee + (Weight * 5) + ExtraFee;
//            }
//        }

//        public override void PrintShipment()
//        {
//            Console.WriteLine("----- Express Shipment -----");
//            base.PrintShipment();
//            Console.WriteLine("Extra Fee: " + ExtraFee + " EGP");
//        }
//    }
//}
