//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Session3OOP
//{
//    internal sealed class CompletedShipment : Shipment
//    {
//        public CompletedShipment(
//            string trackingCode,
//            string description,
//            decimal weight,
//            decimal deliveryFee,
//            DeliveryAddress destination)
//            : base(trackingCode, description, weight, deliveryFee, destination)
//        {
//        }

//        public override void PrintShipment()
//        {
//            Console.WriteLine("----- Completed Shipment -----");
//            base.PrintShipment();
//        }
//    }
//}
